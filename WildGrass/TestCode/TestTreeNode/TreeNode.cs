using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestCode.TestTreeNode
{
    /// <summary>
    /// 树型结构的节点, 也代表一棵树
    /// </summary>
    public class TreeNode
    {
        /// <summary>
        /// 节点代表的数据
        /// </summary>
        public NodeData Data
        {
            get;
            set;
        }

        /// <summary>
        /// 子节点集合
        /// </summary>
        public NodeCollection Nodes { get; private set; }

        /// <summary>
        /// 节点的级别
        /// </summary>
        public int Level { get; internal set; }

        /// <summary>
        /// 父节点
        /// </summary>
        public TreeNode Parent { get; internal set; }

        public TreeNode(NodeData t)
        {
            this.Nodes = new NodeCollection(this);
            this.Data = t;
        }

        public TreeNode()
            : this(new NodeData())
        { }

        /// <summary>
        /// 根节点
        /// </summary>
        public TreeNode Root
        {
            get
            {
                if (this.Parent == null)
                    return this;
                TreeNode root = this.Parent;
                while (root != null)
                {
                    root = root.Parent;
                }
                return root;
            }
        }
    }

    /// <summary>
    /// 节点的集合
    /// </summary>

    public class NodeCollection : List<TreeNode>
    {
        private TreeNode parent = null;
        public NodeCollection(TreeNode parent)
        {
            this.parent = parent;
        }
        public void Add(TreeNode t)
        {
            if (this.parent != null)
            {
                t.Parent = this.parent;
                t.Level = this.parent.Level + 1;
                foreach (var childNode in t.Nodes)
                {
                    childNode.Level = t.Level + 1;
                }
            }
            base.Add(t);
        }

        public void AddRange(IEnumerable<TreeNode> collection)
        {
            foreach (var node in collection)
            {
                this.Add(node);
            }
        }

        public new void Add(NodeData t)
        {
            TreeNode node = new TreeNode();
            node.Data = t;
            this.Add(node);
        }
    }

}