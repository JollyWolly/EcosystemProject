using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemProject
{
	class KDTree
	{
		private Node _root { get; set; }

		public KDTree()
        {
			_root = null;
        }

		public void AddList(List<Coord> oList, int depth)
        {
			if (oList.Count == 0)
			{
				//Insert(oList[0]);
				return;
			}

			List<Coord> dList;
			if (depth % 2 == 0) // if on x axis, orderlist by x coord, else by y coord
				dList = oList.OrderBy(o => o.x).ToList();
			else
				dList = oList.OrderBy(o => o.y).ToList();

			// insert center node
			int indexCenter = dList.Count/2;
			Insert(dList[indexCenter]);

			List<Coord> rList = new List<Coord>();
			List<Coord> lList = new List<Coord>();

			for (int i = 0; i < (indexCenter); i++)
				lList.Add(dList[i]);
			for (int j = indexCenter+1; j < dList.Count; j++)
				rList.Add(dList[j]);

			AddList(lList, depth+1);
			AddList(rList, depth+1);
        }

		public void Insert(Coord c)
        {
			int depth = 0;
			if (_root == null)
            {
				_root = new Node(c, 0);
				
            }

			InsertRec(_root, c, depth++);
        }

		private void InsertRec(Node root, Coord c, int depth)
        {
			if (root == null)
				root = new Node(c, depth);
			
			if (depth%2 == 0)
            {
				if (c.x < root.coord.x)
				{
					if (root.left == null)
						root.left = new Node(c, depth);
					InsertRec(root.left, c, depth++);
				}
				else
				{
					if (root.right == null)
						root.right = new Node(c, depth);
					else
						InsertRec(root.right, c, depth++);
				}
            }
			else
            {
				if (c.y < root.coord.y)
				{
					if (root.left == null)
						root.left = new Node(c, depth);
					InsertRec(root.left, c, depth++);
				}
				else
				{
					if (root.right == null)
						root.right = new Node(c, depth);
					else
						InsertRec(root.right, c, depth++);
				}
			}
        }

		public Coord findNearestNeighbor(Coord c)
        {
			return findNearestNeighbor(_root, c, 0).coord;
        }

		private Node findNearestNeighbor(Node root, Coord c, int depth)
        {
			if (root == null)
				return null;
			
			Node nextBranch;
			Node otherBranch;

			if (depth%2 == 0)
            {
				if (c.x < root.coord.x)
				{
					nextBranch = root.left;
					otherBranch = root.right;
				}
				else
                {
					nextBranch = root.right;
					otherBranch = root.left;
                }
            }
			else
			{
				if (c.y < root.coord.y)
				{
					nextBranch = root.left;
					otherBranch = root.right;
				}
				else
				{
					nextBranch = root.right;
					otherBranch = root.left;
				}
			}

			Node temp = findNearestNeighbor(nextBranch, c, depth + 1);
			Node best = getClosest(c, temp, root);

			double radius = c.getDistance(best.coord);
			double dist;
			if (depth % 2 == 0)
				dist = c.getDistSqrd(Coord.coordAt(root.coord.x, c.y));
			else
				dist = c.getDistSqrd(Coord.coordAt(c.x, root.coord.y));

			if (radius >= dist)
            {
				temp = findNearestNeighbor(otherBranch, c, depth + 1);
				best = getClosest(c, temp, root);
			}

			return best;
        }

		private Node getClosest(Coord c, Node a, Node b)
		{
			if (a == null)
				return b;
			if (b == null)
				return a;
			if (c.getDistSqrd(a.coord) > c.getDistSqrd(b.coord))
				return b;
			return a;
		}
	}

	class Node
	{
		public Node left { get; set; }
		public Node right { get; set; }
		public Coord coord { get; set; }
		public int depth { get; set; }
		public Node(Coord c, int d)
        {
			coord = c;
			depth = d;
        }
	}
}
