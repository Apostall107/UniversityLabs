using System.Collections;

namespace Lab7.Problem8 {
    // LeutenantGeneral Interface
    internal interface ILeutenantGeneral : IPrivate {
        List<Private> Privates { get; set; }
    }


}
