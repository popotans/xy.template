/*****************************************************
 * �����ĺ���ϵ JNTemplate
 * ���ߣ����ĳ��� QQ:4585839
 * Mail: i@Jiniannet.com
 * ��ַ��http://www.JiNianNet.com
 *****************************************************/
using System;
using System.IO;
namespace XY.Template
{
    public interface IHTemplate
    {
        TemplateContext Context { get;set; }
        String TemplateContent { get;set; }
        void Render(TextWriter writer);
        String Render();
    }
}
