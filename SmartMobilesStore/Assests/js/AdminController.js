app.controller("AdminController", function ($scope, $http) {

  
    $scope.prod = {};
    $scope.getList = [];//TO STORE THE RESULT FROM DATABASE
    $scope.FirstImage = '';
    $scope.SecondImage = '';
    $scope.ThirdImage = '';
    $scope.EditedData = [];//to store the edited text in an obj


    $scope.sendDetails = function (prod) {

        if (prod.ProductId != null) { alert("not possible"); }

        else {
            $http.post("/Admin/Submit", prod).then
                (function (success) {

                 
                    $scope.prod = {};
                }, function (error) {
                    alert("There is some problems in adding the data");
                })
        }
    }
    //to show the Product table on frontend
    $scope.getData = function () {
        $http.post("/Admin/GetProducts").then(function (response) {
            $scope.getList = response.data
        }
            ,
            function (error) {
                alert("failure in getdata")
            }

        )
    }
   
    $scope.uploadFile = function (file, id) {
        var fd = new FormData();
        fd.append("file", file[0]);
        var uploadUrl = "/Admin/ImageUploader/";
        $http.post(uploadUrl, fd, {
            withCredentials: true,
            headers: { 'Content-Type': undefined },
            transformRequest: angular.identity
        }).then(
            function (resp) {
                if (id == 1) {
                    $scope.FirstImage = resp.data;

                }
                if (id == 2) {
                    $scope.SecondImage = resp.data;
                }
                if (id == 3) {
                    $scope.ThirdImage = resp.data;
                }

            },
            function (error) {
                alert("error");
            }
            );
    };



    //function to delete data from product list
    $scope.deleteProduct = function (id) {

        $http.post("/Admin/DeleteUser", { ProductId: id }).then
            (function (response) {

                $scope.getData();

            }, function (error) {
                alert("Dont Get Data from Database")
            }
            )

    }
     //To edit the product details in admin controller
   
    $scope.editProduct = function (id) {
        $http.post("/Admin/EditProduct", { ProductId: id }).then
            (function (response) {
                $scope.EditedData = response.data;
                $scope.prod.ProductId = $scope.EditedData[0].ProductId;
                $scope.prod.ProductName = $scope.EditedData[0].ProductName;
                $scope.prod.SellingPrice = $scope.EditedData[0].SellingPrice;
                $scope.prod.MarketPrice = $scope.EditedData[0].MarketPrice;
                $scope.prod.Stock = $scope.EditedData[0].Stock;
                $scope.prod.Description = $scope.EditedData[0].Description;
                $scope.prod.DateOfInsert = $scope.EditedData[0].DateOfInsert;
                $scope.prod.Rating = $scope.EditedData[0].Rating;
                $scope.prod.OperatingSystem = $scope.EditedData[0].OperatingSystem;
                $scope.prod.Color = $scope.EditedData[0].Color;
                $scope.prod.IsAvailable = $scope.EditedData[0].IsAvailable;
                $scope.prod.FirstImage = $scope.EditedData[0].FirstImage;
                $scope.prod.SecondImage = $scope.EditedData[0].SecondImage;
                $scope.prod.ThirdImage = $scope.EditedData[0].ThirdImage;


            }

            )
    }
   
   

});