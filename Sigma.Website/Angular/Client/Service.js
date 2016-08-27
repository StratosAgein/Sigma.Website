Sigma.service("ClientService", function ($http) {
    //GetAll
    this.GetAllClients = function () {
        return $http.get("Client/GetAllClients");
    };
});