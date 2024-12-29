using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator
{
   private static Dictionary<Type, object> services = new Dictionary<Type, object>();

    public static void RegisterService<T>(T service)
    {
        var type = typeof(T);
        if (!services.ContainsKey(type))
        {
            services[type] = service;
        }
        else
        {
            Debug.Log("Error en el register service");
        }
    }

    public static T GetService<T>()
    {
        var type = typeof (T);
        if (services.ContainsKey(type))
        {
            return (T)services[type];
        }
        throw new Exception("No se encuentra el servicio");
    }
}
