/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class OTPassword : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OTPassword(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(OTPassword obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~OTPassword() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_OTPassword(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public OTPassword.BlockSize m_theBlockSize {
    get {
      OTPassword.BlockSize ret = (OTPassword.BlockSize)otapiPINVOKE.OTPassword_m_theBlockSize_get(swigCPtr);
      return ret;
    } 
  }

  public bool isPassword() {
    bool ret = otapiPINVOKE.OTPassword_isPassword(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_uint8_t getPassword_uint8() {
    IntPtr cPtr = otapiPINVOKE.OTPassword_getPassword_uint8(swigCPtr);
    SWIGTYPE_p_uint8_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_uint8_t(cPtr, false);
    return ret;
  }

  public string getPassword() {
    string ret = otapiPINVOKE.OTPassword_getPassword(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_uint8_t getPasswordWritable() {
    IntPtr cPtr = otapiPINVOKE.OTPassword_getPasswordWritable(swigCPtr);
    SWIGTYPE_p_uint8_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_uint8_t(cPtr, false);
    return ret;
  }

  public int setPassword(string szInput, int nInputSize) {
    int ret = otapiPINVOKE.OTPassword_setPassword(swigCPtr, szInput, nInputSize);
    return ret;
  }

  public SWIGTYPE_p_int32_t setPassword_uint8(SWIGTYPE_p_uint8_t szInput, SWIGTYPE_p_uint32_t nInputSize) {
    SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(otapiPINVOKE.OTPassword_setPassword_uint8(swigCPtr, SWIGTYPE_p_uint8_t.getCPtr(szInput), SWIGTYPE_p_uint32_t.getCPtr(nInputSize)), true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool addChar(SWIGTYPE_p_uint8_t theChar) {
    bool ret = otapiPINVOKE.OTPassword_addChar(swigCPtr, SWIGTYPE_p_uint8_t.getCPtr(theChar));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_int32_t randomizePassword(SWIGTYPE_p_uint32_t nNewSize) {
    SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(otapiPINVOKE.OTPassword_randomizePassword__SWIG_0(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(nNewSize)), true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_int32_t randomizePassword() {
    SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(otapiPINVOKE.OTPassword_randomizePassword__SWIG_1(swigCPtr), true);
    return ret;
  }

  public static bool randomizePassword_uint8(SWIGTYPE_p_uint8_t szDestination, SWIGTYPE_p_uint32_t nNewSize) {
    bool ret = otapiPINVOKE.OTPassword_randomizePassword_uint8(SWIGTYPE_p_uint8_t.getCPtr(szDestination), SWIGTYPE_p_uint32_t.getCPtr(nNewSize));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool randomizePassword(string szDestination, SWIGTYPE_p_uint32_t nNewSize) {
    bool ret = otapiPINVOKE.OTPassword_randomizePassword__SWIG_2(szDestination, SWIGTYPE_p_uint32_t.getCPtr(nNewSize));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isMemory() {
    bool ret = otapiPINVOKE.OTPassword_isMemory(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_void getMemory() {
    IntPtr cPtr = otapiPINVOKE.OTPassword_getMemory(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_uint8_t getMemory_uint8() {
    IntPtr cPtr = otapiPINVOKE.OTPassword_getMemory_uint8(swigCPtr);
    SWIGTYPE_p_uint8_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_uint8_t(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_void getMemoryWritable() {
    IntPtr cPtr = otapiPINVOKE.OTPassword_getMemoryWritable(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_int32_t setMemory(SWIGTYPE_p_void vInput, SWIGTYPE_p_uint32_t nInputSize) {
    SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(otapiPINVOKE.OTPassword_setMemory(swigCPtr, SWIGTYPE_p_void.getCPtr(vInput), SWIGTYPE_p_uint32_t.getCPtr(nInputSize)), true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_int32_t addMemory(SWIGTYPE_p_void vAppend, SWIGTYPE_p_uint32_t nAppendSize) {
    SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(otapiPINVOKE.OTPassword_addMemory(swigCPtr, SWIGTYPE_p_void.getCPtr(vAppend), SWIGTYPE_p_uint32_t.getCPtr(nAppendSize)), true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_int32_t randomizeMemory(SWIGTYPE_p_uint32_t nNewSize) {
    SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(otapiPINVOKE.OTPassword_randomizeMemory__SWIG_0(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(nNewSize)), true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_int32_t randomizeMemory() {
    SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(otapiPINVOKE.OTPassword_randomizeMemory__SWIG_1(swigCPtr), true);
    return ret;
  }

  public static bool randomizeMemory_uint8(SWIGTYPE_p_uint8_t szDestination, SWIGTYPE_p_uint32_t nNewSize) {
    bool ret = otapiPINVOKE.OTPassword_randomizeMemory_uint8(SWIGTYPE_p_uint8_t.getCPtr(szDestination), SWIGTYPE_p_uint32_t.getCPtr(nNewSize));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool randomizeMemory(SWIGTYPE_p_void szDestination, SWIGTYPE_p_uint32_t nNewSize) {
    bool ret = otapiPINVOKE.OTPassword_randomizeMemory__SWIG_2(SWIGTYPE_p_void.getCPtr(szDestination), SWIGTYPE_p_uint32_t.getCPtr(nNewSize));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_uint32_t getBlockSize() {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(otapiPINVOKE.OTPassword_getBlockSize(swigCPtr), true);
    return ret;
  }

  public bool Compare(OTPassword rhs) {
    bool ret = otapiPINVOKE.OTPassword_Compare(swigCPtr, OTPassword.getCPtr(rhs));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_uint32_t getPasswordSize() {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(otapiPINVOKE.OTPassword_getPasswordSize(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_uint32_t getMemorySize() {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(otapiPINVOKE.OTPassword_getMemorySize(swigCPtr), true);
    return ret;
  }

  public void zeroMemory() {
    otapiPINVOKE.OTPassword_zeroMemory__SWIG_0(swigCPtr);
  }

  public static void zeroMemory(SWIGTYPE_p_uint8_t szMemory, SWIGTYPE_p_uint32_t theSize) {
    otapiPINVOKE.OTPassword_zeroMemory__SWIG_1(SWIGTYPE_p_uint8_t.getCPtr(szMemory), SWIGTYPE_p_uint32_t.getCPtr(theSize));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void zeroMemory(SWIGTYPE_p_void vMemory, SWIGTYPE_p_uint32_t theSize) {
    otapiPINVOKE.OTPassword_zeroMemory__SWIG_2(SWIGTYPE_p_void.getCPtr(vMemory), SWIGTYPE_p_uint32_t.getCPtr(theSize));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public static SWIGTYPE_p_void safe_memcpy(SWIGTYPE_p_void dest, SWIGTYPE_p_uint32_t dest_size, SWIGTYPE_p_void src, SWIGTYPE_p_uint32_t src_length, bool bZeroSource) {
    IntPtr cPtr = otapiPINVOKE.OTPassword_safe_memcpy__SWIG_0(SWIGTYPE_p_void.getCPtr(dest), SWIGTYPE_p_uint32_t.getCPtr(dest_size), SWIGTYPE_p_void.getCPtr(src), SWIGTYPE_p_uint32_t.getCPtr(src_length), bZeroSource);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_void safe_memcpy(SWIGTYPE_p_void dest, SWIGTYPE_p_uint32_t dest_size, SWIGTYPE_p_void src, SWIGTYPE_p_uint32_t src_length) {
    IntPtr cPtr = otapiPINVOKE.OTPassword_safe_memcpy__SWIG_1(SWIGTYPE_p_void.getCPtr(dest), SWIGTYPE_p_uint32_t.getCPtr(dest_size), SWIGTYPE_p_void.getCPtr(src), SWIGTYPE_p_uint32_t.getCPtr(src_length));
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OTPassword(OTPassword.BlockSize theBlockSize) : this(otapiPINVOKE.new_OTPassword__SWIG_0((int)theBlockSize), true) {
  }

  public OTPassword() : this(otapiPINVOKE.new_OTPassword__SWIG_1(), true) {
  }

  public OTPassword(OTPassword rhs) : this(otapiPINVOKE.new_OTPassword__SWIG_2(OTPassword.getCPtr(rhs)), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public OTPassword(string szInput, SWIGTYPE_p_uint32_t nInputSize, OTPassword.BlockSize theBlockSize) : this(otapiPINVOKE.new_OTPassword__SWIG_3(szInput, SWIGTYPE_p_uint32_t.getCPtr(nInputSize), (int)theBlockSize), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public OTPassword(string szInput, SWIGTYPE_p_uint32_t nInputSize) : this(otapiPINVOKE.new_OTPassword__SWIG_4(szInput, SWIGTYPE_p_uint32_t.getCPtr(nInputSize)), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public OTPassword(SWIGTYPE_p_uint8_t szInput, SWIGTYPE_p_uint32_t nInputSize, OTPassword.BlockSize theBlockSize) : this(otapiPINVOKE.new_OTPassword__SWIG_5(SWIGTYPE_p_uint8_t.getCPtr(szInput), SWIGTYPE_p_uint32_t.getCPtr(nInputSize), (int)theBlockSize), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public OTPassword(SWIGTYPE_p_uint8_t szInput, SWIGTYPE_p_uint32_t nInputSize) : this(otapiPINVOKE.new_OTPassword__SWIG_6(SWIGTYPE_p_uint8_t.getCPtr(szInput), SWIGTYPE_p_uint32_t.getCPtr(nInputSize)), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public OTPassword(SWIGTYPE_p_void vInput, SWIGTYPE_p_uint32_t nInputSize, OTPassword.BlockSize theBlockSize) : this(otapiPINVOKE.new_OTPassword__SWIG_7(SWIGTYPE_p_void.getCPtr(vInput), SWIGTYPE_p_uint32_t.getCPtr(nInputSize), (int)theBlockSize), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public OTPassword(SWIGTYPE_p_void vInput, SWIGTYPE_p_uint32_t nInputSize) : this(otapiPINVOKE.new_OTPassword__SWIG_8(SWIGTYPE_p_void.getCPtr(vInput), SWIGTYPE_p_uint32_t.getCPtr(nInputSize)), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum BlockSize {
    DEFAULT_SIZE = 128,
    LARGER_SIZE = 32767
  }

}
