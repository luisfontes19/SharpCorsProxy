# SharpCorsProxy

## Usage

```
SharpCorsProxy 1.0.0.0
Copyright c  2020

  -a, --address            (Default: 127.0.0.1) Address to bind the proxy to

  -p, --port               (Default: 19191) Port on which to run the proxy

  -t, --timeout            (Default: 30) Number os seconds to wait for a response

  -k, --keep-user-agent    (Default: false) Keep User Agent

  --help                   Display this help screen.

  --version                Display version information.

```


On the javascript side you should call the proxy with a queyrparameter called URL, with the URL you want to access

Ex:

```http://localhost:19191?url=https://google.com```
