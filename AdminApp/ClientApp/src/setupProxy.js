const { createProxyMiddleware } = require('http-proxy-middleware');
const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:19352';

const context = [
  "/api/Product/getproducts",
  "/api/Product/createproduct",
  "/api/Product/products/deleteproduct",
  "/api/Product/products/updateproduct",
  "/api/Client/getclients",
  "/api/Client/createclient",
  "/api/Client/products/deleteclient",
  "/api/Client/products/updateclient",
  "/swagger",
  "/weatherforecast",
];

module.exports = function(app) {
  const appProxy = createProxyMiddleware(context, {
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  });

  app.use(appProxy);
};
