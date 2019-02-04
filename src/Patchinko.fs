// ts2fable 0.6.1
module rec Patchinko
open System
open Fable.Core
open Fable.Import.JS

let [<Import("constant","module")>] constant: Constant.IExports = jsNative
let [<Import("D","module")>] d: D.IExports = jsNative
let [<Import("immutable","module")>] immutable: Immutable.IExports = jsNative
let [<Import("P","module")>] p: P.IExports = jsNative
let [<Import("PS","module")>] pS: PS.IExports = jsNative
let [<Import("S","module")>] s: S.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract D: unit -> unit
    abstract P: target: obj option * [<ParamArray>] args: ResizeArray<obj option> -> obj option
    abstract PS: target: obj option * input: obj option * [<ParamArray>] args: ResizeArray<obj option> -> obj option
    abstract S: closure: obj option -> obj option
    abstract constant: a: obj option * b: obj option * [<ParamArray>] args: ResizeArray<obj option> -> obj option
    abstract immutable: a: obj option * b: obj option * [<ParamArray>] args: ResizeArray<obj option> -> obj option

module D =

    type [<AllowNullLiteral>] IExports =
        abstract prototype: obj

module P =

    type [<AllowNullLiteral>] IExports =
        abstract prototype: obj

module PS =

    type [<AllowNullLiteral>] IExports =
        abstract prototype: obj

module S =

    type [<AllowNullLiteral>] IExports =
        abstract prototype: obj

module Constant =

    type [<AllowNullLiteral>] IExports =
        abstract prototype: obj

module Immutable =

    type [<AllowNullLiteral>] IExports =
        abstract prototype: obj