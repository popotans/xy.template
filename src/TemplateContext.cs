/*****************************************************
 * 本类库的核心系 JNTemplate
 * 作者：翅膀的初衷 QQ:4585839
 * Mail: i@Jiniannet.com
 * 网址：http://www.JiNianNet.com
 *****************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using XY.Template.Parser;

namespace XY.Template
{
    public class TemplateContext : ContextBase
    {
        public TemplateContext()
        {
            this.Charset = System.Text.Encoding.Default;
            this.Analyzer = new Analyzers();
            this.Analyzer.Add(new XY.Template.Parser.TemplateParser.ForEachAnalyzer());
            this.Analyzer.Add(new XY.Template.Parser.TemplateParser.IfAnalyzer());
            this.Analyzer.Add(new XY.Template.Parser.TemplateParser.LoadAnalyzer(this));
            this.Analyzer.Add(new XY.Template.Parser.TemplateParser.IncludeAnalyzer(this));
            this.Analyzer.Add(new XY.Template.Parser.TemplateParser.SetAnalyzer());
            this.Analyzer.Add(new XY.Template.Parser.TemplateParser.FunctionAnalyzer());
            this.Analyzer.Add(new XY.Template.Parser.TemplateParser.VariableAnalyzer());
            this.Analyzer.Add(new XY.Template.Parser.TemplateParser.ExpressionAnalyzer());
        }

        private String _currentPath;
        public String CurrentPath
        {
            get { return _currentPath; }
            set { _currentPath =value; }
        }
        private Encoding _charset;
        public Encoding Charset
        {
            get { return _charset; }
            set { _charset =value; }
        }

        private Analyzers _analyzer;
        public Analyzers Analyzer
        {
            get { return _analyzer; }
            set { _analyzer = value; }
        }
    }
}
