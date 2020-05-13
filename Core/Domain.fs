namespace Gir.Core

type Name = Name of string
type Type = Type of string
type EntryPoint = EntryPoint of string
type Value = EnumValue of string

type Field = {
    Name : Name
    Value : Value
}

type Enum = {
    Name : Name
    HasFlags : bool
    Values : Value list
}

type Import = {
    DllName : Name
    EntryPoint : EntryPoint 
}

type Obsolete = {
    Summary : string option 
}

type Parameter = {
    Name : Name
    Type : Type 
}

type Delegate = {
    Name : Name
    Return : Type
    Parameters : Parameter list
}

type Method = {
    Target : Delegate
    Import : Import
    Summary : string option
    IsObsolete : Obsolete option
}

type NamedMethods = {
    Name : Name
    Methods : Method list
}

type Container =
    | Classes of NamedMethods
    | Structs of NamedMethods
    | Delegates of Delegate list
    | Enum of Enum

type Namespace = {
    Name : Name
    Containers : Container list
}

