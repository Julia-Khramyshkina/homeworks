type Operation = char

type Expression =
| Variable of char
| Const of int
| Expr of Operation * Expression * Expression

let rec derivative expression =
    match expression with
    | Variable x -> Const 1
    | Const x -> Const 0
    | Expr (operation, l, r) -> 
       match operation with
       | '+' -> Expr(operation, derivative l, derivative r)
       | '-' -> Expr(operation, derivative l, derivative r)
       | '*' -> Expr('+', Expr('*', derivative l, r), Expr('*', l, derivative r))
       | '/' -> Expr ('/', Expr('-', Expr ('*', derivative l, r), Expr ('*', l,  derivative r)), Expr ('*', r, r))
       | _ -> Const 0

let calculate operation l r  = 
    match operation with
    | '+' -> l + r
    | '-' -> l - r
    | '*' -> l * r
    | '/' -> l / r
    | _ -> 0

let rec simple expression = 
    match expression with
    | Const _ -> expression
    | Variable _ -> expression
    | Expr (oper, l, r) ->
        let leftPart = simple l
        let righPart = simple r
        
        match leftPart with
        | Const l ->
            match righPart with
            | Const r -> Const (calculate oper l r)
            | _ -> 
                if (l = 0 && (oper = '*' || oper = '/')) then
                    Const 0
                elif (l = 0 && (oper = '+' || oper = '-') || (l = 1 && oper = '*')) then
                    righPart   
                else
                    Expr(oper, leftPart, righPart)
        | _ ->
            match righPart with
            | Const r ->
                if (r = 0 && oper = '*') then
                    Const 0
                elif (r = 0 && (oper = '+' || oper = '-') || (r = 1 && (oper = '*' || oper = '/'))) then
                    leftPart
                else
                    Expr(oper, leftPart, righPart)
            | _ ->  Expr(oper, leftPart, righPart)

let expr = Expr('+' , Expr('-', Const 1,  Variable 'x'),  Expr('*', Const 2, Variable 'x'))


printfn "%A" (simple (derivative expr))