Sigma.service("CompanyService", function ($http) {
    //CreateCompany
    this.CreateCompany = function (Company) {
        var response = $http({
            method: "post",
            url: "/Company/CreateCompany",
            data: JSON.stringify(Company),
            dataType: "json"
        });
        return response;
    }

    //EditCompany
    this.EditCompany = function (longName, shortName, companyStatus) {
        var response = $http({
            method: "post",
            url: "/Company/EditCompany",
            params: {
                ShortName: shortName,
                LongName: longName,
                CompanyStatus: companyStatus
            }
        });
        return response;
    }

    //DeleteCompany
    this.DeleteCompany = function (CompanyId) {
        var response = $http({
            method: "post",
            url: "/Company/DeleteCompany",
            params: {
                CompanyId: CompanyId
            }
        });
        return response;
    }

    //GetAll
    this.GetAllCompanies = function () {
        return $http.get("/Company/GetAllCompanies");
    };

    //GetById
    this.GetCompanyById = function (CompanyId) {
        var response = $http({
            method: "get",
            url: "/Company/GetCompanyById",
            params: {
                CompanyId: CompanyId
            }
        });
        return response;
    }

});