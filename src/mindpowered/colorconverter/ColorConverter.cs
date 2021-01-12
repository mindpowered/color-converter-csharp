/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * An Library for Color Conversion
 */
namespace mindpowered.colorconverter {
	public delegate void MyCallbackDelegate(object o);

	public class ColorConverter
	{
		public ColorConverter()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::colorconverter.ColorConverter myinstance = new global::colorconverter.ColorConverter(bus);
		}

		/**
		 * Convert from RGB
		 * @param r 
		 * @param g 
		 * @param b 
		 * @return {object[]} 
		*/
		public object[] FromRGB(double r, double g, double b)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(r);
			args.push(g);
			args.push(b);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.FromRGB", args, async_callback);
			return ret;
		}

		/**
		 * Convert from CIELAB
		 * @param L 
		 * @param a 
		 * @param b 
		 * @return {object[]} 
		*/
		public object[] FromCIELAB(double L, double a, double b)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(L);
			args.push(a);
			args.push(b);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.FromCIELAB", args, async_callback);
			return ret;
		}

		/**
		 * Convert from CMYK
		 * @param c 
		 * @param m 
		 * @param y 
		 * @param k 
		 * @return {object[]} 
		*/
		public object[] FromCMYK(double c, double m, double y, double k)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(c);
			args.push(m);
			args.push(y);
			args.push(k);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.FromCMYK", args, async_callback);
			return ret;
		}

		/**
		 * Convert from RGB using illumination and observer angles
		 * @param r 
		 * @param g 
		 * @param b 
		 * @param observer1 
		 * @param observer2 
		 * @return {object[]} 
		*/
		public object[] ConvertRGB(double r, double g, double b, string observer1, string observer2)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(r);
			args.push(g);
			args.push(b);
			args.push(observer1);
			args.push(observer2);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.ConvertRGB", args, async_callback);
			return ret;
		}

		/**
		 * Convert from CIELAB using illumination and observer angles
		 * @param L 
		 * @param a 
		 * @param b 
		 * @param observer1 
		 * @param observer2 
		 * @return {object[]} 
		*/
		public object[] ConvertCIELAB(double L, double a, double b, string observer1, string observer2)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(L);
			args.push(a);
			args.push(b);
			args.push(observer1);
			args.push(observer2);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.ConvertCIELAB", args, async_callback);
			return ret;
		}

		/**
		 * Convert from CMYK using illumination and observer angles
		 * @param c 
		 * @param m 
		 * @param y 
		 * @param k 
		 * @param observer1 
		 * @param observer2 
		 * @return {object[]} 
		*/
		public object[] ConvertCMYK(double c, double m, double y, double k, string observer1, string observer2)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(c);
			args.push(m);
			args.push(y);
			args.push(k);
			args.push(observer1);
			args.push(observer2);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.ConvertCMYK", args, async_callback);
			return ret;
		}

		/**
		 * Add a reference color
		 * @param system 
		 * @param name 
		 * @param description 
		 * @param r 
		 * @param g 
		 * @param b 
		*/
		public void AddReferenceColorByRGB(string system, string name, string description, double r, double g, double b)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(system);
			args.push(name);
			args.push(description);
			args.push(r);
			args.push(g);
			args.push(b);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.AddReferenceColorByRGB", args, async_callback);
		}

		/**
		 * Add a reference color
		 * @param system 
		 * @param name 
		 * @param description 
		 * @param L 
		 * @param a 
		 * @param b 
		*/
		public void AddReferenceColorByCIELAB(string system, string name, string description, double L, double a, double b)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(system);
			args.push(name);
			args.push(description);
			args.push(L);
			args.push(a);
			args.push(b);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.AddReferenceColorByCIELAB", args, async_callback);
		}

		/**
		 * Add a reference color
		 * @param system 
		 * @param name 
		 * @param description 
		 * @param c 
		 * @param m 
		 * @param y 
		 * @param k 
		*/
		public void AddReferenceColorByCMYK(string system, string name, string description, double c, double m, double y, double k)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(system);
			args.push(name);
			args.push(description);
			args.push(c);
			args.push(m);
			args.push(y);
			args.push(k);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.AddReferenceColorByCMYK", args, async_callback);
		}

		/**
		 * 
		 * @param r 
		 * @param g 
		 * @param b 
		 * @return {object[]} 
		*/
		public object[] FindReferenceColorByRGB(double r, double g, double b)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(r);
			args.push(g);
			args.push(b);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.FindReferenceColorByRGB", args, async_callback);
			return ret;
		}

		/**
		 * 
		 * @param L 
		 * @param a 
		 * @param b 
		 * @return {object[]} 
		*/
		public object[] FindReferenceColorByCIELAB(double L, double a, double b)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(L);
			args.push(a);
			args.push(b);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.FindReferenceColorByCIELAB", args, async_callback);
			return ret;
		}

		/**
		 * 
		 * @param c 
		 * @param m 
		 * @param y 
		 * @param k 
		 * @return {object[]} 
		*/
		public object[] FindReferenceColorByCMYK(double c, double m, double y, double k)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(c);
			args.push(m);
			args.push(y);
			args.push(k);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.FindReferenceColorByCMYK", args, async_callback);
			return ret;
		}

		/**
		 * 
		 * @param system 
		 * @param name 
		 * @return {object[]} 
		*/
		public object[] FindReferenceColor(string system, string name)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(system);
			args.push(name);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.FindReferenceColor", args, async_callback);
			return ret;
		}

		/**
		 * Remove reference color system and all reference colors
		 * @param system 
		*/
		public void RemoveReferenceColorSystem(string system)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(system);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.RemoveReferenceColorSystem", args, async_callback);
		}

		/**
		 * Get all reference color systems
		 * @return {object[]} 
		*/
		public object[] GetReferenceColorSystems()
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.GetReferenceColorSystems", args, async_callback);
			return ret;
		}

		/**
		 * Get all reference colors in a color reference system
		 * @param system 
		 * @return {object[]} 
		*/
		public object[] GetReferenceColors(string system)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(system);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.GetReferenceColors", args, async_callback);
			return ret;
		}

		/**
		 * Get supported illumination and observer angles
		 * @return {object[]} 
		*/
		public object[] GetIlluminationObserverAngles()
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.GetIlluminationObserverAngles", args, async_callback);
			return ret;
		}

		/**
		 * Save reference colors
		 * @param id 
		*/
		public void SaveReferenceColors(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.SaveReferenceColors", args, async_callback);
		}

		/**
		 * Load reference colors
		 * @param id 
		*/
		public void LoadReferenceColors(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ColorConverter.LoadReferenceColors", args, async_callback);
		}

	}
}

