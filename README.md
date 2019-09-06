# Playground

## Client Credentials

Launch IdentityServer

```http
POST http://localhost:5000/connect/token
Content-Type: application/x-www-form-urlencoded
Authorization: Basic client 511536EF-F270-4058-80CA-1C89C192F69A

scope=api1
&grant_type=client_credentials
```

## Authorisation Code (Without PKCE)

Copy [code from callback](https://github.je-labs.com/joseph-woodward/authplayground/blob/master/src/Demo.WebApp/Controllers/CallbackController.cs#L25) (you'll need to use debugger to get response, or copy it from callback parameters)

```http
@code = bbbb4252b14be519fb7b2dcc82fc922c6fae646810097fb33526ef26a4c40cea

POST http://localhost:5000/connect/token
accept: application/json
authorization: Basic mvc 49C1A7E1-0C79-4A89-A3D6-A37998FB86B0
content-type: application/x-www-form-urlencoded

grant_type=authorization_code
&redirect_uri=http%3A%2F%2Flocalhost%3A5002/callback
&code={{code}}
```

## Authorisation Code (With PKCE)

Coming soon
