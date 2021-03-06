﻿app.controller("ProductController", function ($scope, $http) {

    $scope.getProdList = [];
    $scope.getProductList = [];
    $scope.getBulkProductList = [];
    $scope.isFilter = false;
    $scope.selectedFilter = {};
    $scope.productDescription = [];
    $scope.GrandTotal = 0;
    

    $scope.getLatestProducts = function () {
        $http.post("/Product/GetNewProductsList").then(function (response) {
            $scope.getProdList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        );
    };

    $scope.addToCart = function (basket) {


        $http.post("/Basket/AddToCart", basket).then(function (response) {

            $scope.getUserBasket(basket.ProductId);
        
        });
    };
    $scope.getUserBasket = function () {
      
        $http.post("/Basket/GetUserBasket").then(function (response) {
            $scope.basketItems = response.data;
           
            angular.forEach($scope.basketItems, function (value) {
                $scope.GrandTotal = $scope.GrandTotal + value.LineTotal;


            });

            $('#myCart').modal('show'); 
        });
    };
    //delteItemFromUserBasket
    $scope.delteItemFromUserBasket = function (item) {

        $http.post("/Basket/DeleteUserBasket",item).then(function (response) {
            
            $scope.getUserBasket();
            });

    };
    //list of products on homepage
    $scope.getFeaturedProducts = function () {
        $http.post("/Product/GetListOfProducts").then(function (response) {
            $scope.getProductList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }
    //list of products on ProductList Page
    $scope.getProductsList = function () {
        $http.post("/Product/GetProductsList").then(function (response) {
            $scope.getBulkProductList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }
    //To get the color Filter results
    $scope.getProductsByColor = function (color) {
       
        if ($scope.selectedFilter != null) {
            $scope.selectedFilter.push({ FilterName: color, SelectedFilter:color });
            var data = $scope.selectedFilter;

        }
        else {
            var data = { SelectedFilter: color };
        }
        //$scope.selectedFilter = selectedFilter.push({ filterColor: color });
        $http.post("/Product/GetProductsByColor", data).then(function (response) {
            $scope.getBulkProductList = response.data;
            $scope.isFilter = true;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    
    }
    $scope.getSelectedFilter = function () {
       
        $http.post("/Product/GetSelectedFilter").then(function (response) {
            $scope.selectedFilter = response.data;
            if ($scope.selectedFilter.length > 0) {
                $scope.initGetProductsList($scope.selectedFilter);
            }
            else { $scope.getProductsList(); }

        },
            function (error) {
                alert("failure in get filters");
            }
        )
    }
    $scope.initGetProductsList = function (selectedFilter) {
        var data = $scope.selectedFilter;

        $http.post("/Product/GetProductsByColor",data).then(function (response) {
            $scope.getBulkProductList = response.data;
         

        },
            function (error) {
                alert("failure in get filters");
            }
        )
    }
    //$scope.addToCart = function (list) {

    //    var data = list;
    //    $http.post("/Product/AddToBasket", data).then(function (response) {
    //        var resp = response.data;
    //    },
    //        function (error) {
    //            alert("Fails in adding data in basket");
    //        }

    //    )
    //}
    //getProductDescription(prod.ProductId)
    $scope.getProductDescription = function (productId) {

        var id = {id:productId}
        $http.post("/Product/DescriptionPage", id).then(function (response) {
            $scope.productDescription = response.data;
        },
            function (error) {
                alert("Fails in adding data in basket");
            }

        )
    }
    $scope.deleteSelectedFilter = function (filterId)
    {
        
        $http.post("/Product/DeleteSelectedFilter", { id: filterId }).then(function (response) {
            $scope.getSelectedFilter();
            if ($scope.selectedFilter.length > 0) {
                $scope.initGetProductsList($scope.selectedFilter);
            }
            

        },
            function (error) {
                alert("failure in deleting filters");
            }

        )

    }


    
    $scope.registerHideFunction = function () {
        $scope.registerHide = true;
    }
  


    

});