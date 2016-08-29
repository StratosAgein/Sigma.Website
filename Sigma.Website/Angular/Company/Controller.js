Sigma.controller("CompanyController", function ($scope, CompanyService) {

    $scope.showAddUpdate = false;
    $scope.test = "Hola";

    $scope.companies = [];
    $scope.Company = {};

    $scope.InitializeIndexView = function () {

        var getAllProcess = CompanyService.GetAllCompanies();

        getAllProcess.then(function (response) {
            console.log(response.data)
            $scope.companies = response.data;
        },
        function (response) {
            console.log(response);
        })

    }

    $scope.InitializeEditView = function () {
        var CompanyId = $Sigma.QueryString().CompanyId;
        if (CompanyId != undefined && CompanyId != null) {
            var getCompanyProcess = CompanyService.GetCompanyById(CompanyId);

            getCompanyProcess.then(function (response) {
                $scope.Company = response.data;
                console.log(response.data);
            },
            function (response) {
                console.log(response);
            })
        }
    }

    $scope.EditCompany = function () {
        CompanyService.EditCompany($scope.Company.LongName, $scope.Company.ShortName, $scope.Company.CompanyStatus);
    }
});