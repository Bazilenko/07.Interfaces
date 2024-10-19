using System;

interface ILeutenantGeneral : IPrivate
{
    public List<Private> Privates { get; set; }
}
