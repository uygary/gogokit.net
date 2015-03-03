﻿using System.Linq.Expressions;
using GogoKit.Configuration;
using GogoKit.Tests.Fakes;
using NUnit.Framework;

namespace GogoKit.Tests.Localization
{
    [TestFixture]
    public class ConfigurationLocalizationProviderTests
    {
        [Test]
        public void LanguageCode_WhenExistsInConfiguration_ShouldRetrieveIt()
        {
            var configuration = new FakeConfiguration {LanguageCode = "en-GB"};
            var configurationLocalizationProvider = new ConfigurationLocalizationProvider(configuration);

            var actualLanguageCode = configurationLocalizationProvider.LanguageCode;

            Assert.AreEqual(configuration.LanguageCode, actualLanguageCode);
        }

        [Test]
        public void CountryCode_WhenExistsInConfiguration_ShouldRetrieveIt()
        {
            var configuration = new FakeConfiguration {CountryCode = "UK"};
            var configurationLocalizationProvider = new ConfigurationLocalizationProvider(configuration);

            var actualCountryCode = configurationLocalizationProvider.CountryCode;

            Assert.AreEqual(configuration.CountryCode, actualCountryCode);
        }

        [Test]
        public void CurrencyCode_WhenExistsInConfiguration_ShouldRetrieveIt()
        {
            var configuration = new FakeConfiguration {CurrencyCode = "GBP"};
            var configurationLocalizationProvider = new ConfigurationLocalizationProvider(configuration);

            var actualCurrencyCode = configurationLocalizationProvider.CurrencyCode;

            Assert.AreEqual(configuration.CurrencyCode, actualCurrencyCode);
        }
    }
}