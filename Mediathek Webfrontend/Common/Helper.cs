using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;

namespace BusinessLogic.Common
{
    /// <summary>
    /// Various static helper methods
    /// </summary>
    public static class WebHelper
    {
        #region Fields

        /// <summary>
        /// Business logic handler instance
        /// </summary>
        private static BusinessLogicHandler bl = new BusinessLogicHandler();

        #endregion

        /// <summary>
        /// Fill the TreeView with categories (of the current media type).
        /// (Only works with WEB treeviews)
        /// </summary>
        public static void FillCategories(System.Web.UI.WebControls.TreeView tv, int typeId)
        {
            Category mainCat = bl.GetCategoryById(typeId);

            // add root node to treeview
            System.Web.UI.WebControls.TreeNode tn =
                new System.Web.UI.WebControls.TreeNode(mainCat.Name, mainCat.CategoryId.ToString());
            tv.Nodes.Add(tn);

            // add childs
            AddChildCategories(tn, mainCat.CategoryId);
        }

        /// <summary>
        /// Add child nodes (categories) to a given treenode
        /// (Only works with web treenodes)
        /// </summary>
        /// <param name="tn">The tree node to which the children are added</param>
        /// <param name="parentCatId">The ID of the category of the parent node</param>
        public static void AddChildCategories(System.Web.UI.WebControls.TreeNode tn, int parentCatId)
        {
            List<Category> cats =
                bl.GetCategoriesByParentId(parentCatId);

            cats.Sort();

            foreach (Category cat in cats)
            {
                System.Web.UI.WebControls.TreeNode tnChild =
                    new System.Web.UI.WebControls.TreeNode(cat.Name, cat.CategoryId.ToString());
                tn.ChildNodes.Add(tnChild);

                // recursion to add the children of this child node
                AddChildCategories(tnChild, cat.CategoryId);
            }
        }

    }
}
