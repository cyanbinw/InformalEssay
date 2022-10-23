using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.TestTreeNode
{
    public class TreeNodeWork : BaseTest
    {
        public override void Run()
        {
            List<NodeData> list = new List<NodeData>();
            for (int i = 0; i < 1000; i++)
            {
                if (i == 0)
                {
                    list.Add(new NodeData(0, -1, "test", 1));
                }
                if (i < 10 && i > 0)
                {
                    list.Add(new NodeData(i, 0, "text" + i.ToString(), i));
                }
                if (i > 10)
                {
                    list.Add(new NodeData(i, i / 10, "text" + i.ToString(), i));
                }
            }
            var data = installTree(new TreeNode(), list);
            Console.WriteLine(data.Nodes[0].Root.Data.Value);
        }

        static TreeNode installTree(TreeNode tree, List<NodeData> list)
        {
            var id = tree.Data.Id;
            if (tree == null || tree.Data.Id == 0)
            {
                id = list.Min(c => c.Id);
                var data = list.Where(c => c.Id == id).FirstOrDefault();
                if (data != null)
                {
                    tree = new TreeNode(data);
                    tree.Parent = null;
                    tree.Level = 0;
                }
                else
                {
                    return null;
                }

            }

            if (list.Where(c => c.ParentId == id).FirstOrDefault() == null)
            {
                return tree;
            }
            foreach (var i in list.Where(c => c.ParentId == id).ToList())
            {
                var itemList = list.Where(c => c.ParentId != id).ToList();

                TreeNode data = new TreeNode(i);
                data.Level = tree.Level + 1;
                tree.Nodes.Add(installTree(data, itemList));
            }
            return tree;
        }
    }
}
