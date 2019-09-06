# Auth / IdentityServer 4 Playground

## Setup

1. Install latest .NET Core preview (if you don't already have it)

```bash
$ dotnet tool install --global InstallSdkGlobalTool
```

2. Run the below from this directory to download/start install of the version of .NET the `global.json` file:
```bash
$ dotnet install-sdk
```

## Client Credentials

Steps:

1. Launch IdentityServer
2. Run this:

```http
POST http://localhost:5000/connect/token
Content-Type: application/x-www-form-urlencoded
Authorization: Basic client 511536EF-F270-4058-80CA-1C89C192F69A

scope=api1
&grant_type=client_credentials
```

3. Yay, you've got your access code

## Authorisation Code (Without PKCE)

Steps:

1. Launch IdentityServer
2. Navigate to `http://localhost:5002/login` and login with username `joe` and password `letmein`:

3. Copy [code from callback](https://github.je-labs.com/joseph-woodward/authplayground/blob/master/src/Demo.WebApp/Controllers/CallbackController.cs#L25) (you'll need to use debugger to get response, or copy it from callback parameters)

4. Copy/run HTTP request presented in view, or run the following request (with your code replaced):

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
5. Yay, you've got your access code


## Authorisation Code (With PKCE)

Coming soon
