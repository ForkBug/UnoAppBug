global using System.Collections.Immutable;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Localization;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using UnoApp5.Models;
global using UnoApp5.DataContracts;
global using UnoApp5.DataContracts.Serialization;
global using UnoApp5.Services.Caching;
global using UnoApp5.Services.Endpoints;
#if MAUI_EMBEDDING
global using UnoApp5.MauiControls;
#endif
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
