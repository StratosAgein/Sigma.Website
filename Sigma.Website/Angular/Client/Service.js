Sigma.service("ClientService", function ($http) {
    //CreateClient
    this.CreateClient = function (email,
                                    address,
                                    clientStatus,
                                    paymentMethod,
                                    documentNumber,
                                    documentType,
                                    phoneNumber) {
        var response = $http({
            method: "post",
            url: "/Client/CreateClient",
            params: {
                Email: email,
                Address: address,
                ClientStatus: clientStatus,
                PaymentMethod: paymentMethod,
                DocumentNumber: documentNumber,
                DocumentType: documentType,
                PhoneNumber: phoneNumber
            }
        });
        return response;
    }

    //EditClient
    this.EditClient = function (_id,
                                email,
                                address,
                                clientStatus,
                                paymentMethod,
                                documentNumber,
                                documentType,
                                phoneNumber) {
        var response = $http({
            method: "post",
            url: "/Client/EditClient",
            params: {
                _id: _id,
                Email: email,
                Address: address,
                ClientStatus: clientStatus,
                PaymentMethod: paymentMethod,
                DocumentNumber: documentNumber,
                DocumentType: documentType,
                PhoneNumber: phoneNumber
            }
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