namespace NGSmart.WebBlazor.Ecare.DependencyInjections
{
    public static class ServiceRegistrators
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<Services.PostService>();
            services.AddScoped<Services.BusinessInteractionService>();
            services.AddScoped<Services.ChargeService>();
            services.AddScoped<Services.CommunicationListService>();
            services.AddScoped<Services.PreFactorInfoService>();
            services.AddScoped<Services.CreditService>();
            services.AddScoped<Services.RemainCreditChargeService>();
            services.AddScoped<Services.BusinessDomainPropertyService>();
            services.AddScoped<Services.AccountLogTopUsageService>();
            services.AddScoped<Services.ServiceExpireDateService>();
            services.AddScoped<Services.UserInformationService>();
            services.AddScoped<Services.IpStaticService>();
            services.AddScoped<Services.UserOnlineInfoService>();
            services.AddScoped<Services.FreeNightService>();
            services.AddScoped<Services.GetAccountFairPolicyService>();
            services.AddScoped<Services.GetCurrentServiceInfoService>();
            services.AddScoped<Services.ReservedCreditChargeService>();
            services.AddScoped<Services.TransactionService>();
            services.AddScoped<Services.RemainFlatChargeService>();

            return services;
        }
    }
}
