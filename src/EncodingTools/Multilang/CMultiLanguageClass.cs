namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, TypeLibType((short)2), ClassInterface((short)0), Guid("275C23E2-3747-11D0-9FEA-00AA003F8646")]
    public class CMultiLanguageClass : IMultiLanguage, CMultiLanguage, IMLangCodePages, IMLangFontLink, IMLangLineBreakConsole, IMultiLanguage2, IMLangFontLink2, IMultiLanguage3
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void BreakLineA([In] uint locale, [In] uint uCodePage, [In] ref sbyte pszSrc, [In] int cchSrc, [In] int cMaxColumns, out int pcchLine, out int pcchSkip);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void BreakLineML([In, MarshalAs(UnmanagedType.Interface)] CMLangString pSrcMLStr, [In] int lSrcPos, [In] int lSrcLen, [In] int cMinColumns, [In] int cMaxColumns, out int plLineLen, out int plSkipLen);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void BreakLineW([In] uint locale, [In] ref ushort pszSrc, [In] int cchSrc, [In] int cMaxColumns, out int pcchLine, out int pcchSkip);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void CodePagesToCodePage([In] uint dwCodePages, [In] uint uDefaultCodePage, out uint puCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void CodePageToCodePages([In] uint uCodePage, out uint pdwCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void CodePageToScriptID([In] uint uiCodePage, out byte pSid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ConvertString([In, Out] ref uint pdwMode, [In] uint dwSrcEncoding, [In] uint dwDstEncoding, [In] ref byte pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref byte pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ConvertStringFromUnicode([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref ushort pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref sbyte pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ConvertStringFromUnicodeEx([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref ushort pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref sbyte pDstStr, [In, Out] ref uint pcDstSize, [In] uint dwFlag, [In] ref ushort lpFallBack);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ConvertStringInIStream([In, Out] ref uint pdwMode, [In] uint dwFlag, [In] ref ushort lpFallBack, [In] uint dwSrcEncoding, [In] uint dwDstEncoding, [In, MarshalAs(UnmanagedType.Interface)] IStream pstmIn, [In, MarshalAs(UnmanagedType.Interface)] IStream pstmOut);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ConvertStringReset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ConvertStringToUnicode([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref sbyte pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref ushort pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ConvertStringToUnicodeEx([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref sbyte pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref ushort pDstStr, [In, Out] ref uint pcDstSize, [In] uint dwFlag, [In] ref ushort lpFallBack);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void CreateConvertCharset([In] uint uiSrcCodePage, [In] uint uiDstCodePage, [In] uint dwProperty, [MarshalAs(UnmanagedType.Interface)] out CMLangConvertCharset ppMLangConvertCharset);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void DetectCodepageInIStream([In] MLDETECTCP flags,
            [In] uint dwPrefWinCodePage,
            [In, MarshalAs(UnmanagedType.Interface)] IStream pstmIn,
            [In, Out] ref DetectEncodingInfo lpEncoding,
            [In, Out] ref int pnScores);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void DetectInputCodepage([In] MLDETECTCP flags, [In] uint dwPrefWinCodePage,
            [In] ref byte pSrcStr, [In, Out] ref int pcSrcSize,
            [In, Out] ref DetectEncodingInfo lpEncoding,
            [In, Out] ref int pnScores);


        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void DetectOutboundCodePage([In] MLCPF dwFlags, [In, MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, [In] uint cchWideChar,
[In] IntPtr puiPreferredCodePages, [In] uint nPreferredCodePages, [In] IntPtr puiDetectedCodePages, [In, Out] ref uint pnDetectedCodePages, [In] ref ushort lpSpecialChar);


        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void DetectOutboundCodePageInIStream([In] uint dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IStream pStrIn, [In] ref uint puiPreferredCodePages, [In] uint nPreferredCodePages, [In] ref uint puiDetectedCodePages, [In, Out] ref uint pnDetectedCodePages, [In] ref ushort lpSpecialChar);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void EnumCodePages([In] uint grfFlags, [MarshalAs(UnmanagedType.Interface)] out IEnumCodePage ppEnumCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void EnumCodePages([In] uint grfFlags, [In] ushort LangId, [MarshalAs(UnmanagedType.Interface)] out IEnumCodePage ppEnumCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void EnumRfc1766([MarshalAs(UnmanagedType.Interface)] out IEnumRfc1766 ppEnumRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void EnumRfc1766([In] ushort LangId, [MarshalAs(UnmanagedType.Interface)] out IEnumRfc1766 ppEnumRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void EnumScripts([In] uint dwFlags, [In] ushort LangId, [MarshalAs(UnmanagedType.Interface)] out IEnumScript ppEnumScript);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCharCodePages([In] ushort chSrc, out uint pdwCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCharsetInfo([In, MarshalAs(UnmanagedType.BStr)] string Charset, out tagMIMECSETINFO pCharsetInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCodePageDescription([In] uint uiCodePage, [In] uint lcid, [In, Out, MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, [In] int cchWideChar);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCodePageInfo([In] uint uiCodePage, out tagMIMECPINFO pCodePageInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetCodePageInfo([In] uint uiCodePage, [In] ushort LangId, out tagMIMECPINFO pCodePageInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetFamilyCodePage([In] uint uiCodePage, out uint puiFamilyCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetFontCodePages([In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC, [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hFont, out uint pdwCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetFontUnicodeRanges([In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC, [In, Out] ref uint puiRanges, out tagUNICODERANGE pUranges);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetLcidFromRfc1766(out uint plocale, [In, MarshalAs(UnmanagedType.BStr)] string bstrRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetNumberOfCodePageInfo(out uint pcCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetNumberOfScripts(out uint pnScripts);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetRfc1766FromLcid([In] uint locale, [MarshalAs(UnmanagedType.BStr)] out string pbstrRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetRfc1766Info([In] uint locale, out tagRFC1766INFO pRfc1766Info);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetRfc1766Info([In] uint locale, [In] ushort LangId, out tagRFC1766INFO pRfc1766Info);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetScriptFontInfo([In] byte sid, [In] uint dwFlags, [In, Out] ref uint puiFonts, out tagSCRIPFONTINFO pScriptFont);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetStrCodePages([In] ref ushort pszSrc, [In] int cchSrc, [In] uint dwPriorityCodePages, out uint pdwCodePages, out int pcchCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink_CodePagesToCodePage([In] uint dwCodePages, [In] uint uDefaultCodePage, out uint puCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink_CodePageToCodePages([In] uint uCodePage, out uint pdwCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink_GetCharCodePages([In] ushort chSrc, out uint pdwCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink_GetStrCodePages([In] ref ushort pszSrc, [In] int cchSrc, [In] uint dwPriorityCodePages, out uint pdwCodePages, out int pcchCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink2_CodePagesToCodePage([In] uint dwCodePages, [In] uint uDefaultCodePage, out uint puCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink2_CodePageToCodePages([In] uint uCodePage, out uint pdwCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink2_GetCharCodePages([In] ushort chSrc, out uint pdwCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink2_GetFontCodePages([In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC, [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hFont, out uint pdwCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink2_GetStrCodePages([In] ref ushort pszSrc, [In] int cchSrc, [In] uint dwPriorityCodePages, out uint pdwCodePages, out int pcchCodePages);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink2_ReleaseFont([In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hFont);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMLangFontLink2_ResetFontMapping();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_ConvertString([In, Out] ref uint pdwMode, [In] uint dwSrcEncoding, [In] uint dwDstEncoding, [In] ref byte pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref byte pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_ConvertStringFromUnicode([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref ushort pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref sbyte pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_ConvertStringReset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_ConvertStringToUnicode([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref sbyte pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref ushort pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_CreateConvertCharset([In] uint uiSrcCodePage, [In] uint uiDstCodePage, [In] uint dwProperty, [MarshalAs(UnmanagedType.Interface)] out CMLangConvertCharset ppMLangConvertCharset);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_GetCharsetInfo([In, MarshalAs(UnmanagedType.BStr)] string Charset, out tagMIMECSETINFO pCharsetInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_GetFamilyCodePage([In] uint uiCodePage, out uint puiFamilyCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_GetLcidFromRfc1766(out uint plocale, [In, MarshalAs(UnmanagedType.BStr)] string bstrRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_GetNumberOfCodePageInfo(out uint pcCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_GetRfc1766FromLcid([In] uint locale, [MarshalAs(UnmanagedType.BStr)] out string pbstrRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage2_IsConvertible([In] uint dwSrcEncoding, [In] uint dwDstEncoding);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ConvertString([In, Out] ref uint pdwMode, [In] uint dwSrcEncoding, [In] uint dwDstEncoding, [In] ref byte pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref byte pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ConvertStringFromUnicode([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref ushort pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref sbyte pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ConvertStringFromUnicodeEx([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref ushort pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref sbyte pDstStr, [In, Out] ref uint pcDstSize, [In] uint dwFlag, [In] ref ushort lpFallBack);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ConvertStringInIStream([In, Out] ref uint pdwMode, [In] uint dwFlag, [In] ref ushort lpFallBack, [In] uint dwSrcEncoding, [In] uint dwDstEncoding, [In, MarshalAs(UnmanagedType.Interface)] IStream pstmIn, [In, MarshalAs(UnmanagedType.Interface)] IStream pstmOut);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ConvertStringReset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ConvertStringToUnicode([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref sbyte pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref ushort pDstStr, [In, Out] ref uint pcDstSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ConvertStringToUnicodeEx([In, Out] ref uint pdwMode, [In] uint dwEncoding, [In] ref sbyte pSrcStr, [In, Out] ref uint pcSrcSize, [In] ref ushort pDstStr, [In, Out] ref uint pcDstSize, [In] uint dwFlag, [In] ref ushort lpFallBack);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_CreateConvertCharset([In] uint uiSrcCodePage, [In] uint uiDstCodePage, [In] uint dwProperty, [MarshalAs(UnmanagedType.Interface)] out CMLangConvertCharset ppMLangConvertCharset);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_DetectCodepageInIStream([In] uint dwFlag, [In] uint dwPrefWinCodePage, [In, MarshalAs(UnmanagedType.Interface)] IStream pstmIn, [In, Out] ref DetectEncodingInfo lpEncoding, [In, Out] ref int pnScores);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_DetectInputCodepage([In] uint dwFlag, [In] uint dwPrefWinCodePage, [In] ref sbyte pSrcStr, [In, Out] ref int pcSrcSize, [In, Out] ref DetectEncodingInfo lpEncoding, [In, Out] ref int pnScores);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_EnumCodePages([In] uint grfFlags, [In] ushort LangId, [MarshalAs(UnmanagedType.Interface)] out IEnumCodePage ppEnumCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_EnumRfc1766([In] ushort LangId, [MarshalAs(UnmanagedType.Interface)] out IEnumRfc1766 ppEnumRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_EnumScripts([In] uint dwFlags, [In] ushort LangId, [MarshalAs(UnmanagedType.Interface)] out IEnumScript ppEnumScript);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetCharsetInfo([In, MarshalAs(UnmanagedType.BStr)] string Charset, out tagMIMECSETINFO pCharsetInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetCodePageDescription([In] uint uiCodePage, [In] uint lcid, [In, Out, MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, [In] int cchWideChar);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetCodePageInfo([In] uint uiCodePage, [In] ushort LangId, out tagMIMECPINFO pCodePageInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetFamilyCodePage([In] uint uiCodePage, out uint puiFamilyCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetLcidFromRfc1766(out uint plocale, [In, MarshalAs(UnmanagedType.BStr)] string bstrRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetNumberOfCodePageInfo(out uint pcCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetNumberOfScripts(out uint pnScripts);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetRfc1766FromLcid([In] uint locale, [MarshalAs(UnmanagedType.BStr)] out string pbstrRfc1766);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_GetRfc1766Info([In] uint locale, [In] ushort LangId, out tagRFC1766INFO pRfc1766Info);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_IsCodePageInstallable([In] uint uiCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_IsConvertible([In] uint dwSrcEncoding, [In] uint dwDstEncoding);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_SetMimeDBSource([In] tagMIMECONTF dwSource);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ValidateCodePage([In] uint uiCodePage, [In, ComAliasName("MultiLanguage.wireHWND")] ref _RemotableHandle hwnd);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IMultiLanguage3_ValidateCodePageEx([In] uint uiCodePage, [In, ComAliasName("MultiLanguage.wireHWND")] ref _RemotableHandle hwnd, [In] uint dwfIODControl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IsCodePageInstallable([In] uint uiCodePage);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void IsConvertible([In] uint dwSrcEncoding, [In] uint dwDstEncoding);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void MapFont([In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC, [In] uint dwCodePages, [In] ushort chSrc, [Out, ComAliasName("MultiLanguage.wireHFONT")] IntPtr pFont);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void MapFont([In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC, [In] uint dwCodePages, [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hSrcFont, [Out, ComAliasName("MultiLanguage.wireHFONT")] IntPtr phDestFont);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ReleaseFont([In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hFont);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ResetFontMapping();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetMimeDBSource([In] tagMIMECONTF dwSource);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ValidateCodePage([In] uint uiCodePage, [In, ComAliasName("MultiLanguage.wireHWND")] ref _RemotableHandle hwnd);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void ValidateCodePageEx([In] uint uiCodePage, [In, ComAliasName("MultiLanguage.wireHWND")] ref _RemotableHandle hwnd, [In] uint dwfIODControl);
    }
}
