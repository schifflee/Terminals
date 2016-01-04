// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMCameraManager.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    ///The position information to record in the image header.
    ///   'NaN' indicates the information is not available. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0711a4af-73c2-481d-85bc-0ba3ec36c004")]
	public interface nsICameraCapabilities
	{
		
		/// <summary>
        ///an array of objects with 'height' and 'width' properties
        ///       supported for the preview stream </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetPreviewSizesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of objects with 'height' and 'width' properties
        ///       supported for picture taking </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetPictureSizesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of objects with 'height' and 'width' properties
        ///       supported for thumbnail sizes in taken pictures </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetThumbnailSizesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of strings, e.g. [ "jpeg", "rgb565" ] </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetFileFormatsAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of strings, e.g. [ "auto", "fluorescent", etc. ] </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetWhiteBalanceModesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of strings, e.g. [ "auto", "night", "beach", etc. ] </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetSceneModesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of strings, e.g. [ "normal", "sepia", "mono", etc. ] </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetEffectsAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of strings, e.g. [ "auto", "off", "on", etc. ] </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetFlashModesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of strings, e.g. [ "auto", "fixed", "macro", etc. ] </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetFocusModesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///the maximum number of focus areas supported by the camera </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMaxFocusAreasAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///the minimum supported exposure compensation value </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMinExposureCompensationAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///the maximum supported exposure compensation value </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMaxExposureCompensationAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///exposure compensation minimum step-size </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetStepExposureCompensationAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///the maximum number of metering areas supported by the camera </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMaxMeteringAreasAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of doubles, e.g. [ 1.0, 1.2, 1.5, 2.0, 3.0, etc. ],
        ///       or null if zooming is not supported </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetZoomRatiosAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an array of objects with 'height' and 'width' properties
        ///       supported for video recording </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetVideoSizesAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///an object with attributes for each of the supported recorder
        ///       profiles, e.g. recorderProfiles.cif, recorderProfiles.qvga,
        ///       etc. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetRecorderProfilesAttribute(System.IntPtr jsContext);
	}
	
	/// <summary>
    ///These properties affect the actual video recording, e.g.
    ///      {
    ///         rotation: 0,
    ///         maxFileSizeBytes: 1024 * 1024,
    ///         maxVideoLengthMs: 0
    ///      }
    ///   'rotation' is the degrees clockwise to rotate the recorded video; if
    ///   this options is not supported, it will be ignored; if this option is
    ///   missing, the default is 0.
    ///   'maxFileSizeBytes' is the maximum size in bytes to which the recorded
    ///   video file will be allowed to grow.
    ///   'maxVideoLengthMs' is the maximum length in milliseconds to which the
    ///   recorded video will be allowed to grow.
    ///   if either 'maxFileSizeBytes' or 'maxVideoLengthMs' is missing, zero,
    ///   or negative, that limit will be disabled. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0444a687-4bc9-462c-8246-5423f0fe46a4")]
	public interface nsICameraPreviewStreamCallback
	{
		
		/// <summary>
        ///These properties affect the actual video recording, e.g.
        ///      {
        ///         rotation: 0,
        ///         maxFileSizeBytes: 1024 * 1024,
        ///         maxVideoLengthMs: 0
        ///      }
        ///   'rotation' is the degrees clockwise to rotate the recorded video; if
        ///   this options is not supported, it will be ignored; if this option is
        ///   missing, the default is 0.
        ///   'maxFileSizeBytes' is the maximum size in bytes to which the recorded
        ///   video file will be allowed to grow.
        ///   'maxVideoLengthMs' is the maximum length in milliseconds to which the
        ///   recorded video will be allowed to grow.
        ///   if either 'maxFileSizeBytes' or 'maxVideoLengthMs' is missing, zero,
        ///   or negative, that limit will be disabled. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMMediaStream stream);
	}
	
	/// <summary>nsICameraAutoFocusCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6baa4ac7-9c25-4c48-9bb0-5193b38b9b0a")]
	public interface nsICameraAutoFocusCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		/// <param name='success'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.U1)] bool success);
	}
	
	/// <summary>nsICameraTakePictureCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("17af779e-cb6f-4ca5-890c-06468ff82e4f")]
	public interface nsICameraTakePictureCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		/// <param name='picture'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMBlob picture);
	}
	
	/// <summary>nsICameraStartRecordingCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("89a762f8-581b-410a-ad86-e2bd2113ad82")]
	public interface nsICameraStartRecordingCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent();
	}
	
	/// <summary>nsICameraShutterCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fb80db71-e315-42f0-9ea9-dd3dd312ed70")]
	public interface nsICameraShutterCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent();
	}
	
	/// <summary>nsICameraClosedCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0ef0f01e-ce74-4741-9bba-54376adfb7a2")]
	public interface nsICameraClosedCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent();
	}
	
	/// <summary>nsICameraRecorderStateChange </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("550d675a-257d-4713-8b3d-0da53eba68fc")]
	public interface nsICameraRecorderStateChange
	{
		
		/// <summary>Member HandleStateChange </summary>
		/// <param name='newState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleStateChange([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newState);
	}
	
	/// <summary>nsICameraPreviewStateChange </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d1634592-43fd-4117-a2b2-419aec841cc4")]
	public interface nsICameraPreviewStateChange
	{
		
		/// <summary>Member HandleStateChange </summary>
		/// <param name='newState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleStateChange([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newState);
	}
	
	/// <summary>nsICameraReleaseCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f84d607b-554c-413d-8810-cf848642765a")]
	public interface nsICameraReleaseCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent();
	}
	
	/// <summary>nsICameraErrorCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a302c6c9-3776-4d1d-a395-f4105d47c3d3")]
	public interface nsICameraErrorCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		/// <param name='error'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);
	}
	
	/// <summary>nsICameraGetCameraCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("16de7703-dc43-4766-99c5-ff30a9ab92d7")]
	public interface nsICameraGetCameraCallback
	{
		
		/// <summary>Member HandleEvent </summary>
		/// <param name='camera'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.Interface)] nsISupports camera);
	}
}