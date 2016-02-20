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
// Generated by IDLImporter from file nsIContentSniffer.idl
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
    /// Content sniffer interface. Components implementing this interface can
    /// determine a MIME type from a chunk of bytes.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a5772d1b-fc63-495e-a169-96e8d3311af0")]
	public interface nsIContentSniffer
	{
		
		/// <summary>
        /// Given a chunk of data, determines a MIME type. Information from the given
        /// request may be used in order to make a better decision.
        ///
        /// @param aRequest The request where this data came from. May be null.
        /// @param aData Data to check
        /// @param aLength Length of the data
        ///
        /// @return The content type
        ///
        /// @throw NS_ERROR_NOT_AVAILABLE if no MIME type could be determined.
        ///
        /// @note Implementations should consider the request read-only. Especially,
        /// they should not attempt to set the content type property that subclasses of
        /// nsIRequest might offer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMIMETypeFromContent([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] byte[] aData, uint aLength, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
	}
}