module Business 

open FSharp.Data
open Gir.Core

type GirData = XmlProvider<"../gir-files/GObject-2.0.gir">

let GetData (file:string) =
    let  bla = GirData.Load(file)
    bla.Namespace

let ConvertParameters (d:GirData.Parameter) =
    { Name = (Name d.Name); Type = (Type d.)}

let ConvertDelegate (d:GirData.Callback) = {
        Name = (Name d.Name); 
        Return = (Return d.ReturnValue); 
        Parameters = }

//let ConvertClass (c:GirData.Class) =
//    { Name = c.Name; Methods = }
