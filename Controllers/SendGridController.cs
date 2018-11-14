
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PRPC.Models;

public async Task<ActionResult> Register(RegisterViewModel model)
{
    if (ModelState.IsValid)
    {
        var user = new Rider { UserName = model.Email, Email = model.Email };
        var result = await UserManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
            var code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
            var callbackUrl = Url.Action(
               "ConfirmEmail", "Account", 
               new { userId = user.Id, code = code }, 
               protocol: Request.Url.Scheme);

            await UserManager.SendEmailAsync(user.Id, 
               "Confirm your account", 
               "Please confirm your account by clicking this link: <a href=\"" 
                                               + callbackUrl + "\">link</a>");
            // ViewBag.Link = callbackUrl;   // Used only for initial demo.
            return View("DisplayEmail");
        }
        AddErrors(result);
    }
}