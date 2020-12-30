using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;



namespace MRBHub.Models.TEI.Walters
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Xml
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("encoding")]
        public string Encoding { get; set; }
    }

    public class Title
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("n")]
        public string N { get; set; }

        [JsonPropertyName("xmllang")]
        public string Xmllang { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("xmllang")]
        public string Xmllang { get; set; }
    }

    public class Author
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("name")]
        public List<Name> Name { get; set; }
    }

    public class Resp
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Name2
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class RespStmt
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("resp")]
        public Resp Resp { get; set; }

        [JsonPropertyName("name")]
        public Name2 Name { get; set; }
    }

    public class TitleStmt
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("title")]
        public List<Title> Title { get; set; }

        [JsonPropertyName("author")]
        public Author Author { get; set; }

        [JsonPropertyName("respStmt")]
        public List<RespStmt> RespStmt { get; set; }
    }

    public class Publisher
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class P
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Availability
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("p")]
        public P P { get; set; }
    }

    public class PublicationStmt
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("publisher")]
        public Publisher Publisher { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }
    }

    public class Note
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class NotesStmt
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("note")]
        public Note Note { get; set; }
    }

    public class Settlement
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Repository
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Idno
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class MsIdentifier
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("settlement")]
        public Settlement Settlement { get; set; }

        [JsonPropertyName("repository")]
        public Repository Repository { get; set; }

        [JsonPropertyName("idno")]
        public Idno Idno { get; set; }
    }

    public class TextLang
    {
        [JsonPropertyName("mainLang")]
        public string MainLang { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Locus
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Title2
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("xmllang")]
        public string Xmllang { get; set; }
    }

    public class Incipit
    {
        [JsonPropertyName("xmllang")]
        public string Xmllang { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Author2
    {
        [JsonPropertyName("sameAs")]
        public string SameAs { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }
    }

    public class MsItem
    {
        [JsonPropertyName("n")]
        public string N { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("locus")]
        public Locus Locus { get; set; }

        [JsonPropertyName("title")]
        public List<Title2> Title { get; set; }

        [JsonPropertyName("incipit")]
        public Incipit Incipit { get; set; }

        [JsonPropertyName("author")]
        public Author2 Author { get; set; }
    }

    public class MsContents
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("textLang")]
        public TextLang TextLang { get; set; }

        [JsonPropertyName("msItem")]
        public MsItem MsItem { get; set; }
    }

    public class P2
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Support
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("p")]
        public P2 P { get; set; }
    }

    public class Height
    {
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Width
    {
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Dimension
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("height")]
        public Height Height { get; set; }

        [JsonPropertyName("width")]
        public Width Width { get; set; }

        [JsonPropertyName("n")]
        public string N { get; set; }
    }

    public class Extent
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("dimensions")]
        public List<Dimension> Dimensions { get; set; }
    }

    public class Catchwords
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class P3
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("catchwords")]
        public Catchwords Catchwords { get; set; }
    }

    public class Collation
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("p")]
        public P3 P { get; set; }
    }

    public class SupportDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("material")]
        public string Material { get; set; }

        [JsonPropertyName("support")]
        public Support Support { get; set; }

        [JsonPropertyName("extent")]
        public Extent Extent { get; set; }

        [JsonPropertyName("collation")]
        public Collation Collation { get; set; }
    }

    public class Layout
    {
        [JsonPropertyName("n")]
        public string N { get; set; }

        [JsonPropertyName("columns")]
        public string Columns { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("ruledLines")]
        public string RuledLines { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class LayoutDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("layout")]
        public Layout Layout { get; set; }
    }

    public class ObjectDesc
    {
        [JsonPropertyName("form")]
        public string Form { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("supportDesc")]
        public SupportDesc SupportDesc { get; set; }

        [JsonPropertyName("layoutDesc")]
        public LayoutDesc LayoutDesc { get; set; }
    }

    public class HandNote
    {
        [JsonPropertyName("n")]
        public string N { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class HandDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("handNote")]
        public HandNote HandNote { get; set; }
    }

    public class Title3
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class DecoNote
    {
        [JsonPropertyName("n")]
        public string N { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("title")]
        public Title3 Title { get; set; }

        [JsonPropertyName("note")]
        public object Note { get; set; }
    }

    public class DecoDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("decoNote")]
        public List<DecoNote> DecoNote { get; set; }
    }

    public class P4
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Binding
    {
        [JsonPropertyName("contemporary")]
        public string Contemporary { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("p")]
        public P4 P { get; set; }
    }

    public class BindingDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("binding")]
        public Binding Binding { get; set; }
    }

    public class PhysDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("objectDesc")]
        public ObjectDesc ObjectDesc { get; set; }

        [JsonPropertyName("handDesc")]
        public HandDesc HandDesc { get; set; }

        [JsonPropertyName("decoDesc")]
        public DecoDesc DecoDesc { get; set; }

        [JsonPropertyName("bindingDesc")]
        public BindingDesc BindingDesc { get; set; }
    }

    public class OrigDate
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class OrigPlace
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Origin
    {
        [JsonPropertyName("when")]
        public string When { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("origDate")]
        public OrigDate OrigDate { get; set; }

        [JsonPropertyName("origPlace")]
        public OrigPlace OrigPlace { get; set; }
    }

    public class Acquisition
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class History
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("origin")]
        public Origin Origin { get; set; }

        [JsonPropertyName("acquisition")]
        public Acquisition Acquisition { get; set; }
    }

    public class MsDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("msIdentifier")]
        public MsIdentifier MsIdentifier { get; set; }

        [JsonPropertyName("msContents")]
        public MsContents MsContents { get; set; }

        [JsonPropertyName("physDesc")]
        public PhysDesc PhysDesc { get; set; }

        [JsonPropertyName("history")]
        public History History { get; set; }
    }

    public class SourceDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("msDesc")]
        public MsDesc MsDesc { get; set; }
    }

    public class FileDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("titleStmt")]
        public TitleStmt TitleStmt { get; set; }

        [JsonPropertyName("publicationStmt")]
        public PublicationStmt PublicationStmt { get; set; }

        [JsonPropertyName("notesStmt")]
        public NotesStmt NotesStmt { get; set; }

        [JsonPropertyName("sourceDesc")]
        public SourceDesc SourceDesc { get; set; }
    }

    public class CatDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("catDesc")]
        public CatDesc CatDesc { get; set; }
    }

    public class Taxonomy
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("category")]
        public List<Category> Category { get; set; }
    }

    public class ClassDecl
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("taxonomy")]
        public List<Taxonomy> Taxonomy { get; set; }
    }

    public class EncodingDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("classDecl")]
        public ClassDecl ClassDecl { get; set; }
    }

    public class Language
    {
        [JsonPropertyName("ident")]
        public string Ident { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class LangUsage
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }

    public class CatRef
    {
        [JsonPropertyName("target")]
        public string Target { get; set; }

        [JsonPropertyName("scheme")]
        public string Scheme { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }
    }

    public class Item
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class List
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("item")]
        public List<Item> Item { get; set; }
    }

    public class Keywords
    {
        [JsonPropertyName("scheme")]
        public string Scheme { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("list")]
        public List List { get; set; }
    }

    public class TextClass
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("catRef")]
        public CatRef CatRef { get; set; }

        [JsonPropertyName("keywords")]
        public Keywords Keywords { get; set; }
    }

    public class ProfileDesc
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("langUsage")]
        public LangUsage LangUsage { get; set; }

        [JsonPropertyName("textClass")]
        public TextClass TextClass { get; set; }
    }

    public class TeiHeader
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("fileDesc")]
        public FileDesc FileDesc { get; set; }

        [JsonPropertyName("encodingDesc")]
        public EncodingDesc EncodingDesc { get; set; }

        [JsonPropertyName("profileDesc")]
        public ProfileDesc ProfileDesc { get; set; }
    }

    public class Graphic
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }
    }

    public class Surface
    {
        [JsonPropertyName("n")]
        public string N { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("graphic")]
        public List<Graphic> Graphic { get; set; }
    }

    public class Facsimile
    {
        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("surface")]
        public List<Surface> Surface { get; set; }
    }

    public class TEI
    {
        [JsonPropertyName("xmlns:xi")]
        public string XmlnsXi { get; set; }

        [JsonPropertyName("xmlid")]
        public string Xmlid { get; set; }

        [JsonPropertyName("xmlns")]
        public string Xmlns { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("teiHeader")]
        public TeiHeader TeiHeader { get; set; }

        [JsonPropertyName("facsimile")]
        public Facsimile Facsimile { get; set; }
    }

    public class WaltersTEIModel
    {
        [JsonPropertyName("xml")]
        public Xml Xml { get; set; }

        [JsonPropertyName("oxygen")]
        public string Oxygen { get; set; }

        [JsonPropertyName("TEI")]
        public TEI TEI { get; set; }
    }



}
