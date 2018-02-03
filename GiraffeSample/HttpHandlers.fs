namespace GiraffeSample

module HttpHandlers =

    open Microsoft.AspNetCore.Http
    open Giraffe
    open Giraffe.HttpHandlers
    open GiraffeSample.Models
    
    let handleGetHello : HttpHandler =
        fun next ctx ->
            task {
                let response = { Text = ctx.User.Identity.Name }                       
                return! json response next ctx
            }