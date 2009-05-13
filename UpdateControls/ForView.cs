﻿/**********************************************************************
 * 
 * Update Controls .NET
 * Copyright 2009 Mallard Software Designs
 * Licensed under LGPL
 * 
 * http://updatecontrols.net
 * http://updatecontrolslight.codeplex.com/
 * 
 **********************************************************************/

using UpdateControls.Wrapper;

namespace UpdateControls
{
    public static class ForView
    {
        /// <summary>
        /// Wrap an object to be used as the DataContext of a view.
        /// All of the properties of the object are available for
        /// data binding with automatic updates.
        /// </summary>
        /// <typeparam name="ObjectType">DO NOT SPECIFY!</typeparam>
        /// <param name="wrappedObject">The object to wrap for the view.</param>
        /// <returns>An object suitable for data binding.</returns>
        public static object Wrap<ObjectType>(ObjectType wrappedObject)
        {
            return
                wrappedObject == null
                    ? null
                    : new ObjectInstance<ObjectType>(wrappedObject);
        }
    }
}