# Paylinks Samples

[github-action-image]: https://img.shields.io/github/actions/workflow/status/essensoft/paylinks/build.yml?branch=dev&style=flat-square
[github-action-url]: https://github.com/essensoft/paylinks/actions/workflows/build.yml?query=branch%3Adev
[license-image]: https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square

[![Build status][github-action-image]][github-action-url]
[![MIT][license-image]](LICENSE.md)

一套基于 现代 .NET 开发，支持跨平台、多商户的第三方支付SDK。
为简化开发者接入第三方支付平台而设计的SDK，
支持支付宝和微信支付，便于快速集成支付功能。

### 开发环境

* [Rider](https://www.jetbrains.com/rider) / [Visual Studio](https://visualstudio.microsoft.com)
* [.NET 9.0](https://dotnet.microsoft.com/download/dotnet/9.0)

### 运行环境

- [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [.NET 9.0](https://dotnet.microsoft.com/download/dotnet/9.0)

### 示例配置选项

```json
  "Paylinks": {
    "Alipay": {
      // 网关地址
      "ServerUrl": "https://openapi.alipay.com",
      // 应用Id
      "AppId": "",
      // 应用私钥(PKCS#1)
      "AppPrivateKey": "",
      // 应用证书序列号
      "AppCertSN": "",
      // 支付宝公钥
      "AlipayPublicKey": "",
      // 支付宝证书序列号
      "AlipayCertSN": "",
      // 支付宝根证书序列号
      "AlipayRootCertSN": "",
      // 敏感信息对称加密算法类型，推荐：AES
      "EncryptType": "",
      // 敏感信息对称加密算法密钥
      "EncryptKey": ""
    },
    "WeChatPay": {
      // 网关地址
      "ServerUrl": "https://api.mch.weixin.qq.com",
      // 应用Id
      "AppId": "",
      // 商户号
      "MchId": "",
      // 商户证书序列号
      "MchSerialNo": "",
      // 商户证书私钥(PKCS#1)
      "MchPrivateKey": "",
      // 微信支付公钥
      "WeChatPayPublicKey": "",
      // 微信支付公钥Id
      "WeChatPayPublicKeyId": "",
      // 商户APIv3密钥
      "APIv3Key": ""
    }
  }
```

### 赞助

- [赞助名单](https://paylinks.cn/sponsors)

### 社区互助

如果您在使用的过程中碰到问题，可以通过下面几个途径寻求帮助，同时我们也鼓励资深用户通过下面的途径给新人提供帮助。

- QQ交流群: 522457525 [加入链接](https://qm.qq.com/q/lOhqmDT0hG)
- 钉钉交流群: 34090889 [加入链接](https://qr.dingtalk.com/action/joingroup?code=v1,k1,1tAeOJxsgOjngwZZD/uEhtWpOiU3B9CQK8Xs1wHdau4=&_dt_no_comment=1&origin=11)
- 飞书交流群: [加入链接](https://applink.feishu.cn/client/message/link/open?token=AmaiieikwYAcZrEQ9XnAAAE%3D)
