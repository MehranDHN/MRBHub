using System;
using System.Collections.Generic;
using System.Text;

namespace MRBHub.Models.TEI.Generic
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Xml
    {
        public string version { get; set; }
        public string encoding { get; set; }
    }

    public class TitleStmt
    {
        public string title { get; set; }
    }

    public class Licence
    {
        public string target { get; set; }
        public string text { get; set; }
    }

    public class Availability
    {
        public List<Licence> licence { get; set; }
    }

    public class PublicationStmt
    {
        public string publisher { get; set; }
        public Availability availability { get; set; }
    }

    public class NotesStmt
    {
        public List<string> note { get; set; }
    }

    public class Idno
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class AltIdentifier
    {
        public string type { get; set; }
        public string idno { get; set; }
    }

    public class MsIdentifier
    {
        public string settlement { get; set; }
        public string institution { get; set; }
        public string repository { get; set; }
        public Idno idno { get; set; }
        public List<AltIdentifier> altIdentifier { get; set; }
    }

    public class TextLang
    {
        public string mainLang { get; set; }
        public string text { get; set; }
    }

    public class PersName
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Author
    {
        public List<PersName> persName { get; set; }
    }

    public class PersName2
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class RespStmt
    {
        public string resp { get; set; }
        public List<PersName2> persName { get; set; }
    }

    public class MsItem
    {
        public object title { get; set; }
        public Author author { get; set; }
        public RespStmt respStmt { get; set; }
        public string n { get; set; }
        public string locus { get; set; }
    }

    public class MsContents
    {
        public string summary { get; set; }
        public TextLang textLang { get; set; }
        public List<MsItem> msItem { get; set; }
    }

    public class Support
    {
        public string p { get; set; }
    }

    public class SupportDesc
    {
        public string material { get; set; }
        public Support support { get; set; }
        public string extent { get; set; }
        public string foliation { get; set; }
    }

    public class LayoutDesc
    {
        public string layout { get; set; }
    }

    public class ObjectDesc
    {
        public SupportDesc supportDesc { get; set; }
        public LayoutDesc layoutDesc { get; set; }
    }

    public class ScriptDesc
    {
        public string scriptNote { get; set; }
    }

    public class DecoDesc
    {
        public List<object> decoNote { get; set; }
    }

    public class Binding
    {
        public string p { get; set; }
    }

    public class BindingDesc
    {
        public Binding binding { get; set; }
    }

    public class PhysDesc
    {
        public ObjectDesc objectDesc { get; set; }
        public ScriptDesc scriptDesc { get; set; }
        public DecoDesc decoDesc { get; set; }
        public BindingDesc bindingDesc { get; set; }
    }

    public class Origin
    {
        public string p { get; set; }
        public string origDate { get; set; }
    }

    public class History
    {
        public Origin origin { get; set; }
    }

    public class MsDesc
    {
        public MsIdentifier msIdentifier { get; set; }
        public MsContents msContents { get; set; }
        public PhysDesc physDesc { get; set; }
        public History history { get; set; }
    }

    public class SourceDesc
    {
        public MsDesc msDesc { get; set; }
    }

    public class FileDesc
    {
        public TitleStmt titleStmt { get; set; }
        public PublicationStmt publicationStmt { get; set; }
        public NotesStmt notesStmt { get; set; }
        public SourceDesc sourceDesc { get; set; }
    }

    public class Keyword
    {
        public string n { get; set; }
        public List<string> term { get; set; }
    }

    public class TextClass
    {
        public List<Keyword> keywords { get; set; }
    }

    public class ProfileDesc
    {
        public TextClass textClass { get; set; }
    }

    public class TeiHeader
    {
        public FileDesc fileDesc { get; set; }
        public ProfileDesc profileDesc { get; set; }
    }

    public class Graphic
    {
        public string height { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Surface
    {
        public string n { get; set; }
        public List<Graphic> graphic { get; set; }
    }

    public class Facsimile
    {
        public List<Surface> surface { get; set; }
    }

    public class TEI
    {
        public string xmlns { get; set; }
        public TeiHeader teiHeader { get; set; }
        public Facsimile facsimile { get; set; }
    }

    public class GenericTEIModel
    {
        public Xml xml { get; set; }
        public TEI TEI { get; set; }
    }

}
