(function () {
    "use strict";

    function booksService($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/Books/:id", { id: '@id' },
        {
            'update': { method: 'PUT', headers: { 'Content-Type': 'application/json' } },
            'create': { method: 'POST'},
            'getAll': { method: 'GET', isArray: true },
            'get' : {method: 'GET'},
        });
    }

    angular
        .module("booksSeller")
        .factory("booksService",
                  ["$resource", "appSettings",
                   booksService]);
})();