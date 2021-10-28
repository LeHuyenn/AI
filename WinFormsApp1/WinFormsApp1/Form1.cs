using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int startNodeInt, endNodeInt;
		List<List<int>> Matrix = new List<List<int>>();
		public Form1()
        {
            InitializeComponent();
			MainWindow();
		}
        private void groupBox1_Enter(object sender, EventArgs e){ }
        private void label1_Click(object sender, EventArgs e){}
        private void label1_Click_1(object sender, EventArgs e){}
        private void listView1_SelectedIndexChanged(object sender, EventArgs e){}
        private void pictureBox1_Click(object sender, EventArgs e){}
        private void groupBox2_Enter(object sender, EventArgs e) {}
		public struct stepWay
		{
			public int node1;
			public int node2;
		};

		Tuple<bool, bool> checkin_list(int inChecking, List<int> nodeOPENED, List<int> nodeCLOSED)
		{
			bool inNodeOPENED = false;
			bool inNodeCLOSED = false;
			for (int i = 0; i < nodeOPENED.Count; i++)
			{
				if (inChecking == nodeOPENED[i])
				{
					inNodeOPENED = true;
				}
			}
			for (int i = 0; i < nodeCLOSED.Count; i++)
			{
				if (inChecking == nodeCLOSED[i])
				{
					inNodeCLOSED = true;
				}
			}
			return Tuple.Create(inNodeOPENED, inNodeCLOSED);
		}

		string find_way(List<stepWay> stepVector, int nodeEnd, int nodeStart)
		{
			List<int> nextStep = new List<int> ();
			List<int> wayFinal = new List<int> ();
			while (true)
			{

				if (nextStep.Count== 0 && wayFinal.Count == 0)
				{
					nextStep.Add(nodeEnd);
					wayFinal.Add(nodeEnd);
				}
				else if (nextStep.Count == 0 && wayFinal.Count != 0)
				{
					break;
				}
				List<int> nextStepCache = new List<int>();
				for (int i = 0; i < stepVector.Count; i++)
				{
					for (int j = 0; j < nextStep.Count; j++)
					{
						if (stepVector[i].node1 == nextStep[j])
						{
							int coutOverlap = 0;
							for (int x = 0; x < nextStepCache.Count; x++)
							{
								if (stepVector[i].node2 == nextStepCache[x])
								{
									coutOverlap++;
								}
							}
							if (coutOverlap == 0)
							{
								nextStepCache.Add(stepVector[i].node2);
							}

						}
					}
				}
				nextStep.Clear();
				for (int i = 0; i < nextStepCache.Count; i++)
				{
					nextStep.Add(nextStepCache[i]);
					wayFinal.Add(nextStepCache[i]);
				}
			}

			string finalWayFound = (wayFinal[wayFinal.Count - 1]).ToString();
			for (int i = wayFinal.Count - 2; i >= 0; i--)
			{
				finalWayFound = finalWayFound + "-" + (wayFinal[i]).ToString();
			}
			return finalWayFound;

		}

		void find_follow_depth(List<List<int>> Matrix, int nodeStart, int nodeEnd)
		{
			List<int> nodeOPENED = new List<int>();
			List<int>  nodeCLOSED = new List<int>();
			List<int> nodeOPENEDTree= new List<int>();
			List<int> nodeCLOSEDTree = new List<int>();
			
			List<stepWay> stepVector = new List<stepWay>();
			nodeOPENED.Add(nodeStart);
			nodeOPENEDTree.Add(nodeStart);
			int step = 0;
			while (true)
			{

				List<int> nodeOPENEDCache = new List<int>();
				step++;
				if (nodeOPENED.Count == 0)
				{
					break;
				}

				for (int i = 0; i < nodeOPENED.Count; i++)
				{

					List<int> nodeOPENEDTreeCache=new List<int>();
					int a = nodeOPENED[i] - 1;
					for (int j = 0; j < 10; j++)
					{

						if (Matrix[nodeOPENED[i] - 1][j] == 1)
						{
							bool inNodeOPENED = true;
							bool inNodeCLOSED = true;
							var inNode = checkin_list(j + 1, nodeOPENEDTree, nodeCLOSEDTree);
							inNodeOPENED = inNode.Item1;
							inNodeCLOSED = inNode.Item2;
							if (inNodeOPENED == false && inNodeCLOSED == false)
							{
								nodeOPENEDCache.Add(j + 1);
								nodeOPENEDTreeCache.Add(j + 1);
								stepWay coupleNode;
								coupleNode.node1 = j + 1;
								coupleNode.node2 = nodeOPENED[i];
								stepVector.Add(coupleNode);
							}
						}
					}

					if (nodeOPENEDTree[0] != nodeEnd)
					{
						nodeCLOSEDTree.Add(nodeOPENEDTree[0]);
						nodeOPENEDTree.Remove(nodeOPENEDTree.First());
						for (int x = 0; x < nodeOPENEDTreeCache.Count; x++) {
							nodeOPENEDTree.Insert(x, nodeOPENEDTreeCache[x]);
						}
					}
					else
					{
						break;
					}
					string listNodeOPENED = "";
					string listNodeCLOSED = "";
					for (int x = 0; x < nodeOPENEDTree.Count; x++)
					{
						listNodeOPENED = listNodeOPENED + " " + (nodeOPENEDTree[x]).ToString();
					}
					for (int y = 0; y < nodeCLOSEDTree.Count; y++)
					{
						listNodeCLOSED = listNodeCLOSED + " " + (nodeCLOSEDTree[y]).ToString();
					}
					break;
				}
				if (nodeOPENED[0] == nodeEnd)
				{
					break;
				}
				nodeCLOSED.Add(nodeOPENED[0]);
				nodeOPENED.Remove(nodeOPENED.First());
				for (int z = 0; z < nodeOPENEDCache.Count; z++) {
					nodeOPENED.Insert(z, nodeOPENEDCache[z]);
				}
			}
			wayInDepth.Text=find_way(stepVector, nodeEnd, nodeStart);
			stepInDepth.Text = step.ToString();
		}

		void find_follow_width(List<List<int>> Matrix, int nodeStart, int nodeEnd)
		{
			List<int> nodeOPENED = new List<int>();
			List<int> nodeCLOSED = new List<int>();
			List<int> nodeOPENEDTree = new List<int>();
			List<int> nodeCLOSEDTree = new List<int>();
			List<stepWay> stepVector= new List<stepWay>();
			nodeOPENED.Add(nodeStart);
			nodeOPENEDTree.Add(nodeStart);
			int step = 0;
			while (true)
			{
				step++;
				if (nodeOPENED.Count == 0)
				{
					break;
				}
				for (int i = 0; i < nodeOPENED.Count; i++)
				{
					for (int j = 0; j < 10; j++)
					{
						if (Matrix[nodeOPENED[i] - 1][j] == 1)
						{

							bool inNodeOPENED = true;
							bool inNodeCLOSED = true;
							var inNode = checkin_list(j + 1, nodeOPENED, nodeCLOSED);
							inNodeOPENED = inNode.Item1;
							inNodeCLOSED = inNode.Item2;
							if (inNodeOPENED == false && inNodeCLOSED == false)
							{
								nodeOPENED.Add(j + 1);
								nodeOPENEDTree.Add(j + 1);
								stepWay coupleNode;
								coupleNode.node1 = j + 1;
								coupleNode.node2 = nodeOPENED[i];
								stepVector.Add(coupleNode);
							}
						}
					}
					if (nodeOPENEDTree[0] != nodeEnd)
					{
						nodeCLOSEDTree.Add(nodeOPENEDTree[0]);
						nodeOPENEDTree.Remove(nodeOPENEDTree.First());
					}
					else
					{
						break;
					}
					string listNodeOPENED = "";
					string listNodeCLOSED = "";
					for (int x = 0; x < nodeOPENEDTree.Count; x++)
					{
						listNodeOPENED = listNodeOPENED + " " + (nodeOPENEDTree[x]).ToString();
					}
					for (int y = 0; y < nodeCLOSEDTree.Count; y++)
					{
						listNodeCLOSED = listNodeCLOSED + " " + (nodeCLOSEDTree[y]).ToString();
					}
				}
				if (nodeOPENED[0] == nodeEnd)
				{
					break;
				}
				nodeCLOSED.Add(nodeOPENED[0]);
				nodeOPENED.Remove(nodeOPENED.First());
			}
			wayInWidth.Text=find_way(stepVector, nodeEnd, nodeStart);
			stepInWidth.Text = step.ToString();

		}

		private void button1_Click(object sender, EventArgs e)
        {
			startNode.Text = "";
			endNode.Text = "";
        }

        private void findWayFollowDepth_Click(object sender, EventArgs e)
        {
			find_follow_depth(Matrix, startNodeInt, endNodeInt);
		}

        private void findWayFollowWidth_Click(object sender, EventArgs e)
        {
			find_follow_width(Matrix, startNodeInt, endNodeInt);
		}

        private void startNode_TextChanged(object sender, EventArgs e)
        {
			try
			{
				startNodeInt = Int32.Parse(startNode.Text);
			}
			catch (FormatException me) { 
			}
			
		}

        private void endNode_TextChanged(object sender, EventArgs e)
        {
			try
			{
				endNodeInt = Int32.Parse(endNode.Text);
			}
			catch (FormatException me)
			{
			}
			
		}

        void MainWindow() {
            int[,] TAdjacencyMatrix = {
                { 0, 1, 1, 0, 0, 0, 0, 0, 0, 1 }, 
	            { 0, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
	            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
	            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 	            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
	            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
	            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	            { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 }
            };
			for (int i = 0; i < 10; i++) {
				Matrix.Add(new List<int>());
				for (int j = 0; j < 10; j++) {
					int a = TAdjacencyMatrix[i, j];
					Matrix[i].Add(a);
				}
			}
            
            
        }

    }
}
