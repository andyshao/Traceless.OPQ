# Traceless.OPQ
OPQ C# SDK 【netcore 3.1】

这里是Netcore 3.1 OPQ C# SDK

[WIKI点击进入](https://github.com/OPQBOT/OPQ/wiki)

## TODO

1. 多插件支持-反射实现调用
2. 多插件支持-插件优先级
3. 多插件支持-消息拦截
4. ...



##### Api支持【持续更新中】

| API                  | 可用 | 测试过 | 备注                                                         |
| --------------------- | ---- | ------ | ------------------------------------------------------------ |
| 发群消息【图片、语音、文字】                | ✔    | ✔      | 可能不会支持xml等，可自行根据webapi拓展 |
| 发好友消息【图片、语音、文字】                | ✔    | ✔      | 可能不会支持xml等，可自行根据webapi拓展 |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |

##### 事件支持【理论上全都可用，欢迎提交Issue帮我完成测试】

| 事件                  | 可用 | 测试过 | 备注                                                         |
| --------------------- | ---- | ------ | ------------------------------------------------------------ |
| 群消息                | ✔    | ✔      |                                                              |
| 私聊消息              | ✔    | ✔      |                                                              |
| QQ登陆成功事件        | ✔    | ✖      |                                                              |
| 网络变化事件          | ✔    | ✖      | 网络波动引起当前链接 释放 随机8-15s会自动重连登陆 被t下线的QQ 不会在重连 |
| QQ离线事件            | ✔    | ✖      | 可能的原因(TX 踢号/异地登陆/冻结/被举报等 导致等Session失效) |
| 加好友申请被同意/拒绝 | ✔    | ✔      |                                                              |
| 主动删除了好友        | ✔    | ✔      |                                                              |
| 加好友成功后的通知    | ✔    | ✔      |                                                              |
| 收到好友请求          | ✔    | ✔      |                                                              |
| 退群成功              | ✔    | ✖      |                                                              |
| 好友消息撤回          | ✔    | ✖      |                                                              |
| 群禁言                | ✔    | ✖      |                                                              |
| 群撤回                | ✔    | ✖      |                                                              |
| 群头衔变更            | ✔    | ✖      |                                                              |
| 加群请求              | ✔    | ✖      |                                                              |
| 群管理变更            | ✔    | ✖      | 机器人是不是管理员都能收到此群管变更事件                     |
| 有人退群              | ✔    | ✖      | 无论机器人是不是管理员 群里任意成员 都能收到 此退群事件      |
| 加群成功              | ✔    | ✖      |                                                              |
| 收到群邀请            | ✔    | ✖      |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |
|                       |      |        |                                                              |


参考项目：

[C# 插件 By:枫林](https://github.com/fenglindubu/IOTQQ_Socket)

[仓鼠的QQ Bot框架-Java版本](https://github.com/MiniDay/HamsterBot-IOTQQ)