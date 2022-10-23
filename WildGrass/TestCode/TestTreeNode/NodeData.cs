using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestCode.TestTreeNode
{
    /// <summary>
    /// 节点，ParentId指向父节点的Id
    /// </summary>
    public class NodeData
    {
        /// <summary>
        /// 记录标识
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// 指向父节点的Tid，用于确定层级关系
        /// </summary>
        public int ParentId { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Text { set; get; }

        /// <summary>
        /// 值
        /// </summary>
        public double Value { get; set; }

        public NodeData() { }

        public NodeData(int id, int parentID, string text, double value)
        {
            Id = id; ParentId = parentID; Text = text; Value = value; 
        }
    }
}