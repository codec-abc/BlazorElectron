module Todos

open Newtonsoft.Json
open System.Collections.Generic

type TodoItem = {
    Title : string;
    IsDone : bool;
}

let parseFile (path: string) : List<TodoItem> =
    let fileContent = System.IO.File.ReadAllText(path)
    Newtonsoft.Json.JsonConvert.DeserializeObject<List<TodoItem>>(fileContent)

let serialize (todos : List<TodoItem>) =
    Newtonsoft.Json.JsonConvert.SerializeObject(todos)
