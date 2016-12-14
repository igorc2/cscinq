(function () {
    "use strict";

    var app = angular.module("booksSeller",
                            ["common.services", "ngResource"])
    //.config(['$resourceProvider', function ($resourceProvider) {
    //    $resourceProvider.defaults.actions = {
    //        create: {method: 'POST'},
    //        get:    {method: 'GET'},
    //        getAll: {method: 'GET', isArray:true},
    //        update: {method: 'PUT'},
    //        delete: {method: 'DELETE'}
    //    }
    //}])
    .config(['$httpProvider', function($httpProvider) {
            $httpProvider.defaults.useXDomain = true;
            delete $httpProvider.defaults.headers.common['X-Requested-With'];
            $httpProvider.defaults.headers.common["Content-Type"] = "application/json";
        }
    ]);

}());