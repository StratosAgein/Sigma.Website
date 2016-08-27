Sigma.service("ClientService", function ($http) {
    //GetAll
    this.GetAllClients = function () {
        return $http.get("Client/GetAllClients");
    };
    //GetById
    this.GetClient = function (ClientId) {
        var response = $http({
            method: "post",
            url: "Client/GetClientById",
            params: {
                ClientId: JSON.stringify(ClientId)
            }
        });
        return response;
    }
});