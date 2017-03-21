(function () {
    "use strict";

    var app = angular.module("booksSeller",
                            ["common.services", "ngResource"])
    //.config(['$resourceProvider', function ($resourceProvider) {
    //    angular.extend($resourceProvider.defaults.actions, {
    //        update: { method: 'PUT' },
    //    });

    //}]);
    .config(['$httpProvider', function($httpProvider) {
            $httpProvider.defaults.useXDomain = true;
            delete $httpProvider.defaults.headers.common['X-Requested-With'];
            $httpProvider.defaults.headers.common["Content-Type"] = "application/json";
        }
    ]);

}());