﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Angular.Renders;
using Util.Ui.Configs;
using Util.Ui.Renders;
using Util.Ui.TagHelpers;

namespace Util.Ui.Angular.TagHelpers {
    /// <summary>
    /// ng-container容器，用于测试，可输出标签包含的html内容
    /// </summary>
    [HtmlTargetElement( "util-container" )]
    public class ContainerTagHelper : TagHelperBase {
        /// <summary>
        /// 标识
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new ContainerRender( new Config( context ) );
        }
    }
}