﻿using GitUI.Properties;

namespace GitUI.BranchTreePanel
{
    internal class BasePathNode : BaseBranchNode
    {
        public BasePathNode(Tree tree, string fullPath) : base(tree, fullPath, visible: true)
        {
        }

        protected override void ApplyStyle()
        {
            base.ApplyStyle();

            TreeViewNode.ImageKey = TreeViewNode.SelectedImageKey =
                FullPath == TranslatedStrings.Inactive ? nameof(Images.EyeClosed) : nameof(Images.BranchFolder);
        }
    }
}
