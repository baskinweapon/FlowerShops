#region DataBase

var data = new JsonDataBase(); // concrete implementation
var dataBase = new DataBridge(data); // bridge
dataBase.Load();

#endregion

