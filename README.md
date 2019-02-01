# OktaExample
Sample ASP.Net Core app featuring Okta authentication.

A small MVC example of how to add Okta Authentication to a ASP.Net Core application.

It also features basic authorization by access User.Identity.Name.

It is HIGHLY important, when configuring your app in the Okta dev portal, to
route your login redirects as: https://youroktadomain.com/authorization-code/callback.

Your logout redirect must be: https://youroktadomain.com/signout/callback.
