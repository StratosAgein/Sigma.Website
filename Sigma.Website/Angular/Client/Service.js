Sigma.service("ClientService", function ($http) {
    //CreateClient
    this.CreateClient = function (Client) {
        var response = $http({
            method: "post",
            url: "/Client/CreateClient",
            data: JSON.stringify(Client),
            dataType: "json"
        });
        return response;
    }

    //EditClient
    this.EditClient = function (Client) {
        var response = $http({
            method: "post",
            url: "/Client/EditClient",
            data: JSON.stringify(Client),
            dataType: "json"
        });
        return response;
    }

    //DeleteClient
    this.DeleteClient = function (ClientId) {
        var response = $http({
            method: "post",
            url: "/Client/DeleteClient",
            params: {
                ClientId: ClientId
            }
        });
        return response;
    }

    //GetAll
    this.GetAllClients = function () {
        return $http.get("/Client/GetAllClients");
    };

    //GetById
    this.GetClientById = function (ClientId) {
        var response = $http({
            method: "post",
            url: "/Client/GetClientById",
            params: {
                ClientId: ClientId
            }
        });
        return response;
    }

});