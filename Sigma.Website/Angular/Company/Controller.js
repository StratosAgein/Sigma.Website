Sigma.controller("CompanyController", function ($scope, $window, CompanyService) {

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

    $scope.InitializeCreateView = function () {

    }

    $scope.InitializeDeleteView = function () {
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
        var editCompanyProcess = CompanyService.EditCompany(
                                    $scope.Company._id,
                                    $scope.Company.LongName,
                                    $scope.Company.ShortName,
                                    $scope.Company.CompanyStatus,
                                    $scope.Company.OwnerClient);

        editCompanyProcess.then(function (response) {
            if (response.data == true) {
                // edit succesfully
                $window.location.reload();
            }
            else {
                // can't edit 
            }
        },
            function (response) {
                console.log(response);
            });
    }

    $scope.CreateCompany = function () {
        var createCompanyProcess = CompanyService.CreateCompany(
                                    $scope.Company.LongName,
                                    $scope.Company.ShortName,
                                    $scope.Company.OwnerClient);

        createCompanyProcess.then(function (response) {
            if (response.data == true) {
                // edit succesfully
                $window.location.reload();
            }
            else {
                // can't edit 
            }
        })
    }

    $scope.DeleteCompany = function () {
        var deleteCompanyProcess = CompanyService.DeleteCompany($scope.Company._id);

        deleteCompanyProcess.then(function (response) {
            if (response.data == true) {
                // edit succesfully
                $window.location.reload();
            }
            else {
                // can't edit 
            }
        })
    }
});