var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('LRM');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);