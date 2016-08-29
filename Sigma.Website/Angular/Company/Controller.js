Sigma.controller("CompanyController", function ($scope, CompanyService) {

    $scope.showAddUpdate = false;
    $scope.test = "Hola";

    $scope.companies = [];


    $scope.InitializeView = function () {

        var getAllProcess = CompanyService.GetAllCompanies();

        getAllProcess.then(function (response) {
            $scope.companies = response.data;
        },
        function (response) {
            console.log(response);
        })

    }
});