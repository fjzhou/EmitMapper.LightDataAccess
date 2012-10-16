EmitMapper.LightDataAccess
==========================

LightDataAccess from EmitMapper project.

It depends on [EmitMapper](http://emitmapper.codeplex.com/). And this is the original version from Codeplex.

<pre>
using(var connection = DBTools.CreateConnection("TagDbConnectionString"))
{
    List&lt;Tag&gt; tags = connection.ExecuteReader(System.Data.CommandType.Text, "SELECT TagId, TagName FROM Tag WHERE TagId &lt; @tagId", new CmdParams() { { "@tagId", 4 } })
    .ToObjects&lt;Tag&gt;()
    .ToList();
}
</pre>