module rec Patchinko

open System
open Fable.Core
open Fable.Import.JS

type IResult<'T1> =
    interface end

type P =
    [<Emit "$0($1...)">] abstract Invoke: pFn: ('T1 -> 'T2 -> 'R) * s1: 'T1 * s2: IResult<'T2> -> IResult<'R>
    [<Emit "$0($1...)">] abstract Invoke: pFn: ('T1 -> 'T2 -> 'T3 -> 'R) * s1: IResult<'T1> * s2: IResult<'T2> * s3: IResult<'T3> -> IResult<'R>
    [<Emit "$0($1...)">] abstract Invoke: pFn: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'R) * s1: IResult<'T1> * s2: IResult<'T2> * s3: IResult<'T3> * s4: IResult<'T4> -> IResult<'R>
    [<Emit "$0($1...)">] abstract Invoke: pFn: (ResizeArray<obj option> -> 'T) * [<ParamArray>] streams: ResizeArray<IResult<obj option>> -> IResult<'T>

type S = P
type PS = P
type D = P

let [<Import("*","module")>] ``patchinko/explicit/P``: P = jsNative
let [<Import("*","module")>] ``patchinko/explicit/S``: S = jsNative
let [<Import("*","module")>] ``patchinko/explicit/PS``:PS = jsNative
let [<Import("*","module")>] ``patchinko/explicit/D``: D = jsNative
