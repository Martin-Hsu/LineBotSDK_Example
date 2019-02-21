# C# LineBotSDK
You can see the gitbook, and I will introduce all of functions for LineBotSDK.  
[Gitbook url ](https://martinhsu.gitbook.io/linebotsdk/)  
[LineBotSDK nuget url ](https://www.nuget.org/packages/LineBot.SDK)  
[Example url ](https://github.com/Martin-Hsu/LineBotSDK_Example)  

## Now support functions : 
### MessageUtility:
```
PushTextMessage

PushImageMessage

PushVideoMessage

PushStickerMessage

PushAudioMessage

PushLocationMessage

PushImagemapMessage
```
### LiffControl:
```
AddingLIFFApp

UpdateLIFFApp

GetAllLIFFApps

DeleteLIFFApp

DeleteAllLIFFApps
```

## 使用LineNotify  
有以下函數可以使用:

```
GetToeknFromCode -> 使用code來取得token  
  
SendNotification (message image sticker) -> 發送notify給使用者  
  
GetStatus -> 取得token狀態  
  
RevokeToken -> 註銷token來取消連動  
  
GenerateHTMLString -> 產生可使用的html程式碼  
```

[Deatail infomation please reference the gitbook.](https://martinhsu.gitbook.io/linebotsdk/)

