//****************************************************************************************
//* Modem Management Protocol (MMP) Definition Header File
//*
//* Copyright (C) 2022 Teledyne Marine Systems
//* All Rights Reserved
//*
//* Automatically generated on 03/11/2022 at 16:01:34
//****************************************************************************************


using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;
using System.Collections.Generic;
using ip = System.Net.IPAddress;

namespace TDY.Modem.MMP
{
	public interface iMMP
	{
		int Size
		{
			get;
		}
		byte[] serialize();
	}

	public enum mmp_const : ulong
	{
		/*
 Acoustic trigger maximum assert time that can be specified in acoustic message
  system=constant

		*/
		ACOUTRIG_MAX_ASSERT_SECS                 = 2790,
		/*
 Sentinel for acoustic battery charge response
  system=constant

		*/
		ACOU_BATT_CHG_UNAVAIL                    = 0xFF,
		/*
  system=constant

		*/
		ACOU_SAMPLE_CELL_SIZE                    = 1024,
		/*
  system=constant

		*/
		AES_MAX_KEY_SIZE                         = 16,
		/*
  system=constant

		*/
		BATTERY_STATUS_COUNTS_PER_VOLT           = 2,
		/*
  system=constant

		*/
		BATTERY_STATUS_VOLT_RANGE                = 60,
		/*
  system=constant

		*/
		BATTLIFE_NUM_VOLT_READINGS               = 2,
		/*
  system=constant

		*/
		BATT_EXTDC                               = 4,
		/*
  system=constant

		*/
		BATT_IBPS                                = 1,
		/*
  system=constant

		*/
		BATT_LIPRIMARY                           = 3,
		/*
  system=constant

		*/
		BATT_SMART                               = 2,
		/*
  system=constant

		*/
		BATT_STD                                 = 0,
		/*
  system=constant

		*/
		BOOTLOADER_BASE                          = 0x00000L,
		/*
  system=constant

		*/
		BOOTLOADER_SIZE                          = 0x1ffffL,
		/*
  system=constant

		*/
		BURN_WIRE_WAIT_TIME                      = 36000,
		/*
  system=constant

		*/
		CPBOARD_ALWAYS                           = 2,
		/*
  system=constant

		*/
		CPBOARD_OFF                              = 0,
		/*
  system=constant

		*/
		CPBOARD_PROGRAM                          = 3,
		/*
  system=constant

		*/
		CPBOARD_PWRSAVE                          = 1,
		/*
  system=constant

		*/
		DFLT_MAX_NUM_SMART_BATTS                 = 4,
		/*
  system=constant

		*/
		DIAG_BASE                                = 0x60000L,
		/*
 Datalogger record store locations
  system=constant

		*/
		DLOG_CFG_STORE_INTERNAL                  = 0,
		/*
  system=constant

		*/
		DLOG_CFG_STORE_SDHC                      = 1,
		/*
  system=constant

		*/
		DLOG_SRCFLAG_ALL                         = 0xFFFF,
		/*
 system=constant

		*/
		FEAT_KEY_PREFIX_LEN                      = 9,
		/*
  system=constant

		*/
		GEOPRO_MAX_ADDR                          = 120,
		/*
  system=constant

		*/
		GEOPRO_MIN_ADDR                          = 1,
		/*
  system=constant

		*/
		GET_1CHIRP_RNG_RESPONSE_DOWN             = 1,
		/*
  system=constant

		*/
		GET_1CHIRP_RNG_RESPONSE_UP               = 0,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_ABSOLUTE                  = 0,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_COMPASS                   = 2,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_DEPTH                     = 11,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_HIGH_ABS                  = 4,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_HIGH_COM                  = 8,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_HIGH_ELV                  = 7,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_HIGH_INC                  = 5,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_HIGH_PCH                  = 9,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_HIGH_REL                  = 6,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_HIGH_RLL                  = 10,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_HOMING                    = 14,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_PROBE                     = 13,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_RANGE_ONLY                = 15,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_RELATIVE                  = 1,
		/*
  system=constant

		*/
		GET_RANGE_TYPE_TILT                      = 3,
		/*
  system=constant

		*/
		GPSSYNC_GGA                              = 2,
		/*
  system=constant

		*/
		GPSSYNC_NONE                             = 0,
		/*
  system=constant

		*/
		GPSSYNC_RMC                              = 3,
		/*
  system=constant

		*/
		GPSSYNC_ZDA                              = 1,
		/*
  system=constant

		*/
		IMAGE_BASE                               = 0x20000L,
		/*
  system=constant

		*/
		IMAGE_SIZE                               = 0x7ffffL,
		/*
  system=constant

		*/
		INVALID_BEARING                          = 0xFFFF,
		/*
 system=constant

		*/
		MAX_FEAT_KEYS                            = 32,
		/*
  system=constant

		*/
		MAX_TRANSPORT_ADDR                       = 4,
		/*
  system=constant

		*/
		MAX_TRANSPORT_DST                        = 3,
		/*
 system=constant

		*/
		MD5_ASCII_KEY_LEN                        = 32,
		/*
 system=constant

		*/
		MD5_KEY_LEN                              = 16,
		/*
  system=constant

		*/
		MIN_TRANSPORT_ADDR                       = 1,
		/*
  system=constant

		*/
		MIN_TRANSPORT_DST                        = 0,
		/*
  system=constant

		*/
		MMP_ACOU_FLAG_ACKONLY                    = 0x0001,
		/*
 system=constant

		*/
		MMP_FEAT_KEY_LEN                         = 42,
		/*
 
 system=constant

		*/
		MMP_HDRERR_LOWSNRACQ                     = 0x7FFF,
		/*
  system=constant

		*/
		MMP_MAX_DEVICE_LEN_REQUEST               = 4096,
		/*
 Highest value of a notification counter before it wraps
  system=constant

		*/
		MMP_NTFY_COUNT_MAX                       = 0xFF,
		/*
  system=constant

		*/
		MMP_SREG_ALL_SIZE                        = 60,
		/*
  system=constant

		*/
		MODEM_APP_VERSION_MAJOR                  = 8,
		/*
  system=constant

		*/
		MODEM_APP_VERSION_MINOR                  = 15,
		/*
  system=constant

		*/
		MODEM_APP_VERSION_REVISION               = 3,
		/*
  system=constant

		*/
		MOD_FH_160_MA                            = 66,
		/*
  system=constant

		*/
		MOD_FH_80_JA                             = 68,
		/*
  system=constant

		*/
		MOD_FH_80_MA                             = 67,
		/*
  system=constant

		*/
		MOD_FH_80_MR                             = 65,
		/*
  system=constant

		*/
		MOD_FH_80_STD                            = 1,
		/*
  system=constant

		*/
		MOD_FH_80_WH                             = 64,
		/*
  system=constant

		*/
		MOD_MFSK_1066                            = 6,
		/*
  system=constant

		*/
		MOD_MFSK_1066x2                          = 26,
		/*
  system=constant

		*/
		MOD_MFSK_1200                            = 7,
		/*
  system=constant

		*/
		MOD_MFSK_1200x2                          = 27,
		/*
  system=constant

		*/
		MOD_MFSK_140                             = 2,
		/*
  system=constant

		*/
		MOD_MFSK_140x2                           = 22,
		/*
  system=constant

		*/
		MOD_MFSK_2400                            = 8,
		/*
  system=constant

		*/
		MOD_MFSK_2400x2                          = 28,
		/*
  system=constant

		*/
		MOD_MFSK_300                             = 3,
		/*
  system=constant

		*/
		MOD_MFSK_300x2                           = 23,
		/*
  system=constant

		*/
		MOD_MFSK_600                             = 4,
		/*
  system=constant

		*/
		MOD_MFSK_600x2                           = 24,
		/*
  system=constant

		*/
		MOD_MFSK_800                             = 5,
		/*
  system=constant

		*/
		MOD_MFSK_800x2                           = 25,
		/*
  system=constant

		*/
		MOD_PSK_10240                            = 12,
		/*
  system=constant

		*/
		MOD_PSK_15360                            = 13,
		/*
  system=constant

		*/
		MOD_PSK_2560                             = 9,
		/*
  system=constant

		*/
		MOD_PSK_5120                             = 10,
		/*
  system=constant

		*/
		MOD_PSK_7680                             = 11,
		/*
  system=constant

		*/
		NULL_BOOT_IMAGE                          = 0xffffffffL,
		/*
  system=constant

		*/
		NULL_TRANSPORT_ADDR                      = 0,
		/*
  system=constant

		*/
		NUM_TRANSPORT_ADDRS                      = 5,
		/*
  system=constant

		*/
		NUM_TRANSPORT_DSTS                       = 4,
		/*
  system=constant

		*/
		PM_PROC_RATE                             = 20,
		/*
  system=constant

		*/
		PPS_MODE_CSAC                            = 3,
		/*
  system=constant

		*/
		PPS_MODE_EXT_FALL                        = 4,
		/*
  system=constant

		*/
		PPS_MODE_EXT_RISE                        = 1,
		/*
  system=constant

		*/
		PPS_MODE_INT_RTC                         = 2,
		/*
  system=constant

		*/
		PPS_MODE_MAX_NUM                         = 5,
		/*
  system=constant

		*/
		PPS_MODE_OFF                             = 0,
		/*
  system=constant

		*/
		PROBE_DATA_SIZE                          = 512,
		/*
  system=constant

		*/
		RELEASE_WAIT_TIME                        = 800,
		/*
  system=constant

		*/
		REMOTE_AGC_HISTORY_SIZE                  = 10,
		/*
  system=constant

		*/
		REMOTE_REGISTERS_SIZE                    = 21,
		/*
  system=constant

		*/
		RESPONDER_MODE_FALL                      = 2,
		/*
  system=constant

		*/
		RESPONDER_MODE_OFF                       = 0,
		/*
  system=constant

		*/
		RESPONDER_MODE_RISE                      = 1,
		/*
  system=constant

		*/
		RESPONDER_MODE_SEND                      = 3,
		/*
  system=constant

		*/
		SEND_RANGE_TAT_FAST                      = 1,
		/*
  system=constant

		*/
		SEND_RANGE_TAT_SLOW                      = 0,
		/*
  system=constant

		*/
		SEND_RANGE_TAT_VFAST                     = 2,
		/*
  system=constant

		*/
		SERIAL_BOOT_IMAGE_U1                     = 0xfffffffeL,
		/*
  system=constant

		*/
		SERIAL_BOOT_IMAGE_U2                     = 0xfffffffdL,
		/*
  system=constant

		*/
		SREG_NORM                                = 60,
		/*
eliminated neighbor table
  system=constant

		*/
		SREG_TOTAL                               = 60,
		/*
  system=constant

		*/
		SVN_REVNO                                = 19863,
		/*
  system=constant

		*/
		TRANSPOND_MAX_RX_WIDTH                   = 15,
		/*
  system=constant

		*/
		TRANSPOND_MIN_RX_WIDTH                   = 5,
		/*
  system=constant

		*/
		TRANSPORT_DST_P1                         = 1,
		/*
  system=constant

		*/
		TRANSPORT_DST_P2                         = 2,
		/*
  system=constant

		*/
		TR_TX_MAX_PWR                            = 8,
		/*
  system=constant

		*/
		TTS_MAX_DETECT_THRESH                    = 999L,
		/*
  system=constant

		*/
		TTS_MIN_DETECT_THRESH                    = 10L,
		/*
  system=constant

		*/
		TXPWR_UNAVAIL                            = 0x7FFF,
		/*
  system=constant

		*/
		URI_CLR_CODE                             = 76,
		/*
  system=constant

		*/
		URI_MAX_CMD_CODE                         = 75,
		/*
  system=constant

		*/
		URI_MAX_CODE                             = 76,
		/*
  system=constant

		*/
		URI_MAX_RLS_CODE                         = 63,
		/*
  system=constant

		*/
		URI_MIN_CMD_CODE                         = 64,
		/*
  system=constant

		*/
		URI_MIN_CODE                             = 0,
		/*
  system=constant

		*/
		URI_MIN_RLS_CODE                         = 0,
		/*
  system=constant

		*/
		USERIMAGE_BASE                           = 0x10000L,
		/*
  system=constant

		*/
		USERIMAGE_MASK                           = 0x0FFFFL,
		/*
  system=constant

		*/
		UTS_MAX_NUM_SMART_BATTS                  = 2,
		/*
  system=constant

		*/
		XPND_MAX_FREQ_LF                         = 16000,
		/*
  system=constant

		*/
		XPND_MAX_TX_FREQ                         = 70000,
		/*
  system=constant

		*/
		XPND_MIN_FREQ_LF                         = 7000,
		/*
  system=constant

		*/
		XPND_MIN_TX_FREQ                         = 1000,
		/*
  system=constant

		*/
		XPND_STEP                                = 250,
		/*
  system=constant

		*/
		XPND_TTS_FREQS                           = 41,
		/*
  system=constant

		*/
		_IO_TONE_MODE_HPR400                     = 2,
		/*
 defines for USBLmode config prarameter
  system=constant

		*/
		_IO_TONE_MODE_NONE                       = 0,
		/*
  system=constant

		*/
		_IO_TONE_MODE_TONE                       = 1,
		/*
  system=constant

		*/
		_NUM_TILT_AXES                           = 3,
		/*
  system=constant

		*/
		_TILT_AP_XNEG                            = 1,
		/*
  system=constant

		*/
		_TILT_AP_XPOS                            = 0,
		/*
  system=constant

		*/
		_TILT_AP_YNEG                            = 3,
		/*
  system=constant

		*/
		_TILT_AP_YPOS                            = 2,
		/*
  system=constant

		*/
		_TILT_AP_ZNEG                            = 5,
		/*
  system=constant

		*/
		_TILT_AP_ZPOS                            = 4,
		/*
 Defines of the three tilt/acceleration axes
  system=constant

		*/
		_TILT_AXIS_X                             = 0,
		/*
  system=constant

		*/
		_TILT_AXIS_Y                             = 1,
		/*
  system=constant

		*/
		_TILT_AXIS_Z                             = 2,
		/*
  system=constant

		*/
		_TILT_POLARITY_NEG                       = 1,
		/*
  system=constant

		*/
		_TILT_POLARITY_POS                       = 0,
		/*
  system=constant

		*/
		_UDB_VERSION_MAJOR                       = 8,
		/*
  system=constant

		*/
		_UDB_VERSION_MINOR                       = 15,
		/*
  system=constant

		*/
		_UDB_VERSION_REVISION                    = 3
	};

	/*
 

	*/
	public enum mmp_version_num_t
	{
	    MMP_VERSION_MAJOR                        = 2,
	    MMP_VERSION_MINOR                        = 5
	};


	/*
 

	*/
	public enum mmp_misc_t
	{
	    MMP_BUFSIZE                              = 4224,    // Maximum MMP buffer size in bytes
	    MMP_RESPONSE_TIMEOUT                     = 1500,    // Time in msec for an MMP response to come back
	    MMP_NMEA_BUFSIZE                         = 103    // Maximum NMEA sentence size + 21 (Hemisphere, for example, exceeds the 82 character spec)
	};


	/*
 

	*/
	public enum mmp_sentinel_t
	{
	    MMP_SENTINEL                             = '@',    // Separator for serial MMP commands
	    NMEA_SENTINEL                            = '$'
	};


	/*
 
 subfield=mmp_gsxn_t::type

	*/
	public enum mmp_type_t
	{
	    MMP_GET                                  = 'g',    // Indicates an MMP GET operation
	    MMP_SET                                  = 's',    // Indicates an MMP SET operation
	    MMP_EXECUTE                              = 'x',    // Indicates an MMP EXEC operation
	    MMP_NOTIFY                               = 'n'    // Indicates an MMP NOTIFY operation
	};


	/*
*************************
 MMP Command Sections
*************************
 
 system=cmdsect
 subfield=mmp_cmd_result_t::cmdsect

	*/
	public enum mmp_cmdsect_t
	{
	    MMP_CMDSECT_NULL                         = 0x00,    // Null command section (unused)
	    MMP_CMDSECT_STD                          = 0x01,    // Standard commands and operations supported on most modem-based platforms
	    MMP_CMDSECT_RNGRLS                       = 0x02,    // Ranging and releasing operations
	    MMP_CMDSECT_DATALOG                      = 0x04,    // Commands for Data Logger
	    MMP_NUM_CMDSECT                          = 0x06
	};


	/*
*************************
 MMP Subsystems
*************************
 
 system=subsys

	*/
	public enum mmp_subsys_t
	{
	    MMP_SUBSYS_IFACE                         = 0x00,    // MMP interface configuration and control data/notifications
	    MMP_SUBSYS_SREG                          = 0x01,    // S-Registers
	    MMP_SUBSYS_DECKBOX                       = 0x02,    // Deck box-specific data/notifications
	    MMP_SUBSYS_DATA                          = 0x04,    // Data packets and other general notifications
	    MMP_SUBSYS_TRANSPOND                     = 0x05,    // Transponding and ranging data/notifications
	    MMP_SUBSYS_TIME                          = 0x06,    // Time- and date-related data/notifications
	    MMP_SUBSYS_CFG_ALL                       = 0x3F,    // Special subsystem for retrieving all values in a config section: set the field with the CFG section number to get or MMP_SUBSYS_CFG_ALL to get all sections.  If used with a SET operation and MMP_SUBSYS_CFG_ALL is used for both the the subsys and field, the configuration database will be written to flash.
	    CFG_SECT_COPROC                          = 0x40,    // Co-processor board
	    CFG_SECT_DATALOG                         = 0x41,    // On-board datalogger
	    CFG_SECT_MODEM                           = 0x42,    // Modem functionality
	    CFG_SECT_RELEASE                         = 0x44,    // Release functionality
	    CFG_SECT_SERIAL                          = 0x46,    // UART paramters
	    CFG_SECT_SYSTEM                          = 0x47,    // System parameters
	    CFG_SECT_TEST                            = 0x48,    // Test functionality
	    CFG_SECT_VERSION                         = 0x49,    // Version information
	    CFG_SECT_XPND                            = 0x4A,    // Transpond control
	    CFG_SECT_DAT                             = 0x4B,    // (DAT ONLY) Directional Acoustic Transponder configuration
	    CFG_SECT_NAV                             = 0x4C,    // Navigation and Positioning
	    CFG_SECT_RECORDER                        = 0x4D,    // In-band acoustic data recorder configuration
	    CFG_SECT_TRANSPORT                       = 0x50,    // Transport layer routing/tagging information
	    CFG_SECT_AIN                             = 0x52,
	    CFG_SECT_PRESSURE                        = 0x53,
	    CFG_SECT_USBL                            = 0x54,    // (DAT ONLY) USBL control section
	    CFG_SECT_JANUS                           = 0x56,    // JANUS configuration parameters
	    MMP_NUM_SUBSYS                           = 0x57
	};


	/*
 
 subfield=mmp_gsxn_t::xid

	*/
	public enum mmp_xid_sentinel_t
	{
	    MMP_XID_NULL                             = 0,
	    MMP_XID_FIRST                            = 1,
	    MMP_XID_LAST                             = 255
	};


	/*
==============================================================================
 Generic values/ranges for MMP structure subfields
==============================================================================
 
 subfield=mmp_data_trrc_status_t::tr_band_fail
 subfield=mmp_data_trrc_status_t::tr_read_fail
 subfield=mmp_data_trrc_status_t::rc_band_fail
 subfield=mmp_data_trrc_status_t::rc_read_fail
 subfield=mmp_pwrsense_t::charging
 subfield=mmp_spkr_phones_vol_t::mute
 subfield=mmp_rngrls_transpond_t::rcv_only
 subfield=mmp_rngrls_transpond_t::silent
 subfield=mmp_network_onistate_t::enable
 subfield=mmp_data_fpm_boot_failure_t::failure
 subfield=mmp_iface_ntfy_count_t::enable
 subfield=mmp_std_contxmit_enable_t::enable
 subfield=mmp_time_syncinfo_t::qualifying
 subfield=mmp_time_syncinfo_t::ext_time

	*/
	public enum mmp_bool_t
	{
	    MMP_FALSE                                = 0,    // False/Off/Disabled
	    MMP_TRUE                                 = 1    // True/On/Enabled
	};


	/*
 
 subfield=mmp_cfg_paramval_t::val_or_len

	*/
	public enum mmp_various_t
	{
	    various_values                           = 0    // Values here should be appropriate for the subsystem::field being set/gotten.
	};


	/*
 
 subfield=mmp_spkr_phones_vol_t::volume

	*/
	public enum mmp_u8_bit_range_t
	{
	    val_8_bit                                = 0    // 0 to 255
	};


	/*
 

	*/
	public enum mmp_u16_bit_range_t
	{
	    val_16_bit                               = 0    // 0 to 65535
	};


	/*
 

	*/
	public enum mmp_s16_bit_range_t
	{
	    signed_val_16_bit                        = 0    // -32768 to 32767
	};


	/*
 

	*/
	public enum mmp_u32_bit_range_t
	{
	    val_32_bit                               = 0    // 0 to 4,294,967,295
	};


	/*
 

	*/
	public enum mmp_s32_bit_range_t
	{
	    signed_val_32_bit                        = 0    // -2,147,483,648 to 2,147,483,647
	};


	/*
 
 subfield=mmp_cfg_paramval_t::type

	*/
	public enum cfg_param_type_t
	{
	    CFG_NUM16                                = 0,    // A signed 16-bit integer
	    CFG_NUM32                                = 1,    // A signed 32-bit integer
	    CFG_STR                                  = 2,    // A variable length character string
	    CFG_BOOL                                 = 3,    // A Boolean value (0 for false, 1 for true)
	    CFG_FIXED                                = 4,    // A 32-bit integer representing a fractional number with 0.0001 precision.  Divide this integer value by 10000 to obtain the true fractional value it represents.
	    CFG_ENUM                                 = 5,    // A 32-bit signed enumerated value.  This config parameter is restricted to a finite set of pre-defined values dependent on which configuration field it applies to.
	    CFG_CSTM                                 = 6,    // A custom format with layout dependent on the configuration field it applies to.
	    CFG_BITMASK                              = 7    // A format allowing the sum of valid values
	};


	/*
 Sect COPROC
============
 
 subsys=CFG_SECT_COPROC

	*/
	public enum cfg_coproc_param_enum_t
	{
	    CFG_COPROC_CPBOARD                       = 0,    // Indicate power mode of coprocessor board
	    CFG_COPROC_FDFWDTAPS                     = 1,    // PSK number of forward taps
	    CFG_COPROC_FDBCKTAPS                     = 2,    // PSK number of backward taps
	    CFG_NUM_COPROC_PARAMS                    = 3
	};


	/*
 Sect DATALOG
=============
 
 subsys=CFG_SECT_DATALOG

	*/
	public enum cfg_datalog_param_enum_t
	{
	    CFG_DATALOG_ACDATA                       = 0,    // Log acoustically received data to datalogger
	    CFG_DATALOG_ACSTATS                      = 1,    // Log acoustic statistics to datalogger
	    CFG_DATALOG_RINGBUF                      = 2,    // Configure datalogger as flat (stop when full) or circular (oldest records discarded for newer)
	    CFG_DATALOG_SUBBLKS                      = 3,
	    CFG_DATALOG_LOGMODE                      = 4,    // The record-partitioning mode for the data logger: time, character, or size based.
	    CFG_DATALOG_SENTINEL                     = 5,    // The ASCII value of a sentinel character that will trigger closure of a discrete record in the data logger
	    CFG_DATALOG_CHRCOUNT                     = 6,    // The number of characters that must be reached in order to trigger closure of a discrete record in the data logger
	    CFG_DATALOG_LOGSTORE                     = 7,    // Indicates which storage medium the data logger points to (internal or external SDHC)
	    CFG_NUM_DATALOG_PARAMS                   = 8
	};


	/*
 Sect MODEM
=============
 
 subsys=CFG_SECT_MODEM

	*/
	public enum cfg_modem_param_enum_t
	{
	    CFG_MODEM_DATARETRY                      = 0,    // Acoustic data retry mode
	    CFG_MODEM_ACRSPTMOUT                     = 1,    // Acoustic response timeout
	    CFG_MODEM_OPMODE                         = 2,    // Operation mode
	    CFG_MODEM_DEVENABLE                      = 3,    // Device enable line behavior
	    CFG_MODEM_UNUSED1                        = 4,
	    CFG_MODEM_FWDDELAY                       = 5,    // Data packet forwarding delay
	    CFG_MODEM_UNUSED2                        = 6,
	    CFG_MODEM_LOCALADDR                      = 7,    // Modem local address
	    CFG_MODEM_PRNTHEX                        = 8,    // Print modem data hexadecimal
	    CFG_MODEM_REMOTEADDR                     = 9,    // Modem default remote address
	    CFG_MODEM_RXPKTTYPE                      = 10,    // Receive packet type
	    CFG_MODEM_SHOWBADDATA                    = 11,    // Determine whether to process or discard data with bit errors
	    CFG_MODEM_STARTTONES                     = 12,    // Control playing of startup tones upon boot
	    CFG_MODEM_TXRATE                         = 13,    // Acoustic transmit bitrate of data
	    CFG_MODEM_TXPOWER                        = 14,    // Acoustic transmit power level
	    CFG_MODEM_WAKETONES                      = 15,    // Control sending of wakeup preamble tones.
	    CFG_MODEM_RSVD1                          = 16,    // Unused
	    CFG_MODEM_INPUTMODE                      = 17,    // Select the UART input mode for data transfer and data logging (single, dual)
	    CFG_MODEM_SMARTRETRY                     = 18,    // Control use of SmartRetry functionality for corrupted packet transmissions when data retries are enabled
	    CFG_MODEM_L2PROTOCOL                     = 19,    // Layer 2 Protocol selector
	    CFG_MODEM_HEADERRATE                     = 20,    // Acoustic transmit bitrate rate of header
	    CFG_MODEM_DOMAINKEY                      = 21,    // Domain key that is used to create comms exclusivity groups
	    CFG_MODEM_AUTODETECTHDR                  = 22,    // Determine whether to enable auto detect of header or use setting in HeaderRate parm
	    CFG_MODEM_CHIRP_THRESHOLD                = 23,    // threshold adjustment for chirp detection
	    CFG_MODEM_TXATTEN                        = 24,    // Sets the maximum acoustic SPL output; the @TxPower parameter range is scaled according to this parameter.
	    CFG_MODEM_ADDRGROUP                      = 25,    // Moves LocalAddr to another group
	    CFG_MODEM_APCNOISSEL                     = 26,
	    CFG_MODEM_APCALPHSM                      = 27,
	    CFG_MODEM_APCALPHSM2                     = 28,
	    CFG_MODEM_APCMAXTXP                      = 29,
	    CFG_MODEM_APCMINTXP                      = 30,
	    CFG_MODEM_ACKMODE_DONOTUSE               = 31,
	    CFG_NUM_MODEM_PARAMS                     = 32
	};


	/*
 Sect NETWORK
=============
 
 subsys=CFG_SECT_NETWORK

	*/
	public enum cfg_network_param_enum_t
	{
	    CFG_NETWORK_RTSATTMPTS                   = 0,    // Number or RTS Attempts
	    CFG_NETWORK_RESERVE1                     = 1,    // Formerly Data Retries
	    CFG_NETWORK_NUMBCSTPING                  = 2,    // Number of broadcast pings to try in a broadcast ping command.  1 - 255 (255 = ping indefinitely) 
	    CFG_NETWORK_PINGRETRY                    = 3,    // Number of ping retries if no response
	    CFG_NETWORK_PKTBUFF                      = 4,    // Packet buffering enable/disable
	    CFG_NETWORK_PKTDELAY                     = 5,    // Inter-packet delay, in seconds
	    CFG_NETWORK_FXDRSPTIME                   = 6,    // Fixed Acoustic response time for network packets
	    CFG_NETWORK_FXDRSPCTL                    = 7,    // Fixed response timer control enable/disable
	    CFG_NETWORK_MAXPINGRSP                   = 8,    // Maximum Ping Response (1-16)
	    CFG_NETWORK_UNUSED1                      = 9,
	    CFG_NETWORK_BRIEFLOWRATE                 = 10,    // Control use of 140 bps on handshakeless protocol retransmits 
	    CFG_NETWORK_BRIEFPKTSZ                   = 11,    // Packet size threshold for using handshakeless protocol
	    CFG_NETWORK_NSMA                         = 12,    // Neighbor Sense Multi-Access enable/disable
	    CFG_NETWORK_DATAACKS                     = 13,    // Data Acknowledgements Boolean
	    CFG_NETWORK_BRIEFACKS                    = 14,    // Acknowledgements Boolean for Brief Mode exchanges
	    CFG_NUM_NETWORK_PARAMS                   = 15
	};


	/*
 Sect TRANSPORT
===============
 
 subsys=CFG_SECT_TRANSPORT

	*/
	public enum cfg_transport_param_enum_t
	{
	    CFG_TRANSPORT_L4ENB                      = 0,    // Global enable or disable for transport layer activity
	    CFG_TRANSPORT_TPMODE                     = 1,    // Enable mode for transport layer addressing information (force always on or track with InputMode)
	    CFG_TRANSPORT_SRCP1                      = 2,    // Transport address to be applied to transmitted packets originating on UART 0
	    CFG_TRANSPORT_SRCP2                      = 3,    // Transport address to be applied to transmitted packets originating on UART 1
	    CFG_TRANSPORT_DST1                       = 16,    // Delivery destination for received packets tagged with transport address 1
	    CFG_TRANSPORT_DST2                       = 17,    // Delivery destination for received packets tagged with transport address 2
	    CFG_TRANSPORT_DST3                       = 18,    // Delivery destination for received packets tagged with transport address 3
	    CFG_TRANSPORT_DST4                       = 19    // Delivery destination for received packets tagged with transport address 4
	};


	/*
 Sect RELEASE
=============
 
 subsys=CFG_SECT_RELEASE

	*/
	public enum cfg_release_param_enum_t
	{
	    CFG_RELEASE_FSKRLSDUR                    = 0,    // Duration (seconds) to play Benthos FSK release tones
	    CFG_RELEASE_LSTCOMMSCNT                  = 1,    // Lost communication count (15 second increments)
	    CFG_RELEASE_RLSCODE                      = 2,    // Release code to trigger this release (valid on release models only)
	    CFG_RELEASE_UNUSED1                      = 3,
	    CFG_RELEASE_TIMEDRELEASE                 = 4,    // Timeout count for timed releases
	    CFG_RELEASE_MOTORTYPE                    = 5,    // Type of motor used in this release; only valid for releases which can support differing motor type
	    CFG_RELEASE_RLSMINENATIME                = 6,    // Minimum on time for Release Enable
	    CFG_RELEASE_RLSMAXENATIME                = 7,    // Maximum on time for Release Enable
	    CFG_RELEASE_ACOUTRIGTERM                 = 8,    // Terminating conditions for acoustic triggers
	    CFG_NUM_RELEASE_PARAMS                   = 9
	};


	/*
 Sect SERIAL
=============
 
 subsys=CFG_SECT_SERIAL

	*/
	public enum cfg_serial_param_enum_t
	{
	    CFG_SERIAL_P1BAUD                        = 0,    // Port 1 baud rate
	    CFG_SERIAL_P1ECHOCHAR                    = 1,    // Port 1 echo (full/half duplex)
	    CFG_SERIAL_P1FLOWCTL                     = 2,    // Port 1 flow control
	    CFG_SERIAL_P1IDLEPOL                     = 3,    // Port 1 idle polarity
	    CFG_SERIAL_P1PROTOCOL                    = 4,    // Port 1 comms protocol
	    CFG_SERIAL_P1STRIPB7                     = 5,    // Port 1 strip bit 7
	    CFG_SERIAL_P1NOSLEEP                     = 6,    // Port 1 not counted towards activity for sleep
	    CFG_SERIAL_P2BAUD                        = 7,    // Port 2 baud rate
	    CFG_SERIAL_P2ECHOCHAR                    = 8,    // Port 2 echo (full/half duplex)
	    CFG_SERIAL_P2FLOWCTL                     = 9,    // Port 2 flow control
	    CFG_SERIAL_P2IDLEPOL                     = 10,    // Port 2 idle polarity
	    CFG_SERIAL_P2STRIPB7                     = 11,    // Port 2 strip bit 7
	    CFG_SERIAL_P2NOSLEEP                     = 12,    // Port 2 not counted towards activity for sleep
	    CFG_SERIAL_P1MODE                        = 13,    // Port 1 cooking mode
	    CFG_SERIAL_P2MODE                        = 14,    // Port 2 cooking mode
	    CFG_SERIAL_P2PROTOCOL                    = 15,    // Port 2 on RS232 or CMOS
	    CFG_SERIAL_LPFLOWCTL                     = 16,    // allow RTS lines to be off on lowpower, follow HW flow control or remain on
	    CFG_SERIAL_P1PROMPT                      = 17,    // control prompt display level on Port 1
	    CFG_SERIAL_P2PROMPT                      = 18,    // control prompt display level on Port 2
	    CFG_NUM_SERIAL_PARAMS                    = 19
	};


	/*
 Sect SYSTEM
=============
 
 subsys=CFG_SECT_SYSTEM

	*/
	public enum cfg_system_param_enum_t
	{
	    CFG_SYSTEM_AUXINP                        = 0,    // Enable auxiliary acoustic input
	    CFG_SYSTEM_ASCIIBIN                      = 1,    // Received data output in standard ASCII or as a hex byte dump
	    CFG_SYSTEM_BANDWIDTH                     = 2,
	    CFG_SYSTEM_CARRFREQ                      = 3,    // Center carrier frequency (sets acoustic band)
	    CFG_SYSTEM_COMPMDMRST                    = 4,    // Compact modem reset: 
	    CFG_SYSTEM_CMWAKEHIB                     = 5,    // Compact modem wakeup hibernate time (formerly last digit of S-10 when >300)
	    CFG_SYSTEM_CMWAKELISTEN                  = 6,    // Compact modem wakeup active listen time (formerly middle digit of S-10 when >400)
	    CFG_SYSTEM_HALFBW                        = 7,    // Half bandwidth modulation: 1 = Normal, 2 = half bandwidth
	    CFG_SYSTEM_FHTHRESH                      = 8,    // Frequency Hop receive threshold
	    CFG_SYSTEM_RLSTYPE                       = 9,    // Configuration of release type (factory-set)
	    CFG_SYSTEM_SYNCPPS                       = 10,    // Mode for 1 PPS clock signal syncing
	    CFG_SYSTEM_VERBOSE                       = 11,    // console status verbosity
	    CFG_SYSTEM_WAKETHRESH                    = 12,
	    CFG_SYSTEM_AUXOUT                        = 13,    // Control behavior of auxiliary acoustic output: either default behavior (speaker/phones for UDB, copies of samples for others), or force copies of outbound samples to aux port.
	    CFG_SYSTEM_UNUSED1                       = 14,
	    CFG_SYSTEM_VOLCONT                       = 15,    // Use an analog linear pot on EXT_SENSE1_ADC to control speaker and headphone volume
	    CFG_SYSTEM_CMFASTWAKE                    = 16,    // Enables fast wake from hibernate ability on compact modem (receiving side) and UDB (sending side).
	    CFG_SYSTEM_NAMEFORMAT                    = 17,
	    CFG_SYSTEM_IDLETIMER                     = 18,    // Low-power idle timer
	    CFG_SYSTEM_PROMPT                        = 19,
	    CFG_SYSTEM_SYNCOUT                       = 20,    // copy RTC PPS out on BIN_OUT_0
	    CFG_SYSTEM_PULLUP0                       = 21,    // BIN_IN_0 pullup 
	    CFG_SYSTEM_PULLUP1                       = 22,    // BIN_IN_1 pullup
	    CFG_SYSTEM_MINOPVOLT                     = 23,    // The operating voltage threshold below which transmissions will be automatically reduced in power to prevent brown-out resets 
	    CFG_SYSTEM_BATTERYTYPE                   = 24,    // The type of battery being used to power the modem (Standard alkaline, Smart Li+, Lithium primary, etc.)
	    CFG_SYSTEM_BATTERYCAPACITY               = 25,    // The capacity of the installed battery pack in watt-hours.  Only for certain release products with battery monitoring capability.
	    CFG_SYSTEM_BATTERYMFGDATE                = 26,    // Manufacture date of the battery specifying month and year. Only for certain release products with battery monitoring capability.
	    CFG_SYSTEM_TILTAXIS                      = 27,    // The axis of the built-in accelerometer to be used as the tilt/pitch reference
	    CFG_SYSTEM_PWRONTIMER                    = 28,    // The Power On Timer used for Releases
	    CFG_SYSTEM_AWAKETIMER                    = 29,    // The Awake Timer used for Releases
	    CFG_SYSTEM_ARWAKEHIB                     = 30,    // The Acoustic Release Hibernate Sleep period
	    CFG_SYSTEM_RXSENS                        = 31,    // hydrophone sensitivity in dB (uPa) for reference only
	    CFG_SYSTEM_AWAKEPOWER                    = 32,    // keep TR board 12V and 3.3V on when in active receive
	    CFG_SYSTEM_TXSENS                        = 33,    // Transmt Voltage Response, SPL in dB(uPa) at 1m at full power
	    CFG_SYSTEM_TXINTERP                      = 34,    // Used for the Tx interpolation
	    CFG_SYSTEM_IOMODE0                       = 35,    // Set behavior of external IO expansion signal 0 (UCT only)
	    CFG_NUM_SYSTEM_PARAMS                    = 36
	};


	/*
 Sect TEST
=============
 
 subsys=CFG_SECT_TEST

	*/
	public enum cfg_test_param_enum_t
	{
	    CFG_TEST_DBGLVL                          = 0,    // Test debug level
	    CFG_TEST_RCVALL                          = 1,    // Receive all packets (sniffer mode)
	    CFG_TEST_RSPDELAY                        = 2,    // Test response delay
	    CFG_TEST_PKTECHO                         = 3,    // Test packet echo
	    CFG_TEST_PKTSIZE                         = 4,    // Test packet size
	    CFG_TEST_UNUSED1                         = 5,
	    CFG_TEST_SIMACDLY                        = 6,    // Simulated variable acoustic delay, in milliseconds
	    CFG_TEST_TXSATURATE                      = 7,    // Special test mode for enabling saturation on transmit
	    CFG_TEST_UNUSED2                         = 8,
	    CFG_NUM_TEST_PARAMS                      = 9
	};


	/*
 Sect VERSION
=============
 
 subsys=CFG_SECT_VERSION

	*/
	public enum cfg_version_param_enum_t
	{
	    CFG_VERSION_SWAPPNAME                    = 0,    // Software application name string
	    CFG_VERSION_SWVERSION                    = 1,    // Software version string
	    CFG_VERSION_DBVERSION                    = 2,    // Configuration database version string
	    CFG_NUM_VERSION_PARAMS                   = 3
	};


	/*
 Sect XPND
=============
 
 subsys=CFG_SECT_XPND

	*/
	public enum cfg_xpnd_param_enum_t
	{
	    CFG_XPND_RXFREQ                          = 0,    // Frequency to listen for response pings (applicable only to platforms without Multi-Rx capability)
	    CFG_XPND_RXLOCKOUT                       = 1,    // Ping response lockout, in milliseconds
	    CFG_XPND_RXTONEDUR                       = 2,    // Receive pulse width (enumerated: 0 = 12.5 ms, 1 = 6.25 ms, 5 = 5 ms ... 15 = 15 ms)
	    CFG_XPND_TAT                             = 3,    // Transpond turn-around time at remote node, in tenths of a millisecond
	    CFG_XPND_TXTONEDUR                       = 4,    // Interrogation pulse width (enumerated: 0 = 12.5 ms, 1 = 6.25 ms, 5 = 5 ms ... 15 = 15 ms)
	    CFG_XPND_RXTHRESH                        = 5,    // Receive detection threshold for transponder pings, in standard deviations above mean noise level
	    CFG_XPND_AGCREF                          = 6,    // The AGC level that should be set when the avg. background noise energy in the center of the band is at 1.  Lower values lower the noise floor allowing for more signal head-room; higher values raise it allowing more resolution for detecting weak signals.
	    CFG_XPND_RESPFREQ                        = 7,    // Response tone sent on reception of tone set by CFG_XPND_RXFREQ after delay of CFG_XPND_TAT.
	    CFG_XPND_LBLMODE                         = 8,    // Defines the action taken on the reception of a downward HFM chirp
	    CFG_XPND_XPNDEMUTAT                      = 9,    // Transponder emulator response turn-around time in tenths of a millisecond
	    CFG_XPND_XPNDEMUMODE                     = 10,    // Transponder emulator mode
	    CFG_XPND_HPR400CHAN                      = 11,    // Set the HPR400 channel
	    CFG_XPND_RESPONDER                       = 12,    // Enable Pulse responder mode
	    CFG_XPND_CHIRP_RESP                      = 13,    // Define response to be requested as a reply to at%rr command
	    CFG_XPND_BANDWIDTH                       = 14,    // Set bandwidth for processing
	    CFG_XPND_LOGRESULTS                      = 15,    // Enable logging to data logger
	    CFG_XPND_GAPSRX                          = 16,    // Gaps family C code to recieve
	    CFG_XPND_GAPSTX                          = 17,    // Gaps family C code to respond with
	    CFG_XPND_GAPSWAKE                        = 18,    // Gaps family C code to respond with
	    CFG_NUM_XPND_PARAMS                      = 19
	};


	/*
 Sect DAT
=============

 subsys=CFG_SECT_DAT

	*/
	public enum cfg_dat_param_enum_t
	{
	    CFG_DAT_PREGAIN                          = 0,    // gain for DAT channels relative to main, in dB
	    CFG_DAT_ROTATION                         = 1,    // offset of acoustic zero to vehicle center line
	    CFG_DAT_VERBOSE                          = 2,    // bits defining DAT report fields 
	    CFG_DAT_RXONDAT                          = 3,    // main receiver uses DAT hydrophone
	    CFG_DAT_WRAPRANGE                        = 4,    // for one way flight times of multiple seconds 
	    CFG_DAT_ORIENTATION                      = 5,    // transducer points up or down
	    CFG_DAT_PHASEA                           = 6,    // phase offset for reciever module A
	    CFG_DAT_PHASEB                           = 7,    // phase offset for reciever module B
	    CFG_DAT_PHASEC                           = 8,    // phase offset for reciever module C
	    CFG_DAT_PHASED                           = 9,    // phase offset for reciever module D
	    CFG_DAT_BEARINGRESP                      = 10,    // bearing response type
	    CFG_DAT_VTHRESH                          = 11,    // vector quality threshold
	    CFG_DAT_MIN_ELEV                         = 12,    // minimum acceptable elevation
	    CFG_DAT_MAX_ELEV                         = 13,    // maximum acceptable elevation
	    CFG_DAT_PHASEREF                         = 14,    // replica to use as reference for phase offset detection
	    CFG_DAT_ARRIVAL                          = 15,    // Special test mode DAT for first or peak arrival
	    CFG_NUM_DAT_PARAMS                       = 16
	};


	/*
 Sect USBL
=============

 subsys=CFG_SECT_USBL

	*/
	public enum cfg_usbl_param_enum_t
	{
	    CFG_USBL_FORMAT                          = 0,    // USBL bearing reporting format
	    CFG_USBL_DEPTH_QUERY                     = 1,    // enable to query depth on every USBL cycle
	    CFG_USBL_REPEAT_QUERY                    = 2,    // number of rapid range in every USBL cycle
	    CFG_USBL_AUTO_QUERY                      = 3,    // set to start acoustic of pulse cycles on boot
	    CFG_USBL_AUTO_DELAY                      = 4,    // delay between cycles in seconds
	    CFG_USBL_XDCER_DEPTH                     = 5,    // depth of USBL head below surface in tenths of a meter
	    CFG_NUM_USBL_PARAMS                      = 6
	};


	/*
 Sect NAV
=============
 
 subsys=CFG_SECT_NAV

	*/
	public enum cfg_nav_param_enum_t
	{
	    CFG_NAV_LATITUDE                         = 0,    // Latitude  in millionths of a degree
	    CFG_NAV_LONGITUDE                        = 1,    // Longitude in millionths of a degree
	    CFG_NAV_GPSALT                           = 2,    // absolute altitude relative to WGS84
	    CFG_NAV_ALTITUDE                         = 3,    // altitude above sea floor in meters
	    CFG_NAV_DEPTH                            = 4,    // depth below sea level in meters
	    CFG_NAV_COMPASS                          = 5,    // compass bearing in degrees
	    CFG_NAV_PITCH                            = 6,    // pitch in degrees
	    CFG_NAV_ROLL                             = 7,    // roll in degrees
	    CFG_NAV_CSOUND                           = 8,    // speed of sound in m/s
	    CFG_NAV_REPLY_DATA                       = 9,    // additional data fields for position information
	    CFG_NAV_HEADOFFSET                       = 10,    // offset of compass heading to vehicle center line
	    CFG_NAV_SYNCRANGING                      = 11,    // Enable one-way ranging on data transmissions when sychronized to external 1PPS sources
	    CFG_NAV_PITCHOFFSET                      = 12,    // offset of AHRS pitch to transducer plane
	    CFG_NAV_ROLLOFFSET                       = 13,    // offset of AHRS roll to transducer plane
	    CFG_NAV_GPSSYNCMSG                       = 14,    // The type of GPS sentence, if any, that may be used to adjust the modem's system clock
	    CFG_NUM_NAV_PARAMS                       = 15
	};


	/*
 Sect RECORDER
=============
 
 subsys=CFG_SECT_RECORDER

	*/
	public enum cfg_recorder_param_enum_t
	{
	    CFG_RECORDER_FRONTEND                    = 0,
	    CFG_RECORDER_RECMODE                     = 1,    // recording mode for automatic recording
	    CFG_RECORDER_RECFORMAT                   = 2,
	    CFG_RECORDER_NAMEFORMAT                  = 3,    // format of names for recorded audio files
	    CFG_RECORDER_RXSENS                      = 4,
	    CFG_NUM_RECORDER_PARAMS                  = 5
	};


	/*
 Sect AIN
=============
 
 subsys=CFG_SECT_AIN

	*/
	public enum cfg_ain_param_enum_t
	{
	    CFG_AIN_POLLRATE                         = 0,    // time interval for automated polling
	    CFG_AIN_1NMEAS                           = 1,    // number of measurements on chan 1
	    CFG_AIN_1STRTDLY                         = 2,    // delay in 1st reading after turn-on (ch1)
	    CFG_AIN_1RPTDLY                          = 3,    // delay in each additional reading (ch1)
	    CFG_AIN_1TYPE                            = 4,    // type of sensor on chan 1
	    CFG_AIN_2NMEAS                           = 5,    // number of measurements on chan 2
	    CFG_AIN_2STRTDLY                         = 6,    // delay in 1st reading after turn-on (ch2)
	    CFG_AIN_2RPTDLY                          = 7,    // delay in each additional reading (ch2)
	    CFG_AIN_2TYPE                            = 8,    // type of sensor on chan 2
	    CFG_AIN_3NMEAS                           = 9,    // number of measurements on chan 3
	    CFG_AIN_3STRTDLY                         = 10,    // delay in 1st reading after turn-on (ch3)
	    CFG_AIN_3RPTDLY                          = 11,    // delay in each additional reading (ch3)
	    CFG_AIN_4NMEAS                           = 12,    // number of measurements on chan 4
	    CFG_AIN_4STRTDLY                         = 13,    // delay in 1st reading after turn-on (ch4)
	    CFG_AIN_4RPTDLY                          = 14,    // delay in each additional reading (ch4)
	    CFG_AIN_5NMEAS                           = 15,    // number of measurements on chan 5
	    CFG_AIN_5STRTDLY                         = 16,    // delay in 1st reading after turn-on (ch5)
	    CFG_AIN_5RPTDLY                          = 17,    // delay in each additional reading (ch5)
	    CFG_AIN_6NMEAS                           = 18,    // number of measurements on chan 6
	    CFG_AIN_6STRTDLY                         = 19,    // delay in 1st reading after turn-on (ch6)
	    CFG_AIN_6RPTDLY                          = 20,    // delay in each additional reading (ch6)
	    CFG_NUM_AIN_PARAMS                       = 21
	};


	/*
 Sect PRESSURE
=============
 
 subsys=CFG_SECT_PRESSURE

	*/
	public enum cfg_pressure_param_enum_t
	{
	    CFG_PRESSURE_AINCHNL                     = 0,    // Analog input channel where the pressure transducer is connected, or 0 if none
	    CFG_PRESSURE_METERSPERPSI                = 1,    // Conversion factor for pressure, number of meters per psi
	    CFG_PRESSURE_ATMOFFSET                   = 2,    // Atmospheric pressure in PSI to be subtracted from pressure reading when converting to depth below sea level
	    CFG_PRESSURE_PSI                         = 3,    // The pressure in pounds per square inch (psi) as set by user or updated from pressure gauge
	    CFG_NUM_PRESSURE_PARAMS                  = 4
	};


	/*
 Sect JANUS
=============
 
 subsys=CFG_SECT_JANUS

	*/
	public enum cfg_janus_param_enum_t
	{
	    CFG_JANUS_CLASSUSERID                    = 0,    // DPSK board enable - control for the feature
	    CFG_JANUS_APPTYPE                        = 1,    // Logging of DPSK Data
	    CFG_JANUS_MACTHRESH                      = 2,    // DPSK Acoustic Ouput Format
	    CFG_NUM_JANUS_PARAMS                     = 3
	};


	/*
 Account privilege levels
  system=constant

	*/
	public enum cmd_privlev_t
	{
	    CMD_PRIVLEV_SAFE                         = 0,
	    CMD_PRIVLEV_USER                         = 1,
	    CMD_PRIVLEV_UPDATE                       = 2,
	    CMD_PRIVLEV_FACTORY                      = 3,
	    CMD_PRIVLEV_DIAG                         = 4,
	    CMD_PRIVLEV_SYS                          = 6,
	    CMD_PRIVLEV_ROOT                         = 7,
	    NUM_CMD_PRIVLEVS                         = 8
	};


	/*
 
 subfield=mmp_binio_t::value

	*/
	public enum enable_t
	{
	    DISABLE                                  = 0,    // Disabled, off, low, etc.
	    ENABLE                                   = 1    // Enabled, on, high, etc.
	};


	/*
 

	*/
	public enum modem_feature_t
	{
	    FEAT_MODEM_DATA                          = 0,    // Transmit and receive data packets with other modems
	    FEAT_MULTI_XPND_RX                       = 1,    // Simultaneous receive of transpond pings on more than one frequency
	    FEAT_DAT_BEARING                         = 2,    // Bearing calculations use Directional Acoustic Transponder
	    FEAT_WAVE_PLAY                           = 3,    // User ability to use the 'play' and 'tone' commands for custom waveform transmission
	    FEAT_DUAL_UART                           = 4,    // Enable dual serial port mode for transmitting acoustic packets and logging data
	    FEAT_INBAND_RECORD                       = 5,    // Enable in band acoustic recording to SD card
	    FEAT_LOW_OUTPUT_PWR                      = 9,    // enable a(n approximate) -24dB attenuation to be switched in that shifts the entire @TxPower range
	    FEAT_UTS_GNSS_SUPPORT                    = 10,    // enable external GNSS functionality on UTS platforms that can support it
	    FEAT_GAPS_EMULATION                      = 11,    // enable ability to act as a GAPS transponder
	    NUM_FEATS                                = 12
	};


	/*
 
 subfield=mmp_data_feat_key_status_t::available_features
 subfield=mmp_data_feat_key_status_t::expected_features
 subfield=mmp_data_feat_key_status_t::enabled_features
 subfield=mmp_data_feat_key_status_t::unauthorized_features

	*/
	public enum modem_feature_bitflag_t
	{
	    FEAT_FLAG_MODEM_DATA                     = 0x01,    // Bit flag for Modem Data feature
	    FEAT_FLAG_MULTI_XPND_RX                  = 0x02,    // Bit flag for multi ping transpond receive feature
	    FEAT_FLAG_DAT_BEARING                    = 0x04,    // Bit flag for DAT Bearing feature
	    FEAT_FLAG_WAVE_PLAY                      = 0x08,    // Bit flag for arbitrary waveform play feature
	    FEAT_FLAG_DUAL_UART                      = 0x10,    // Bit flag for dual serial port input feature
	    FEAT_FLAG_INBAND_RECORD                  = 0x20,    // Bit flag for inband recorder feature
	    FEAT_FLAG_LOW_OUTPUT_PWR                 = 0x200,    // Bit flag for enabling -24 dB attenuation mode on transmit
	    FEAT_FLAG_UTS_GNSS_SUPPORT               = 0x400,    // Bit flag for enabling external GNSS devices on the UTS platforms that can support it
	    FEAT_FLAG_GAPS_EMULATION                 = 0x800    // Bit flag for enabling GAPS emulation
	};


	/*
 
 subfield=mmp_datalog_dump_t::source
 subfield=mmp_datalog_cmdresult_dump_t::source
 subfield=mmp_datalog_cmdresult_source_counts_t::source
 subfield=mmp_datalog_remote_getdlogblk_t::source

	*/
	public enum datalog_source_t
	{
	    DLOG_SRC_P1                              = 0,    // Serial port 1
	    DLOG_SRC_P2                              = 1,    // Serial port 2
	    DLOG_SRC_RES1                            = 2,
	    DLOG_SRC_RES2                            = 3,
	    DLOG_SRC_AC                              = 4,    // Acoustic transmission data
	    DLOG_SRC_XP                              = 5,    // Transponder data
	    DLOG_SRC_DI                              = 6,    // Diagnostic data
	    DLOG_SRC_MMP                             = 7,    // Data inserted via MMP message
	    DLOG_SRC_DEV                             = 8,    // Data inserted via /dev/logger system device
	    DLOG_SRC_AIN                             = 9,    // Data from analog input
	    DLOG_NUM_SRCS                            = 10,
	    DLOG_SRC_ALL                             = 0xFF    // Sentinel for any/all sources
	};


	/*
 Datalogger source flags, for use in some MMP messages and function calls.  Each flag corresponds to (1 << enum_equivalent)
 
 subfield=mmp_datalog_srcinfo_t::source_flags
 subfield=mmp_datalog_cmdresult_list_t::source_flags
 subfield=mmp_datalog_cmdresult_srcinfo_t::source_flags
 subfield=mmp_datalog_cmdresult_find_t::source_flags

	*/
	public enum datalog_source_flag_t
	{
	    DLOG_SRCFLAG_P1                          = 0x01,    // Bit flag for Serial port 1
	    DLOG_SRCFLAG_P2                          = 0x02,    // Bit flag for Serial port 2
	    DLOG_SRCFLAG_AC                          = 0x10,    // Bit flag for Acoustic packets
	    DLOG_SRCFLAG_XP                          = 0x20,    // Bit flag for Transponder activity
	    DLOG_SRCFLAG_DI                          = 0x40,    // Bit flag for Diagnostic information (internally generated)
	    DLOG_SRCFLAG_MMP                         = 0x80,    // Bit flag for Data inserted via MMP directive
	    DLOG_SRCFLAG_DEV                         = 0x100,    // Bit flag for Data inserted via the /dev/logger interface
	    DLOG_SRCFLAG_AIN                         = 0x200,    // Bit flag for Data from the analog input
	    DLOG_SRCFLAG_TRUNC                       = 0x2000,    // Bit flag indicating this record was truncated
	    DLOG_SRCFLAG_RECOV                       = 0x4000    // Bit flag indicating this record was recovered at boot
	};


	/*
 
 subfield=mmp_datalog_cmdresult_list_t::storeloc
 subfield=mmp_datalog_cmdresult_srcinfo_t::storeloc

	*/
	public enum datalog_store_t
	{
	    DLOG_STORE_INTERNAL                      = 0,    // On-board flash memory
	    DLOG_STORE_SDHC                          = 1    // External SDHC card
	};


	/*
 
 subfield=mmp_axis_tilt_response_t::axis_w_pol

	*/
	public enum tilt_axis_and_polarity_t
	{
	    TILT_AP_XPOS                             = 0,    // X axis, positive polarity
	    TILT_AP_XNEG                             = 1,    // X axis, negative polarity
	    TILT_AP_YPOS                             = 2,    // Y axis, positive polarity
	    TILT_AP_YNEG                             = 3,    // Y axis, negative polarity
	    TILT_AP_ZPOS                             = 4,    // Z axis, positive polarity
	    TILT_AP_ZNEG                             = 5    // Z axis, negative polarity
	};


	/*
 
 subfield=mmp_data_nav_status_t::location
 subfield=mmp_data_nav_status_t::heading
 subfield=mmp_data_nav_status_t::attitude

	*/
	public enum nav_validity_t
	{
	    NAV_NOT_VALID                            = 0,    // data from stored values
	    NAV_INT_VALID                            = 1,    // data from internal source
	    NAV_EXT_VALID                            = 2    // data from external source
	};


	/*
 JANUS Class IDs
 
 subfield=mmp_data_janus_packet_t::class_userid

	*/
	public enum JANUS_classid_t
	{
	    JANUS_CLASSID_EMERGENCY                  = 0,
	    JANUS_CLASSID_UWGPS                      = 1,
	    JANUS_CLASSID_UWAIS                      = 2,
	    JANUS_CLASSID_PINGER                     = 3,
	    JANUS_CLASSID_FIXEDVMOORING              = 4,
	    JANUS_CLASSID_RIGIDVSTRUCTURE            = 5,
	    JANUS_CLASSID_HAZARDMARKER               = 6,
	    JANUS_CLASSID_CHANNELMARKER              = 7,
	    JANUS_CLASSID_WINDGENERATOR              = 8,
	    JANUS_CLASSID_WAVEGENERATOR              = 9,
	    JANUS_CLASSID_SOLARGENERATOR             = 10,
	    JANUS_CLASSID_CAPABILITIES               = 15,
	    JANUS_CLASSID_NATOREF                    = 16,
	    JANUS_CLASSID_VENILIA                    = 17,
	    JANUS_CLASSID_CC_MONGOLIA                = 187,
	    JANUS_CLASSID_CC_NEWZEALAND              = 188,
	    JANUS_CLASSID_CC_REPUBLICOFKOREA         = 189,
	    JANUS_CLASSID_CC_PAKISTAN                = 190,
	    JANUS_CLASSID_CC_JAPAN                   = 191,
	    JANUS_CLASSID_CC_IRAQ                    = 192,
	    JANUS_CLASSID_CC_AUSTRALIA               = 193,
	    JANUS_CLASSID_CC_AFGHANISTAN             = 194,
	    JANUS_CLASSID_CC_UNITEDARABEMIRATES      = 195,
	    JANUS_CLASSID_CC_KUWAIT                  = 196,
	    JANUS_CLASSID_CC_QATAR                   = 197,
	    JANUS_CLASSID_CC_BAHRAIN                 = 198,
	    JANUS_CLASSID_CC_TUNISIA                 = 199,
	    JANUS_CLASSID_CC_MOROCCO                 = 200,
	    JANUS_CLASSID_CC_MAURITANIA              = 201,
	    JANUS_CLASSID_CC_JORDAN                  = 202,
	    JANUS_CLASSID_CC_ISRAEL                  = 203,
	    JANUS_CLASSID_CC_EGYPT                   = 204,
	    JANUS_CLASSID_CC_ALGERIA                 = 205,
	    JANUS_CLASSID_CC_UZBEKISTAN              = 206,
	    JANUS_CLASSID_CC_UKRAINE                 = 207,
	    JANUS_CLASSID_CC_TURKMENISTAN            = 208,
	    JANUS_CLASSID_CC_MACEDONIA               = 209,
	    JANUS_CLASSID_CC_TAJIKISTAN              = 210,
	    JANUS_CLASSID_CC_SWITZERLAND             = 211,
	    JANUS_CLASSID_CC_SWEDEN                  = 212,
	    JANUS_CLASSID_CC_SERBIA                  = 213,
	    JANUS_CLASSID_CC_MONTENEGRO              = 214,
	    JANUS_CLASSID_CC_MOLDOVA                 = 215,
	    JANUS_CLASSID_CC_MALTA                   = 216,
	    JANUS_CLASSID_CC_KYRGYZREPUBLIC          = 217,
	    JANUS_CLASSID_CC_KAZAKHSTAN              = 218,
	    JANUS_CLASSID_CC_IRELAND                 = 219,
	    JANUS_CLASSID_CC_GEORGIA                 = 220,
	    JANUS_CLASSID_CC_FINLAND                 = 221,
	    JANUS_CLASSID_CC_BOSNIAHERZEGOVINA       = 222,
	    JANUS_CLASSID_CC_BELARUS                 = 223,
	    JANUS_CLASSID_CC_AZERBAIJAN              = 224,
	    JANUS_CLASSID_CC_AUSTRIA                 = 225,
	    JANUS_CLASSID_CC_ARMENIA                 = 226,
	    JANUS_CLASSID_CC_UNITEDSTATES            = 227,
	    JANUS_CLASSID_CC_UNITEDKINGDOM           = 228,
	    JANUS_CLASSID_CC_TURKEY                  = 229,
	    JANUS_CLASSID_CC_SPAIN                   = 230,
	    JANUS_CLASSID_CC_SLOVENIA                = 231,
	    JANUS_CLASSID_CC_SLOVAKIA                = 232,
	    JANUS_CLASSID_CC_ROMANIA                 = 233,
	    JANUS_CLASSID_CC_PORTUGAL                = 234,
	    JANUS_CLASSID_CC_POLAND                  = 235,
	    JANUS_CLASSID_CC_NORWAY                  = 236,
	    JANUS_CLASSID_CC_NETHERLANDS             = 237,
	    JANUS_CLASSID_CC_LUXEMBOURG              = 238,
	    JANUS_CLASSID_CC_LITHUANIA               = 239,
	    JANUS_CLASSID_CC_LATVIA                  = 240,
	    JANUS_CLASSID_CC_ITALY                   = 241,
	    JANUS_CLASSID_CC_ICELAND                 = 242,
	    JANUS_CLASSID_CC_HUNGARY                 = 243,
	    JANUS_CLASSID_CC_GREECE                  = 244,
	    JANUS_CLASSID_CC_GERMANY                 = 245,
	    JANUS_CLASSID_CC_FRANCE                  = 246,
	    JANUS_CLASSID_CC_ESTONIA                 = 247,
	    JANUS_CLASSID_CC_DENMARK                 = 248,
	    JANUS_CLASSID_CC_CZECHREPUBLIC           = 249,
	    JANUS_CLASSID_CC_CROATIA                 = 250,
	    JANUS_CLASSID_CC_CANADA                  = 251,
	    JANUS_CLASSID_CC_BULGARIA                = 252,
	    JANUS_CLASSID_CC_BELGIUM                 = 253,
	    JANUS_CLASSID_CC_ALBANIA                 = 254,
	    JANUS_CLASSID_JANUSSPECIAL               = 255,
	    JANUS_NUM_CLASSIDS                       = 256
	};


	/*
 
 subfield=mmp_data_lowpower_t::waketype

	*/
	public enum wake_type_t
	{
	    WAKE_TYPE_NULL                           = 0,    // No wakeup
	    WAKE_TYPE_UART                           = 1,    // Wake up from UART input
	    WAKE_TYPE_TIME                           = 2,    // Wake up due to expiry of pre-set timer
	    WAKE_TYPE_ACOU                           = 3,    // Wake up due to acoustic wake tones
	    WAKE_TYPE_ALARM                          = 4,    // Wake up due RTC alarm
	    WAKE_TYPE_BATTLIFE                       = 5,    // Wake up to update battery life monitoring
	    WAKE_TYPE_NO_SLEEP                       = 6    // Sleep mode not defined - did not sleep
	};


	/*
*************************
 DATALOG Commands
*************************
 
 cmdsect=DATALOG

	*/
	public enum mmp_datalog_cmd_t
	{
	    MMP_DATALOG_CMD_CLEAR                    = 0x00,    // Clears the data logger buffer
	    MMP_DATALOG_CMD_SIZE                     = 0x01,    // Report the number of bytes in the data logger
	    MMP_DATALOG_CMD_READ_DATA                = 0x02,    // Read back the data logger buffer
	    MMP_DATALOG_CMD_READ_PAGE                = 0x03,    // Read back a 4 kbyte page
	    MMP_DATALOG_CMD_READ_SECTOR              = 0x04,    // Read back a 256 byte sector
	    MMP_DATALOG_CMD_WRITE_DATA               = 0x05,    // Write data in to the data logger
	    MMP_DATALOG_CMD_SEEK                     = 0x06,    // Set the read pointer to a specific location
	    MMP_DATALOG_CMD_TELL                     = 0x07,    // Report the position of the read pointer
	    MMP_DATALOG_CMD_LIST                     = 0x08,    // Retrieve general information about the local or remote data logger
	    MMP_DATALOG_CMD_FIND                     = 0x09,    // Find records in the local or remote data logger using the command line query syntax
	    MMP_DATALOG_CMD_DUMP                     = 0x0A,    // Dump the local or remote data logger based on byte offset and length (on all-source or per-source basis)
	    MMP_DATALOG_CMD_SRCINFO                  = 0x0B,    // Get information pertaining to one or more data sources in the logger (total bytes and number of records)
	    MMP_DATALOG_CMD_REMOTE_GETDLOGBLK        = 0x0C,    // Request a block of up to 4K from a remote modem's data logger with bit flags indicating which cells are valid/corrupted
	    MMP_NUM_DATALOG_CMD                      = 0x0D
	};


	/*
 
 subfield=mmp_datalog_cmdresult_write_data_t::status

	*/
	public enum mmp_datalog_cmdresult_write_data_status_t
	{
	    MMP_DATALOG_WRITE_ERR_DISABLED           = -4,    // Data logger writes disabled due to incompatible file schema in flash
	    MMP_DATALOG_WRITE_FILE_ERROR             = -3,    // Error trying to open/delete/access a file
	    MMP_DATALOG_WRITE_ERR_DATALOG_FULL       = -2,    // No more room left in data logger
	    MMP_DATALOG_WRITE_ERR_STORE_TO_FLASH     = -1,    // Unable to store to flash	
	    MMP_DATALOG_WRITE_SUCCESSFUL             = 0    // A successful write
	};


	/*
*************************
 RNGRLS Commands
*************************
 
 cmdsect=RNGRLS

	*/
	public enum mmp_rngrls_cmd_t
	{
	    MMP_RNGRLS_CMD_TRANSPOND                 = 0x00,    // Issue interrogation or silent ping and enter transpond receive mode for the system default amount of time
	    MMP_RNGRLS_CMD_RANGE                     = 0x01,    // Obtain the range to another modem
	    MMP_RNGRLS_CMD_RELEASE_STATUS            = 0x02,    // Check the release mechanism status on a remote modem
	    MMP_RNGRLS_CMD_SMART_RELEASE             = 0x03,    // Issue a release command to a remote Benthos SMART release (SR-50, SR-100, etc.)
	    MMP_RNGRLS_CMD_BURNWIRE                  = 0x04,    // Issue a release command to a remote Benthos SMART modem (SM-75, OEM boardset w/ burn wire, etc.)
	    MMP_RNGRLS_CMD_FSK_RELEASE               = 0x05,    // Issue a release command to a remote Benthos FSK release (Model 865, etc.)
	    MMP_RNGRLS_CMD_EDGETECH_RELEASE          = 0x06,    // Issue a command to an EdgeTech/ORE/EG&G release
	    MMP_RNGRLS_CMD_URI_RELEASE               = 0x07,    // Issue a command to a University of Rhode Island release/device 
	    MMP_RNGRLS_CMD_FLASH_XPNDADJ             = 0x08,    // Save per-frequency transpond sensitivity threshold adjustments to flash
	    MMP_RNGRLS_CMD_BEARING                   = 0x09,    // Obtain bearing from a DAT
	    MMP_RNGRLS_CMD_GEOPRO_RELEASE            = 0x0A,    // Issue a command to a GeoPro (Germany) release unit
	    MMP_RNGRLS_CMD_NAVDATA                   = 0x0B,    // Obtain position information from a remote modem
	    MMP_RNGRLS_CMD_CHANNEL_PROBE             = 0x0C,    // probe channel for multipath
	    MMP_RNGRLS_CMD_RSERIES_RANGE             = 0x0D,    // Ranging specific to a Teledyne Benthos next-gen release
	    MMP_RNGRLS_CMD_RSERIES_ACTIVATE          = 0x0E,    // Activate an R Series release
	    MMP_RNGRLS_CMD_RSERIES_HIBERNATE         = 0x0F,    // Hibernate an R Series release
	    MMP_RNGRLS_CMD_RSERIES_XPND_MODE         = 0x10,    // Set the transpond reSponse mode in a remote R Series unit
	    MMP_RNGRLS_CMD_STD_XPND_MODE             = 0x11,    // Set the transpond reSponse mode in a remote standard unit
	    MMP_RNGRLS_CMD_RSERIES_DB_UNLOCK         = 0x12,    // Enable R Series transponding
	    MMP_RNGRLS_CMD_RSERIES_DB_LOCK           = 0x13,    // Disable R Series transponding
	    MMP_RNGRLS_CMD_RSERIES_RELEASE           = 0x14,    // Issue a release command to a remote Benthos R Series release
	    MMP_RNGRLS_CMD_RESPONDER_RANGE           = 0x15,    // Issue pulse on binary out 1 to a responder
	    MMP_RNGRLS_CMD_TRANSPOND_W_TIMEOUT       = 0x16,    // Issue interrogation or silent ping and enter transpond receive mode for a specified amount of time
	    MMP_RNGRLS_CMD_RANGE_W_TIMEOUT           = 0x17,    // Issue a range request with a timeout specified (not system @AcRspTmOut default)
	    MMP_RNGRLS_CMD_SPECTRUM_MODE             = 0x18,    // Enter or exit spectrum analysis mode, with update rate in 0.5 second increments (or 0 to disable)
	    MMP_RNGRLS_CMD_RANGE_USBL_REPEAT         = 0x19,    // (DAT ONLY) Issue a range request for a define number of responses
	    MMP_RNGRLS_CMD_ABSREL                    = 0x1A,    // Request the high precision absolute and relative bearing
	    MMP_RNGRLS_CMD_ACOU_SAMPLE               = 0x1D,    // Record a 1 second basebanded in-band acoustic sample
	    MMP_RNGRLS_CMD_ABSCMPDEP                 = 0x1E,    // Request the high precision compass and depth
	    MMP_RNGRLS_CMD_ACOUSTIC_TRIGGER          = 0x1F,    // Send a trigger code to a remote device to activate the acoustic trigger signal
	    MMP_RNGRLS_CMD_BEARING_W_TIMEOUT         = 0x20,    // Obtain bearing from a DAT with a timeout specified (not system @AcRspTmOut default)
	    MMP_NUM_RNGRLS_CMD                       = 0x21
	};


	/*
 
 subfield=mmp_rngrls_bearing_t::type
 subfield=mmp_rngrls_navdata_t::type

	*/
	public enum mmp_rngrls_bearing_type_t
	{
	    MMP_RNGRLS_BEARING_ABS                   = 0,    // relative to North
	    MMP_RNGRLS_BEARING_REL                   = 1,    // relative to DAT body
	    MMP_RNGRLS_BEARING_COM                   = 2,    // compass heading
	    MMP_RNGRLS_BEARING_TLT                   = 3,    // tilt sensors
	    MMP_RNGRLS_BEARING_HIGH_ABS              = 4,    // absolute bearing
	    MMP_RNGRLS_BEARING_HIGH_INC              = 5,    // absolute inclination
	    MMP_RNGRLS_BEARING_HIGH_REL              = 6,    // relative bearing
	    MMP_RNGRLS_BEARING_HIGH_ELV              = 7,    // relative elevation
	    MMP_RNGRLS_BEARING_HIGH_COM              = 8,    // compass heading
	    MMP_RNGRLS_BEARING_HIGH_PCH              = 9,    // compass pitch
	    MMP_RNGRLS_BEARING_HIGH_RLL              = 10,    // compass roll
	    MMP_RNGRLS_BEARING_DEPTH                 = 11,    // depth from pressure transducer
	    MMP_RNGRLS_BEARING_PROBE                 = 13,    // remote channel probe request
	    MMP_RNGRLS_BEARING_HOMING                = 14,    // start of terminal homing mode
	    MMP_RNGRLS_BEARING_RANGE_ONLY            = 15,    // Range only response
	    MMP_RNGRLS_BEARING_W_REPLYDATA           = 32    // Add to bearing types to request reply data
	};


	/*
 
 subfield=mmp_rngrls_bearing_t::tat

	*/
	public enum mmp_rngrls_bearing_tat_t
	{
	    MMP_RNGRLS_TAT_SLOW                      = 0,    // legacy (slow) 2.4 second turn around
	    MMP_RNGRLS_TAT_FAST                      = 1,    // standard (fast) 1.6 second turn around
	    MMP_RNGRLS_TAT_VFAST                     = 2    // very fast 1.1 second turn around
	};


	/*
 
 subfield=mmp_rngrls_fsk_param_t::code

	*/
	public enum mmp_rngrls_fsk_code_t
	{
	    MMP_RNGRLS_FSK_CODE_A                    = 'A',    // ASCII A - 0x65
	    MMP_RNGRLS_FSK_CODE_B                    = 'B',    // ASCII B - 0x66
	    MMP_RNGRLS_FSK_CODE_C                    = 'C',    // ASCII C - 0x67
	    MMP_RNGRLS_FSK_CODE_D                    = 'D',    // ASCII D - 0x68
	    MMP_RNGRLS_FSK_CODE_E                    = 'E',    // ASCII E - 0x69
	    MMP_RNGRLS_FSK_CODE_F                    = 'F',    // ASCII F - 0x6A
	    MMP_RNGRLS_FSK_CODE_G                    = 'G',    // ASCII G - 0x6B
	    MMP_RNGRLS_FSK_CODE_H                    = 'H',    // ASCII H - 0x6C
	    MMP_RNGRLS_FSK_CODE_I                    = 'I',    // ASCII I - 0x6D
	    MMP_RNGRLS_FSK_CODE_J                    = 'J',    // ASCII J - 0x6E
	    MMP_RNGRLS_FSK_CODE_K                    = 'K',    // ASCII K - 0x6F
	    MMP_RNGRLS_FSK_CODE_L                    = 'L',    // ASCII L - 0x70
	    MMP_RNGRLS_FSK_CODE_M                    = 'M'    // ASCII M - 0x71
	};


	/*
 
 subfield=mmp_rngrls_channel_probe_param_t::log

	*/
	public enum mmp_rngrls_probe_log_t
	{
	    MMP_RNGRLS_PROBE_LOG_NONE                = 0,    // no logging
	    MMP_RNGRLS_PROBE_LOG_STAT                = 1,    // log only statistics
	    MMP_RNGRLS_PROBE_LOG_STAT_IMPULSE        = 2    // log statistics and impulse
	};


	/*
 
 subfield=mmp_rngrls_cmdresult_navdata_t::type
*************************

	*/
	public enum navdata_type_t
	{
	    MMP_REPLY_DATA_NONE                      = 0,    // no data replied
	    MMP_REPLY_DATA_LATLONG                   = 1,    // latitude and longitude 
	    MMP_REPLY_DATA_LL_DEPTH                  = 2,    // lat, long and depth
	    MMP_REPLY_DATA_LL_SEAFLOOR               = 3,    // lat, long, depth and altitude above sea floor
	    MMP_REPLY_DATA_LL_GPSALT                 = 4,    // lat, long, depth and altitude above sea level
	    NUM_NAVDATA_TYPES                        = 5
	};


	/*
 
 subfield=mmp_rngrls_edgetech_param_t::freq_spec
*************************

	*/
	public enum edgetech_freqspec_t
	{
	    EDGETECH_9500_9900                       = 1,    // 9500 Hz off, 9900 Hz on
	    EDGETECH_9500_10300                      = 2,    // 9500 Hz off, 10300 Hz on
	    EDGETECH_9500_10700                      = 3,    // 9500 Hz off, 10700 Hz on
	    EDGETECH_9900_10300                      = 4,    // 9900 Hz off, 10300 Hz on
	    EDGETECH_9900_10700                      = 5,    // 9900 Hz off, 10700 Hz on
	    EDGETECH_10300_10700                     = 6,    // 10300 Hz off, 10700 Hz on
	    NUM_EDGETECH_FREQSPECS                   = 7
	};


	/*
*************************
 STD Commands
*************************
 Do not remove MMP_STD_CMD_RESET or updates from deck box displays may stop working
 
 cmdsect=STD

	*/
	public enum mmp_std_cmd_t
	{
	    MMP_STD_CMD_INFO                         = 0x00,    // Obtain modem build info (similar to ATI shell command)
	    MMP_STD_CMD_REMOTE_MMPREQ                = 0x01,    // Initiate an acoustic MMP request to another modem.  Remote MMP request should be embedded in the data field (no @ sentinel needed). Not implemented on networking builds.
	    MMP_STD_CMD_FLASH_SREGS                  = 0x02,    // Save S-registers to flash (soon to be deprecated)
	    MMP_STD_CMD_RESET_SREGS                  = 0x03,    // Reset S-registers to factory defaults (soon to be deprecated)
	    MMP_STD_CMD_REMOTE_SETACOUBAUD           = 0x04,    // Set acoustic baud rate on remote modem
	    MMP_STD_CMD_REMOTE_SETTXPOWER            = 0x05,    // Set transmit power on remote modem
	    MMP_STD_CMD_REMOTE_GETSREGS              = 0x06,    // Get S-registers from remote modem (soon to be deprecated)
	    MMP_STD_CMD_REMOTE_SENDDATA              = 0x07,    // Send data packet to remote modem
	    MMP_STD_CMD_REMOTE_TESTLINK              = 0x08,    // Test acoustic link with remote modem
	    MMP_STD_CMD_UPDATE_FIRMWARE              = 0x09,    // Begin firmware update cycle
	    MMP_STD_CMD_RESET                        = 0x0A,    // Reboot the modem
	    MMP_STD_CMD_REMOTE_GETBATT               = 0x0B,    // Get battery levels on remote modem
	    MMP_STD_CMD_REMOTE_CMWAKEUP              = 0x0C,    // Issue a compact modem wakeup sequence to a remote compact modem
	    MMP_STD_CMD_REMOTE_GETAGCHIST            = 0x0D,    // Obtain the AGC history for the last 10 seconds from a remote modem
	    MMP_STD_CMD_REMOTE_AUTOBAUD              = 0x0E,    // Initiate an auto-baud sequence to a remote modem to set an optimal acoustic baud rate between them
	    MMP_STD_CMD_REMOTE_GETBATTCHG            = 0x0F,    // Obtain battery charge from remote units with IBPS smart batteries
	    MMP_STD_CMD_REMOTE_SENDCMD               = 0x10,    // Send command packet to remote modem
	    MMP_STD_CMD_TILT_ACCEL                   = 0x11,    // Obtain acceleration and tilt values for X/Y/Z axis if function supported on board.  HW_NOT_PRESENT error results if board has no accelerometer. 
	    MMP_STD_CMD_AXIS_TILT                    = 0x12,    // Obtain overall unit tilt value based upon @TiltAxis configuration parameter.  HW_NOT_PRESENT error results if board has no accelerometer. 
	    MMP_STD_CMD_RESET_BATT_METERING          = 0x13,    // Reset the battery metering information on this platform, if applicable.
	    MMP_STD_CMD_BATT_METER                   = 0x14,    // Obtain metering information for the local battery, if supported
	    MMP_STD_CMD_REMOTE_GETMETER              = 0x15,    // Get battery metering information from a remote unit, if supported
	    MMP_STD_CMD_GETBATT                      = 0x16,    // Get battery levels from the local modem
	    MMP_STD_CMD_GETBATTCHG                   = 0x17,    // Obtain battery charge from a local modem with IBPS smart batteries
	    MMP_STD_CMD_GETAGCHIST                   = 0x18,    // Get the local AGC history buffer
	    MMP_STD_CMD_REMOTE_GETONESREG            = 0x19,    // Gets the value of a single S-register on a remote modem
	    MMP_STD_CMD_REMOTE_SETONESREG            = 0x1A,    // Sets and stores a single S-register on a remote modem; response is ACK or ERROR
	    MMP_STD_CMD_REMOTE_RESET                 = 0x1B,    // Reset a remote modem with a low-level reset instruction (no acknowledgement from remote)
	    MMP_STD_CMD_BOARD_TEMP                   = 0x1C,    // Obtain the board temperature from one of the built-in thermistors (one on ATM board sets, two on UDB board sets)
	    MMP_STD_CMD_REMOTE_SENDBREAK             = 0x1D,    // Send a serial break to remote modem
	    MMP_STD_CMD_CONT_XMIT_TEST               = 0x1E,
	    MMP_STD_CMD_SET_REMOTE_GROUP             = 0x1F,    // move a remote modem's address into a new address group
	    MMP_STD_CMD_GETSMARTBATTDATA             = 0x20,    // If smart batteries are supported, get selected parameters from the specified battery.
	    MMP_STD_CMD_ADDFEATUREKEY                = 0x21,    // Add a feature key to the platform.  CMDRESULT ACK on success, CMDRESULT ERROR if flash store full, BAD_CMDARGS error otherwsise.
	    MMP_STD_CMD_DELFEATUREKEY                = 0x22,    // Delete a feature key from the platform.  CMDRESULT ACK on success, BAD_CMDARGS error otherwise.
	    MMP_STD_CMD_REMOTE_HANGUP                = 0x23,    // Send an acoustic "hangup" to a remote node that takes it out of online mode and puts it to sleep/hibernate.  ACK/timeout when sending to individual node, or immediate ACK if sending to a multi-cast address with no acoustic ACK expected.
	    MMP_STD_CMD_SENDJANUSPACKET              = 0x24,    // Transmit a JANUS packet with pre-encoded ADB and cargo.  CMDRESULT ACK on success, CMDRESULT ERR on failure to validate, or general MMP error otherwise.
	    MMP_STD_CMD_WRITE_DEVICE                 = 0x25,    // Write to the device
	    MMP_STD_CMD_READ_DEVICE                  = 0x26,    // Read and clear the device
	    MMP_STD_CMD_LEN_DEVICE                   = 0x27,    // Length of data in the device
	    MMP_STD_CMD_FIND_DEVICE                  = 0x28,    // Find the device number from the name
	    MMP_NUM_STD_CMD                          = 0x29
	};


	/*
 
 subfield=mmp_remote_request_t::flags

	*/
	public enum mmp_remote_request_flag_t
	{
	    REMOTE_MMP_FLAG_ACKONLY                  = 0x01    // REMOTE_MMPREQ ONLY: requests a simple ACK/NACK from the remote instead of a fully-formed MMP response
	};


	/*
 This enumeration supplements the txpower_t enumeration for the remote_txpwr parameter in mmp_remote_testmsgstats_t
 
 subfield=mmp_remote_testmsgstats_t::remote_txpwr

	*/
	public enum mmp_remote_testmsgstats_txpwr_t
	{
	    TXPOWER_UNAVAIL                          = 0x7FFF,    // No power level available
	    TXPOWER_REDUCED_0DB                      = 0,    // Reduced output 0 dB (non-standard)
	    TXPOWER_REDUCED_3DB                      = -1,    // Reduced output -3 dB (non-standard)
	    TXPOWER_REDUCED_6DB                      = -2,    // Reduced output -6 dB (non-standard)
	    TXPOWER_REDUCED_9DB                      = -3,    // Reduced output -9 dB (non-standard)
	    TXPOWER_REDUCED_12DB                     = -4,    // Reduced output -12 dB (non-standard)
	    TXPOWER_REDUCED_15dB                     = -5,    // Reduced output -15 dB (non-standard)
	    TXPOWER_REDUCED_18dB                     = -6    // Reduced output -18 dB (non-standard)
	};


	/*
 
 subfield=mmp_remote_battcharge_t::charge
 subfield=mmp_battcharge_t::charge

	*/
	public enum mmp_remote_battcharge_charge_t
	{
	    MMP_REMOTE_BATTCHG_UNAVAIL               = 0xFF    // No battery charge information available
	};


	/*
**************************
 DATA Fields
**************************
 
 subsys=DATA

	*/
	public enum mmp_data_fld_t
	{
	    MMP_DATA_FLD_ACK                         = 0x00,    // Data ACK from remote modem received
	    MMP_DATA_FLD_REMOTE_DATA                 = 0x01,    // Data packet from remote modem received
	    MMP_DATA_FLD_XMIT_OVERTEMP               = 0x02,    // Overtemp condition on transmit
	    MMP_DATA_FLD_BURN_COMPLETE               = 0x03,    // Release burn-wire burn cycle active, tilt detected (unit release)
	    MMP_DATA_FLD_TRRC_STATUS                 = 0x04,    // Information on T/R board and RCV module
	    MMP_DATA_FLD_FEAT_KEY_STATUS             = 0x05,    // Information on feature authorization keys
	    MMP_DATA_FLD_REMOTE_HEADER               = 0x06,    // Header information on packets received
	    MMP_DATA_FLD_TIMESTAMP                   = 0x07,    // Timestamp notification for a rx or tx event
	    MMP_DATA_FLD_DOPPLER                     = 0x08,    // Doppler speed information from tones
	    MMP_DATA_FLD_BURN_TIMEOUT                = 0x09,    // Release burn-wire cycle timed out with no tilt
	    MMP_DATA_FLD_DIRECTIONAL                 = 0x0A,    // (DAT ONLY) Information locally from a DAT
	    MMP_DATA_FLD_FPM_VERSION                 = 0x0B,    // Floating point co-processor module version
	    MMP_DATA_FLD_PSK_PKT_NO_COPROC           = 0x0C,    // Notification that a PSK packet was received but FPM coprocessor is not present/enabled.
	    MMP_DATA_FLD_LOW_POWER                   = 0x0D,    // Notification of the modem entering or exiting low power mode
	    MMP_DATA_FLD_ACSTATS                     = 0x0E,    // Acoustic statistics for the packet being received
	    MMP_DATA_FLD_REMOTE_DLOGBLK              = 0x0F,    // Data packet from remote modem containing data logger data, with CRC flags
	    MMP_DATA_FLD_HEADER_ERROR                = 0x10,    // Header received from remote modem with errors; contains acoustic statistics if header decoded, or sentinel value to indicate low SNR acquisition detected
	    MMP_DATA_FLD_NAV_STATUS                  = 0x11,    // Status of navigation sources (location, heading, attitude)
	    MMP_DATA_FLD_RANGE_UPDATE                = 0x12,    // Updated range to a remote node determined via acoustic communication  
	    MMP_DATA_FLD_FPM_BOOT_FAIL               = 0x13,    // Indication of whether a floating point coprocessor that was configured to be present at boot time failed to initialize.  Will always return 0 on platforms that don't support FPM coprocessors.
	    MMP_DATA_FLD_RCV_GAIN                    = 0x14,    // Gives the RCV module attenuator steps and total gain
	    MMP_DATA_FLD_SPECTRUM_STATUS             = 0x15,    // Indicates activation or deactivation of the spectrum mode, along with some parameters
	    MMP_DATA_FLD_SPECTRUM_DATA               = 0x16,    // Energy levels for frequency bins calculated during spectrum mode
	    MMP_DATA_FLD_DIRECTIONAL_DEBUG           = 0x17,    // (DAT ONLY) Additional debug information locally from a DAT
	    MMP_DATA_FLD_TONAL_LOCATOR               = 0x18,    // (DAT ONLY) information pertaining to ELP locator
	    MMP_DATA_FLD_DIRECTIONAL_LOCDEBUG        = 0x1A,    // (DAT ONLY) Additional debug information locally from a DAT pertaining to ELP locator
	    MMP_DATA_FLD_JANUS_PACKET                = 0x1B,    // JANUS data packet received
	    MMP_DATA_FLD_ACOUTRIG_COMPLETE           = 0x1C,    // Acoustic trigger cycle completion with confirmation
	    MMP_DATA_FLD_ACOUTRIG_TIMEOUT            = 0x1D,    // Acoustic trigger cycle complete with no confirmation (timeout)
	    MMP_DATA_FLD_RESPBUFFER_XMIT             = 0x1E,
	    MMP_DATA_FLD_RNGBRG_UPDATE               = 0x1F,    // Updated range and bearing to a remote node
	    MMP_NUM_DATA_FLD                         = 0x20
	};


	/*
 
 subfield=mmp_data_timestamp_t::event

	*/
	public enum mmp_timestamp_event_t
	{
	    MMP_TIMESTAMP_EVENT_TX                   = 0,    // TX
	    MMP_TIMESTAMP_EVENT_RX                   = 1,    // RX
	    MMP_TIMESTAMP_EVENT_TX_SYNC              = 2    // Captured timestamp of external Tx Sync signal
	};


	/*
 
 subfield=mmp_data_lowpower_t::lpstat

	*/
	public enum mmp_lowpower_lpstat_t
	{
	    MMP_LOWPOWER_LPSTAT_EXIT                 = 0,    // Signifies exiting low power mode
	    MMP_LOWPOWER_LPSTAT_ENTER                = 1    // Signifies entering low power mode
	};


	/*
 
 subfield=mmp_data_rangeupdate_t::range_type

	*/
	public enum mmp_rangeupdate_range_type_t
	{
	    MMP_RANGEUPDATE_TYPE_NULL                = 0,    // Null/Unknown range update type
	    MMP_RANGEUPDATE_TYPE_ONEWAY              = 1,    // One-way range, calculated via scheduled transmission from time-synchronized remote modem 
	    MMP_RANGEUPDATE_TYPE_TWOWAY              = 2    // Two-way range, calculated via round-trip packet exchange between two modems 
	};


	/*
 
 subfield=mmp_spectrum_stat_t::stat

	*/
	public enum mmp_spectrum_stat_status_t
	{
	    MMP_SPECTRUM_STAT_OFF                    = 0,    // MMP interface exited
	    MMP_SPECTRUM_STAT_ON                     = 1,    // MMP interface started
	    MMP_NUM_SPECTRUM_STAT                    = 2
	};


	/*
 
 subfield=mmp_data_janus_packet_t::schedule_type

	*/
	public enum mmp_janus_schedule_type_t
	{
	    MMP_JANUS_SCHEDULE_NONE                  = 0,    // No scheduling present, all 34 bits may be used in the ADB.
	    MMP_JANUS_SCHEDULE_RESERVE               = 1,    // A reserve interval is being specified according to Annex B of ANEP-87.  Up to 26 bits of ADB data are present.
	    MMP_JANUS_SCHEDULE_REPEAT                = 2    // A repeat interval is being specified according to Annec C of ANEP-87.  Up to 26 bits of ADB data are present.
	};


	/*
**************************
 DECKBOX Fields
**************************
 
 subsys=DECKBOX

	*/
	public enum mmp_deckbox_fld_t
	{
	    MMP_DECKBOX_FLD_SPKRVOL                  = 0x00,    // Speaker volume
	    MMP_DECKBOX_FLD_PHONESVOL                = 0x01,    // Headphones volume
	    MMP_DECKBOX_FLD_PWRSENSE                 = 0x02,    // Power source information
	    MMP_DECKBOX_FLD_BATTLEV                  = 0x03,    // Internal battery level (rough percentage); a "critical" battery level will trigger a spontaneous MMP notification
	    MMP_DECKBOX_FLD_BATTVOLT                 = 0x04,    // Internal battery voltage
	    MMP_DECKBOX_FLD_MODEL                    = 0x05,    // Deck box model
	    MMP_DECKBOX_FLD_GPS_RELAY                = 0x06,    // GPS pass-through mode on display module (for tunneling external GPS time sync data through to modem - disables most display functions, only supported on some hardware configurations)
	    MMP_NUM_DECKBOX_FLD                      = 0x07
	};


	/*
 For use with device sub-field
 
 subfield=mmp_pwrsense_t::device

	*/
	public enum mmp_deckbox_pwrsense_device_t
	{
	    MMP_DECKBOX_PWRSENSE_DEVICE_BATT         = 0,    // Using internal batteries
	    MMP_DECKBOX_PWRSENSE_DEVICE_AC           = 1,    // Using external AC power
	    MMP_DECKBOX_PWRSENSE_DEVICE_AUXDC        = 2,    // Using external DC power
	    NUM_MMP_DECKBOX_PWRSENSE_DEVICE          = 3
	};


	/*
 For use with charge sub-field, indicates battery level while charging via external AC or DC.
 These are matched up with the _40, _80, and _100 enums in the BATTLEV_CHARGE subfield.
 
 subfield=mmp_pwrsense_t::charge

	*/
	public enum mmp_deckbox_pwrsense_charge_t
	{
	    MMP_DECKBOX_PWRSENSE_CHARGE_LT80         = 2,    // Battery less than 80% charge 
	    MMP_DECKBOX_PWRSENSE_CHARGE_GE80         = 4,    // Battery at least 80% charged
	    MMP_DECKBOX_PWRSENSE_CHARGE_FULL         = 5,    // Battery fully charged
	    MMP_DECKBOX_PWRSENSE_CHARGE_OFFSET       = 20    // For use with smart batteries that can report to 1% accuracy: if the charge percentage is equal to or above this value, then subtract the offset and use the number directly.
	};


	/*
 For use with charge sub-field, indicates battery level while rinning on battery.
 
 subfield=mmp_battlev_t::charge

	*/
	public enum mmp_deckbox_battlev_charge_t
	{
	    MMP_DECKBOX_BATTLEV_CHARGE_0             = 0,    // Battery completely drained
	    MMP_DECKBOX_BATTLEV_CHARGE_20            = 1,    // Battery 20% charge remaining
	    MMP_DECKBOX_BATTLEV_CHARGE_40            = 2,    // Battery 40% charge remaining
	    MMP_DECKBOX_BATTLEV_CHARGE_60            = 3,    // Battery 60% charge remaining
	    MMP_DECKBOX_BATTLEV_CHARGE_80            = 4,    // Battery 80% charge remaining
	    MMP_DECKBOX_BATTLEV_CHARGE_100           = 5,    // Battery fully charged
	    MMP_DECKBOX_BATTLEV_CHARGE_CRITICAL      = 6,    // Battery critically low, auto-shut-down impending (triggers spontaneous MMP notification)
	    NUM_MMP_DECKBOX_BATTLEV_CHARGE           = 7,
	    MMP_DECKBOX_BATTLEV_CHARGE_OFFSET        = 20    // For use with smart batteries that can report to 1% accuracy: if the charge percentage is equal to or above this value, then subtract the offset and use the number directly.
	};


	/*
 For use with model sub-field
 
 subfield=mmp_udb_model_t::model

	*/
	public enum mmp_deckbox_model_t
	{
	    MMP_DECKBOX_MODEL_UNKNOWN                = 0,    // Unknown deck box model
	    MMP_DECKBOX_MODEL_MODEM                  = 1,    // UTS/UDB M variant, fully featured
	    MMP_DECKBOX_MODEL_RELEASE                = 2,    // UTS/UDB A variant, acoustic releases only
	    MMP_DECKBOX_MODEL_MODEM_L3               = 3,    // UDB-9000L3 special
	    MMP_DECKBOX_MODEL_MODEM_SW               = 4,    // UDB-9000SW special
	    MMP_DECKBOX_MODEL_MODEM_EXPORT           = 5,    // UTS/UDB E variant export model (no multi-frequency transpond receive)
	    MMP_DECKBOX_MODEL_MODEM_BONITO           = 6,    // UTS/UDB-9400BN modem-enabled with BONITO Open Network Interface to Off-board systems (BONITO)
	    MMP_DECKBOX_MODEL_MODEM_DR               = 7,    // UDB-9000DR modem-enabled with Data Recorder (OBSOLETE)
	    MMP_DECKBOX_MODEL_MODEM_NR               = 8,    // UDB-9000NR modem-enabled with NUWC Ranging
	    MMP_DECKBOX_MODEL_MODEM_BN               = 9,    // UDB-9400BN modem enabled with Benthonet networking
	    MMP_DECKBOX_MODEL_MODEM_LITE             = 10,    // UTS ML variant, fully featured with "lite" UI
	    MMP_DECKBOX_MODEL_MODEM_EXPORT_LITE      = 11,    // UTS EL variant, export model with "lite" UI (no multi-frequency transpond receive)
	    MMP_DECKBOX_MODEL_RELEASE_LITE           = 12,    // UTS AL variant, acoustic release only with "lite" UI
	    MMP_DECKBOX_MODEL_ROPELESS_FISHING       = 13,    // UTS RF variant, for ropeless fishing applications
	    NUM_MMP_DECKBOX_MODEL                    = 14
	};


	/*
 
 subfield=mmp_gps_relay_t::status

	*/
	public enum mmp_gps_relay_mode_t
	{
	    MMP_DECKBOX_GPS_RELAY_DISABLED           = 0,
	    MMP_DECKBOX_GPS_RELAY_ENABLED            = 1
	};


	/*
**************************
 HWCTL Fields
**************************
 events in this subsystem are interface-specific (only go to inducing interface)
 
 subsys=HWCTL

	*/
	public enum mmp_hwctl_fld_t
	{
	    MMP_HWCTL_FLD_BINOUT0                    = 0x00,    // Set or read the level of binary output 0
	    MMP_HWCTL_FLD_BINOUT1                    = 0x01,    // Set or read the level of binary output 1
	    MMP_HWCTL_FLD_BININ0                     = 0x10,    // Read the level of binary input 0
	    MMP_HWCTL_FLD_BININ1                     = 0x11    // Read the level of binary input 1
	};


	/*
 
 subfield=mmp_xdcr_switch_t::which

	*/
	public enum mmp_xdcr_swtich_value_t
	{
	    XDCR_UPPER                               = 0,    // Upper (top) transducer
	    XDCR_LOWER                               = 1    // Lower (bottom) transducer
	};


	/*
**************************
 IFACE Fields
**************************
 events in this subsystem are interface-specific (only go to inducing interface)
 
 subsys=IFACE

	*/
	public enum mmp_iface_fld_t
	{
	    MMP_IFACE_FLD_MMPSTAT                    = 0x00,    // Status of MMP subsystem
	    MMP_IFACE_FLD_ERR                        = 0x01,    // MMP error notification
	    MMP_IFACE_FLD_VERSION                    = 0x02,    // Version of MMP protocol running
	    MMP_IFACE_FLD_CMDRESULT                  = 0x03,    // MMP command (EXECUTE) result notification
	    MMP_IFACE_FLD_BLOCKNOTIFY                = 0x04,    // Block spontaneous notifications from one or more subsystems.  Used with SET, provide a variable length list of subsystems to block.  Returns a variable-length list of blocked subsystems.  Note that responses will always be received when induced by a direct SET/CMD on an interface even if the subsystem is blocked; this only filters spontaneous notifies. 
	    MMP_IFACE_FLD_UNBLOCKNOTIFY              = 0x05,    // Allow spontaneous notifications from one or more subsystems.  Used with SET, provide a variable-length list of subsystems to unblock.  Returns a variable-length list of unblocked subsystems. 
	    MMP_IFACE_FLD_DSP_SW_VERSION             = 0x06,    // DSP firmware version currently running
	    MMP_IFACE_FLD_PRIVLEV                    = 0x07,    // Privilege level on this MMP interface (requires password only if elevating from current privlev)
	    MMP_IFACE_FLD_REMOTE_MMPRESP             = 0x08,
	    MMP_IFACE_FLD_FEATURE_KEY                = 0x09,    // temporarily enable a feature key
	    MMP_IFACE_FLD_UNIT_SERNO                 = 0x0A,    // Obtain the assembly serial number
	    MMP_IFACE_FLD_NTFY_COUNT                 = 0x0B,    // Enable, disable, or query the status of appended notification counter (unique on a per-interface basis)
	    MMP_IFACE_FLD_NTFY_CKSUM                 = 0x0C,    // Enable, disable, or query the status of appended notification XOR checksum
	    MMP_IFACE_FLD_AES_USER_KEY               = 0x0D,    // Set an AES user key for use with encrypted code images, along with an optional timeout.  If 0xFFFF is provided for the timeout value, the AES key and auto-clear timeouts are cleared.  An INVALID_STATE error will result if an attempt is made to install a new key over an existing one without first clearing it.
	    MMP_IFACE_FLD_COMPATIBILITY              = 0x0E,    // A compatibility number used for syncing external controllers (such as ReleaseIT display) with a given range of software version.  This number may vary by platform and is intended primarily for Teledyne use.
	    MMP_IFACE_FLD_FEATURE_KEY_INVENTORY      = 0x0F,    // Get the inventory of installed feature keys
	    MMP_IFACE_FLD_GATE_DATA_DIRECTIONAL      = 0x10,    // (DAT ONLY) Suppress output of DATA::DIRECTIONAL notify when vector is below vthesh.
	    MMP_NUM_IFACE_FLD                        = 0x11
	};


	/*
 
 subfield=mmp_iface_stat_t::stat

	*/
	public enum mmp_iface_stat_status_t
	{
	    MMP_IFACE_STAT_EXITED                    = 0,    // MMP interface exited
	    MMP_IFACE_STAT_STARTED                   = 1,    // MMP interface started
	    MMP_NUM_IFACE_STAT                       = 2
	};


	/*
 
 subfield=mmp_sfl_err_t::err

	*/
	public enum mmp_iface_err_t
	{
	    MMP_IFACE_ERR_NULL                       = 0x00,    // Null error code
	    MMP_IFACE_ERR_TIMEOUT                    = 0x01,    // Operation has timed out
	    MMP_IFACE_ERR_BAD_SUBSYS                 = 0x02,    // Bad subsystem in GET/SET request
	    MMP_IFACE_ERR_BAD_FIELD                  = 0x03,    // Bad field in GET/SET request
	    MMP_IFACE_ERR_BAD_VALUE                  = 0x04,    // Bad value in GET/SET request
	    MMP_IFACE_ERR_PARSE                      = 0x05,    // Error parsing serial stream
	    MMP_IFACE_ERR_BAD_CMDSECT                = 0x06,    // Bad command section in EXEC request
	    MMP_IFACE_ERR_BAD_CMD                    = 0x07,    // Bad command in EXEC request
	    MMP_IFACE_ERR_BAD_CMDARGS                = 0x08,    // Bad arguments to command in EXEC request
	    MMP_IFACE_ERR_MULTICMD                   = 0x09,    // More than one EXEC operation in single transaction
	    MMP_IFACE_ERR_DEVICE_BUSY                = 0x0A,    // Modem too busy to process request
	    MMP_IFACE_ERR_NOTIFY_ONLY                = 0x0B,    // Field not accessible with GET/SET, spontaneous NOTIFY only
	    MMP_IFACE_ERR_NO_RESOURCE                = 0x0C,    // Resources not available to process request
	    MMP_IFACE_ERR_UNMODIFIABLE               = 0x0D,    // Value may not be modified with a SET
	    MMP_IFACE_ERR_PERMISSION                 = 0x0E,    // Insufficient permission level to carry out operation
	    MMP_IFACE_ERR_INVALID_STATE              = 0x0F,    // The modem is not in a state that can validly process the request
	    MMP_IFACE_ERR_FEAT_NOT_ENABLED           = 0x10,    // The requested operation requires feature key activation, but the key is not installed
	    MMP_IFACE_ERR_NOT_IMPLEMENTED            = 0x11,    // The requested operation is recognized but is not yet implemented in the MMP engine
	    MMP_IFACE_ERR_HW_NOT_PRESENT             = 0x12,    // The requested operation relies on hardware that is either not present on the board or did not initialize properly
	    MMP_IFACE_ERR_DB_LOCKED                  = 0x13,    // An attempt to modify a database (like the configuration) was disallowed because it is in a locked state
	    MMP_IFACE_ERR_ACOU_DISALLOWED            = 0x14,    // The modification attempt cannot be performed acoustically
	    MMP_IFACE_ERR_SET_ONLY                   = 0x15,    // The field may only be SET, and not queried with a GET operation
	    MMP_NUM_IFACE_ERR                        = 0x16
	};


	/*
 CMDRESULT message types.  Note that all errors and mmp_exec_notify() calls will clear the current MMP
 exec information with the exception of the CMD_STARTED and PROGRESS command result message types.
 
 subfield=mmp_cmd_result_t::message

	*/
	public enum mmp_cmdresult_msg_t
	{
	    MMP_CMDRESULT_ERROR                      = 0,    // An error occurred - clears current execution data
	    MMP_CMDRESULT_CMD_ACK                    = 1,    // Action completed successfully - clears current execution data
	    MMP_CMDRESULT_CMD_STARTED                = 2,    // Action/mode has started - should be followed by CMD_ENDED and does not automatically clear the current execution data
	    MMP_CMDRESULT_CMD_ENDED                  = 3,    // Action/mode has ended - clears current execution data
	    MMP_CMDRESULT_DATA                       = 4,    // Data is being returned from the command.  The standard CMDRESULT header will be followed by a command-specific set of result data.  Clears current execution data.
	    MMP_CMDRESULT_TIMEOUT                    = 5,    // Command ended with a timeout condition - clears current execution data
	    MMP_CMDRESULT_PROGRESS                   = 6,    // Command is progressing with more messages forthcoming.  Like CMDRESULT_DATA, it may be followed by more information.  Does not automatically clear the current execution data.
	    MMP_CMDRESULT_REMOTE_ERROR               = 7,    // Remotely executed MMP operation contains one or more error conditions
	    MMP_CMDRESULT_REMOTE_TIMEOUT             = 8,    // Remotely executed MMP operation timed out
	    MMP_CMDRESULT_REMOTE_DENIED              = 9,    // Remotely executed MMP operation disallowed due to locking, permissions, etc.
	    MMP_NUM_CMDRESULT                        = 10
	};


	/*
**************************
 SREG Fields
**************************
 
 subsys=SREG

	*/
	public enum mmp_sreg_fld_t
	{
	    MMP_SREG_FLD_VERSION                     = 0,    // DSP SW version
	    MMP_SREG_FLD_POSACK                      = 2,    // Positive acknowledgements
	    MMP_SREG_FLD_SERBAUD                     = 3,    // Serial port baud & configuration
	    MMP_SREG_FLD_ACOUBAUD                    = 4,    // Acoustic baud rate
	    MMP_SREG_FLD_TXPOWER                     = 6,    // Transmit power
	    MMP_SREG_FLD_RESPTIMEOUT                 = 7,    // Acoustic response timeout
	    MMP_SREG_FLD_FWDDELAY                    = 8,    // Packet forwarding delay
	    MMP_SREG_FLD_COPROC                      = 9,    // PSK coprocessor enable/status
	    MMP_SREG_FLD_LPTIMEOUT                   = 10,    // Low-power idle timeout
	    MMP_SREG_FLD_FLOWCTRL                    = 11,    // Serial port flow control
	    MMP_SREG_FLD_TESTMSGLEN                  = 12,    // Acoustic test message length
	    MMP_SREG_FLD_VERBOSITY                   = 13,    // Console message verbosity
	    MMP_SREG_FLD_REMADDR                     = 14,    // Default remote modem address
	    MMP_SREG_FLD_LOCADDR                     = 18,    // Local modem address
	    MMP_SREG_FLD_RXTHRESHOLD                 = 21,    // Receive sensitivity threshold for transpond pings
	    MMP_SREG_FLD_BAND                        = 24,    // Acoustic band
	    MMP_SREG_FLD_TXPULSEWIDTH                = 32,    // Transpond interrogation ping pulse width
	    MMP_SREG_FLD_RXPULSEWIDTH                = 33,    // Transpond received ping pulse width
	    MMP_SREG_FLD_TAT                         = 40,    // Transponder/ranging turn-around time
	    MMP_SREG_FLD_PPSSYNC                     = 49,    // Internal/external 1 PPS time sync mode
	    MMP_SREG_FLD_RXFREQ                      = 53,    // Transpond ping receive frequency (only for units that can't receive multiple frequencies)
	    MMP_SREG_FLD_XPNDLOCKOUT                 = 55,    // Transpond ping lockout time
	    MMP_SREG_FLD_ALL                         = 255    // Use to SET/GET all S-registers at once
	};


	/*
 SREG subsys - field BAND
 
 subfield=mmp_sreg_fld_val_t::val

	*/
	public enum mmp_sreg_band_t
	{
	    MMP_SREG_BAND_LF                         = 56,    // LF band
	    MMP_SREG_BAND_MF                         = 100,    // MF band
	    MMP_SREG_BAND_C                          = 141,    // C band
	    MMP_SREG_BAND_HF                         = 156    // HF band
	};


	/*
 SREG subsys - field TESTMSGLEN
 
 subfield=mmp_sreg_fld_val_t::val

	*/
	public enum mmp_sreg_testmsglen_t
	{
	    MMP_SREG_TESTMSGLEN_8                    = 0,    // 8 byte test message
	    MMP_SREG_TESTMSGLEN_32                   = 1,    // 32 byte test message
	    MMP_SREG_TESTMSGLEN_128                  = 2,    // 128 byte test message
	    MMP_SREG_TESTMSGLEN_256                  = 3,    // 256 byte test message
	    MMP_SREG_TESTMSGLEN_512                  = 4,    // 512 byte test message
	    MMP_SREG_TESTMSGLEN_1024                 = 5,    // 1024 byte test message
	    MMP_SREG_TESTMSGLEN_2048                 = 6,    // 2048 byte test message
	    MMP_SREG_TESTMSGLEN_4096                 = 7    // 4096 byte test message
	};


	/*
**************************
 TIME Fields
**************************
 events in this subsystem are interface-specific (only go to inducing interface)
 
 subsys=TIME

	*/
	public enum mmp_time_fld_t
	{
	    MMP_TIME_FLD_1PPS_PULSE                  = 0x00,    // (currently unsupported) Arrival of 1 PPS synchronization pulse
	    MMP_TIME_FLD_TIMEDATE                    = 0x01,    // The time and date on the modem's clock
	    MMP_TIME_FLD_DSTPARMS                    = 0x02,    // (currently unsupported) Parameters governing Daylight Savings Time adjustments of local time
	    MMP_TIME_FLD_RTCBATT                     = 0x03,    // Battery level on modem's clock
	    MMP_TIME_FLD_SYNCINFO                    = 0x04,    // Synchronization status of the modem to an accurate 1PPS reference (internal or external) and timestamping information (e.g., $GPZDA messages)
	    MMP_NUM_TIME_FLD                         = 0x05
	};


	/*
**************************
 TRANSPOND Fields
**************************
 
 subsys=TRANSPOND

	*/
	public enum mmp_transpond_fld_t
	{
	    MMP_TRANSPOND_FLD_STAT                   = 0x00,    // Transpond mode status
	    MMP_TRANSPOND_FLD_PINGRCVD               = 0x01,    // Transpond ping received
	    MMP_TRANSPOND_FLD_CHNLRXADJ_0            = 0x02,    // Receive sensitivity adjustment for channel 0
	    MMP_TRANSPOND_FLD_CHNLRXADJ_1            = 0x03,    // Receive sensitivity adjustment for channel 1
	    MMP_TRANSPOND_FLD_CHNLRXADJ_2            = 0x04,    // Receive sensitivity adjustment for channel 2
	    MMP_TRANSPOND_FLD_CHNLRXADJ_3            = 0x05,    // Receive sensitivity adjustment for channel 3
	    MMP_TRANSPOND_FLD_CHNLRXADJ_4            = 0x06,    // Receive sensitivity adjustment for channel 4
	    MMP_TRANSPOND_FLD_CHNLRXADJ_5            = 0x07,    // Receive sensitivity adjustment for channel 5
	    MMP_TRANSPOND_FLD_CHNLRXADJ_6            = 0x08,    // Receive sensitivity adjustment for channel 6
	    MMP_TRANSPOND_FLD_CHNLRXADJ_7            = 0x09,    // Receive sensitivity adjustment for channel 7
	    MMP_TRANSPOND_FLD_CHNLRXADJ_8            = 0x0A,    // Receive sensitivity adjustment for channel 8
	    MMP_TRANSPOND_FLD_CHNLRXADJ_9            = 0x0B,    // Receive sensitivity adjustment for channel 9
	    MMP_TRANSPOND_FLD_CHNLRXADJ_10           = 0x0C,    // Receive sensitivity adjustment for channel 10
	    MMP_TRANSPOND_FLD_CHNLRXADJ_11           = 0x0D,    // Receive sensitivity adjustment for channel 11
	    MMP_TRANSPOND_FLD_CHNLRXADJ_12           = 0x0E,    // Receive sensitivity adjustment for channel 12
	    MMP_TRANSPOND_FLD_CHNLRXADJ_13           = 0x0F,    // Receive sensitivity adjustment for channel 13
	    MMP_TRANSPOND_FLD_CHNLRXADJ_14           = 0x10,    // Receive sensitivity adjustment for channel 14
	    MMP_TRANSPOND_FLD_CHNLRXADJ_15           = 0x11,    // Receive sensitivity adjustment for channel 15
	    MMP_TRANSPOND_FLD_CHNLRXADJ_16           = 0x12,    // Receive sensitivity adjustment for channel 16
	    MMP_TRANSPOND_FLD_CHNLRXADJ_17           = 0x13,    // Receive sensitivity adjustment for channel 17
	    MMP_TRANSPOND_FLD_CHNLRXADJ_18           = 0x14,    // Receive sensitivity adjustment for channel 18
	    MMP_TRANSPOND_FLD_CHNLRXADJ_19           = 0x15,    // Receive sensitivity adjustment for channel 19
	    MMP_TRANSPOND_FLD_CHNLRXADJ_20           = 0x16,    // Receive sensitivity adjustment for channel 20
	    MMP_TRANSPOND_FLD_CHNLRXADJ_21           = 0x17,    // Receive sensitivity adjustment for channel 21
	    MMP_TRANSPOND_FLD_CHNLRXADJ_22           = 0x18,    // Receive sensitivity adjustment for channel 22
	    MMP_TRANSPOND_FLD_CHNLRXADJ_23           = 0x19,    // Receive sensitivity adjustment for channel 23
	    MMP_TRANSPOND_FLD_CHNLRXADJ_24           = 0x1A,    // Receive sensitivity adjustment for channel 24
	    MMP_TRANSPOND_FLD_CHNLRXADJ_25           = 0x1B,    // Receive sensitivity adjustment for channel 25
	    MMP_TRANSPOND_FLD_CHNLRXADJ_26           = 0x1C,    // Receive sensitivity adjustment for channel 26
	    MMP_TRANSPOND_FLD_CHNLRXADJ_27           = 0x1D,    // Receive sensitivity adjustment for channel 27
	    MMP_TRANSPOND_FLD_CHNLRXADJ_28           = 0x1E,    // Receive sensitivity adjustment for channel 28
	    MMP_TRANSPOND_FLD_CHNLRXADJ_29           = 0x1F,    // Receive sensitivity adjustment for channel 29
	    MMP_TRANSPOND_FLD_CHNLRXADJ_30           = 0x20,    // Receive sensitivity adjustment for channel 30
	    MMP_TRANSPOND_FLD_CHNLRXADJ_31           = 0x21,    // Receive sensitivity adjustment for channel 31
	    MMP_TRANSPOND_FLD_CHNLRXADJ_32           = 0x22,    // Receive sensitivity adjustment for channel 32
	    MMP_TRANSPOND_FLD_CHNLRXADJ_33           = 0x23,    // Receive sensitivity adjustment for channel 33
	    MMP_TRANSPOND_FLD_CHNLRXADJ_34           = 0x24,    // Receive sensitivity adjustment for channel 34
	    MMP_TRANSPOND_FLD_CHNLRXADJ_35           = 0x25,    // Receive sensitivity adjustment for channel 35
	    MMP_TRANSPOND_FLD_CHNLRXADJ_36           = 0x26,    // Receive sensitivity adjustment for channel 36
	    MMP_TRANSPOND_FLD_CHNLRXADJ_37           = 0x27,    // Receive sensitivity adjustment for channel 37
	    MMP_TRANSPOND_FLD_CHNLRXADJ_38           = 0x28,    // Receive sensitivity adjustment for channel 38
	    MMP_TRANSPOND_FLD_CHNLRXADJ_39           = 0x29,    // Receive sensitivity adjustment for channel 39
	    MMP_TRANSPOND_FLD_CHNLRXADJ_40           = 0x2A,    // Receive sensitivity adjustment for channel 40
	    MMP_TRANSPOND_FLD_CHNLRXADJ_ALL          = 0x2B,    // Set or get all receive channel sensitivity adjustments at once
	    MMP_NUM_TRANSPOND_FLD                    = 0x2C
	};


	/*
 
 subfield=mmp_transpond_stat_t::stat

	*/
	public enum mmp_transpond_stat_status_t
	{
	    MMP_TRANSPOND_STAT_IDLE                  = 0,    // Modem is not listening for transpond pings
	    MMP_TRANSPOND_STAT_ACTIVE                = 1,    // Modem is listening for transpond receive pings for a finite period of time
	    MMP_TRANSPOND_STAT_CONTINUOUS            = 2,    // Modem is continually listening for transpond receive pings
	    MMP_NUM_TRANSPOND_STAT                   = 3
	};


	/*
 
 subfield=mmp_transpond_pingrcvd_t::flags  (each flag may be set independently)

	*/
	public enum mmp_transpond_pingrcvd_flag_t
	{
	    MMP_TRANSPOND_PINGRCVD_FLAG_RESIDUAL     = 0x01    // This ping is measured against an earlier interrogation and not a new one about to depart.
	};


	/*
 Values for use with ACOUBAUD/modspec parameter
 
 subfield=mmp_sreg_fld_val_t::val
 subfield=mmp_remote_setacoubaud_t::modspec
 subfield=mmp_remote_testmsgstats_t::mod_spec
 subfield=mmp_data_acstats_t::mod_spec
 subfield=mmp_network_pkthdr_t::mod_spec
 subfield=mmp_network_l2utilpkt_t::modspec
 subfield=mmp_remote_autobaud_t::max_modspec
 subfield=mmp_remote_autobaud_t::min_modspec

	*/
	public enum modspec_t
	{
	    MODSPEC_NULL                             = 0,    // Null modspec value
	    MODSPEC_80_STDFH                         = 1,    // 80 bps FH
	    MODSPEC_140_MFSK                         = 2,    // 140 bps MFSK
	    MODSPEC_300_MFSK                         = 3,    // 300 bps MFSK
	    MODSPEC_600_MFSK                         = 4,    // 600 bps MFSK
	    MODSPEC_800_MFSK                         = 5,    // 800 bps MFSK
	    MODSPEC_1066_MFSK                        = 6,    // 1066 bps MFSK
	    MODSPEC_1200_MFSK                        = 7,    // 1200 bps MFSK
	    MODSPEC_2400_MFSK                        = 8,    // 2400 bps MFSK
	    MODSPEC_2560_PSK                         = 9,    // 2560 bps PSK
	    MODSPEC_5120_PSK                         = 10,    // 5120 bps PSK
	    MODSPEC_7680_PSK                         = 11,    // 7680 bps PSK
	    MODSPEC_10240_PSK                        = 12,    // 10240 bps PSK
	    MODSPEC_15360_PSK                        = 13,    // 15360 bps PSK
	    MODSPEC_80_WHFH                          = 64,
	    MODSPEC_80_MRFH                          = 65,
	    MODSPEC_160_MAFH                         = 66,
	    MODSPEC_80_MAFH                          = 67,
	    MODSPEC_80_JAFH                          = 68,
	    NUM_MODSPEC                              = 19
	};


	/*
ACK codes
 
 subfield=mmp_data_ack_t::ack
 subfield=mmp_rngrls_cmdresult_release_response_t::status

	*/
	public enum ack_code_t
	{
	    OK                                       = 0,    // Operation successful
	    BUFFER_EMPTY                             = 1,    // Nothing in data logger
	    BLOCK_EMPTY                              = 2,    // Nothing in requested block of data logger
	    INVALID_SETTING                          = 3,    // Invalid setting
	    INVALID_RELEASE_CODE                     = 4,    // Invalid release code
	    GOOD_RELEASE                             = 5,    // Mechanical release successful
	    VALID_RELEASE_CODE                       = 6,    // Received valid release code, activating motor
	    NOT_RELEASED                             = 7,    // Unit not released
	    BUSY                                     = 8,    // Unit busy
	    VALID_RELEASE_CODE_BURN                  = 9,    // Received valid release code, beginning burn wire burn cycle
	    GOOD_BURN_RELEASE                        = 10,    // Burn wire burn cycle completed successfully
	    BURN_RELEASE_TIMEOUT                     = 11,    // Burn wire burn cycle stopped due to timeout, no tilt detected
	    SREG_SAVED                               = 12,    // Remote S-register saved
	    DATALOG_NOT_SUPPORTED                    = 13,    // Datalogger not supported on this unit
	    DATALOG_ERASE_STARTED                    = 14,    // Datalogger erase started
	    INVALID_ACOUSTIC_TRIGGER_CODE            = 15,    // Invalid trigger code
	    VALID_ACOUSTIC_TRIGGER_CODE              = 16,    // Received valid acoustic trigger code, asserting signal
	    ACOUSTIC_TRIGGER_CONFIRMED               = 17,    // Acoustic trigger confirmed (signal may or may not be de-asserted depending on configuration)
	    ACOUSTIC_TRIGGER_TIMEOUT                 = 18    // Acoustic trigger timed out with no confirmation, signal de-asserted
	};


	/*
 
 subfield=mmp_rngrls_cmdresult_release_status_t::status

	*/
	public enum rls_status_code_t
	{
	    RLSSTAT_STD_MODEM                        = 0,    // Standard modem, no release capability
	    RLSSTAT_CONFIRMED                        = 1,    // Release triggered and confirmed
	    RLSSTAT_NOT_CONFIRMED                    = 2,    // Release triggered and not confirmed
	    RLSSTAT_ARMED                            = 3,    // Release armed and ready to accept release code
	    RLSSTAT_BURNWIRE_ACTIVATED               = 4,    // Release burn wire burn cycle is active
	    RLSSTAT_BURNWIRE_CONFIRMED               = 5,    // Release burn wire burn cycle triggered, tilt sensor triggered
	    RLSSTAT_BURNWIRE_TIMEOUT                 = 6,    // release burn wire burn cycle timed out, no tilt detected
	    RLSSTAT_BURNWIRE_ARMED                   = 7,    // New (4G) status to differentiate armed burn wire units from mech releases
	    RLSSTAT_RSERIES_ARMED                    = 16,    // Next-Gen Release armed
	    RLSSTAT_RSERIES_CONFIRMED                = 17,    // Next-Gen Release triggered and confirmed
	    RLSSTAT_RSERIES_NOT_CONFIRMED            = 18,    // Next-Gen release triggered and not confirmed
	    RLSSTAT_ACOUTRIG_NOT_ASSERTED            = 19,    // Acoustic trigger signal not asserted
	    RLSSTAT_ACOUTRIG_ASSERTED                = 20,    // Acoustic trigger signal asserted
	    RLSSTAT_ACOUTRIG_CONFIRMED               = 21,    // Acoustic trigger signal confirmed and de-asserted
	    RLSSTAT_ACOUTRIG_ASSERTED_CONFIRMED      = 22,    // Acoustic trigger signal confirmed and still asserted
	    RLSSTAT_ACOUTRIG_TIMEOUT                 = 23,    // Acoustic trigger signal not confirmed and de-asserted
	    NUM_RLSSTAT                              = 24
	};


	/*
 
 subfield=mmp_rngrls_cmdresult_release_status_t::battery

	*/
	public enum battery_status_t
	{
	    BATTERY_GOOD                             = 0,    // Battery voltage is good
	    BATTERY_LOW                              = 1,    // Battery voltage is low
	    BATTERY_REDUCED                          = 2,    // Battery voltage reduced
	    BATTERY_CHARGE_BASE                      = 20,    // Values between 20 and 120 are the charge status in percent remaining, offset by 20
	    BATTERY_VOLT_BASE                        = 125    // Values between 125 and 245 are the battery voltage in 0.5 volt increments (0 - 60 V range)
	};


	/*
 
 subfield=mmp_rngrls_cmdresult_release_status_t::tilt

	*/
	public enum tilt_status_t
	{
	    RLS_NOT_TILTED                           = 0,    // The release unit is upright
	    RLS_TILTED                               = 1,    // The release unit is tilted
	    RLS_TILT_EXCESS_MOTION                   = 2,    // The tilt value could not be read because the sensor was moving too much
	    RLS_TILT_HW_NOT_READY                    = 3,    // Error attempting to read tilt-sensing hardware
	    RLS_DEGREE_BASE                          = 20,    // Values between 20 and 200 are the tilt measurement in degrees, offset by 20; subtract RLS_DEGREE_BASE to obtain the true measurement
	    RLS_TILT_COMPACT                         = 254,    // The release unit is a Compact Release with no tilt sensor
	    RLS_TILT_OEMBOARDSET                     = 255
	};


	/*
 The positional state of continuous (one-way) relase motors such as Compact Release and ARM6K
 
 subfield=mmp_data_rls_cmotor_status_t::status

	*/
	public enum cmotor_release_stat_t
	{
	    CMOTOR_TIMEOUT                           = -1,    // The motor has timed out without reaching a known position and is stopped
	    CMOTOR_RUNNING                           = 0,    // The motor is energized and turning
	    CMOTOR_LATCHED                           = 1,    // The motor has reached its armed/latched position
	    CMOTOR_RELEASED                          = 2,    // The motor has reached its release position
	    CMOTOR_INVALID                           = 3    // Invalid state where both sense switches are active at the same time (should not happen!)
	};


	/*
 Transmit power enums
 
 subfield=mmp_sreg_fld_val_t::val
 subfield=mmp_remote_settxpower_t::txpower
 subfield=mmp_network_ping_t::pwrlev
 subfield=mmp_swcmd_netcfgstart_t::txpower
 subfield=mmp_remote_testmsgstats_t::remote_txpwr

	*/
	public enum txpower_t
	{
	    TXPOWER_MIN                              = 1,
	    TXPOWER_21DB                             = 1,    // -21 dB
	    TXPOWER_18DB                             = 2,    // -18 dB
	    TXPOWER_15DB                             = 3,    // -15 dB
	    TXPOWER_12DB                             = 4,    // -12 dB
	    TXPOWER_9DB                              = 5,    // -9 dB
	    TXPOWER_6DB                              = 6,    // -6 dB
	    TXPOWER_3DB                              = 7,    // -3 dB
	    TXPOWER_MAX                              = 8,    // 0 dB (full transmit power)
	    LEVEL_SILENT_PING                        = 255
	};


	/*
 Maximum SPL enums
 
 subfield=mmp_sreg_fld_val_t::val

	*/
	public enum txatten_t
	{
	    TXATTEN_0DB                              = 0,    // Full transmit power
	    TXATTEN_24DB                             = 1    // (approximately) 24 dB attenuation
	};


	/*
 
 subfield=mmp_remote_autobaud_t::set_flags
 subfield=mmp_remote_autobaud_result_t::set_flags

	*/
	public enum autobaud_set_flags_t
	{
	    AUTOBAUD_LOCAL_SET                       = 0x01,    // When set, causes the the local modem to set its own transmission baud rate to the best one found
	    AUTOBAUD_REMOTE_SET                      = 0x02
	};


	/*
 Layer 2 commands
 
 subfield=mmp_data_remote_header_t::type
*************************

	*/
	public enum std_layer2_command_t
	{
	    L2CMD_875C                               = 0,
	    L2CMD_UNUSED1                            = 1,
	    L2CMD_UNUSED2                            = 2,
	    L2CMD_NUWC_RNG                           = 3,
	    L2CMD_BRG_DATA                           = 4,
	    L2CMD_875D_TRANSPORT                     = 5,
	    L2CMD_UNUSED6                            = 6,
	    L2CMD_UNUSED7                            = 7,
	    L2CMD_UNUSED8                            = 8,
	    L2CMD_UNUSED9                            = 9,
	    L2CMD_UNUSED10                           = 10,
	    L2CMD_SRQ                                = 11,
	    L2CMD_FHC                                = 12,
	    L2CMD_FHD                                = 13,
	    L2CMD_DATA                               = 14,
	    L2CMD_875D                               = 15
	};


	/*
 
 subfield=mmp_time_syncinfo_t::pps_state

	*/
	public enum pps_sync_state_t
	{
	    PPS_NO_SYNC                              = 0,    // Not synchronized to a 1PPS source, awaiting qualification of a source
	    PPS_PULSE_SYNC                           = 1,    // Locked to a 1PPS source following qualification
	    PPS_COAST_MODE                           = 2,    // Coasting based on compiled statistics after having been locked to an erstwhile 1PPS source
	    PPS_DISABLED_SYNC                        = 3    // Synchronization to a 1PPS source has been manually disabled
	};


	/*
 
 subfield=mmp_time_syncinfo_t::time_sync

	*/
	public enum tss_state_t
	{
	    TSS_NO_CHANGE                            = -1,
	    TSS_OUT_OF_SYNC                          = 0,    // Time has not been set
	    TSS_NORM_IN_SYNC                         = 1,    // Time is set
	    TSS_EXT_READY_TIME_UPDATE                = 2,    // Waiting to receive an external timestamp (non-standard applications only)
	    TSS_EXT_TIME_RECEIVED                    = 3    // External timetstamp received (non-standard applications only)
	};


	/*
 
 subfield=mmp_rngrls_geopro_param_t::cmdtype

	*/
	public enum geopro_cmd_t
	{
	    GEOPRO_CMD_ENABLE                        = 0,
	    GEOPRO_CMD_RELEASE                       = 1,
	    GEOPRO_CMD_RESET                         = 2
	};


	/*
 
 subfield=mmp_rngrls_xpnd_param_t::xpnd_mode

	*/
	public enum io_tone_mode_type_t
	{
	    IO_TONE_MODE_NONE                        = 0,
	    IO_TONE_MODE_TONE                        = 1,
	    IO_TONE_MODE_HPR400                      = 2
	};


	/*
 

	*/
	public enum udb_version_num_t
	{
	    UDB_VERSION_MAJOR                        = 8,
	    UDB_VERSION_MINOR                        = 15,
	    UDB_VERSION_REVISION                     = 3
	};


	public enum DbKeys : ushort
	{
		AIN_1NMEAS = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_1NMEAS,
		AIN_1RPTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_1RPTDLY,
		AIN_1STRTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_1STRTDLY,
		AIN_1TYPE = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_1TYPE,
		AIN_2NMEAS = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_2NMEAS,
		AIN_2RPTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_2RPTDLY,
		AIN_2STRTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_2STRTDLY,
		AIN_2TYPE = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_2TYPE,
		AIN_3NMEAS = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_3NMEAS,
		AIN_3RPTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_3RPTDLY,
		AIN_3STRTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_3STRTDLY,
		AIN_4NMEAS = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_4NMEAS,
		AIN_4RPTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_4RPTDLY,
		AIN_4STRTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_4STRTDLY,
		AIN_5NMEAS = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_5NMEAS,
		AIN_5RPTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_5RPTDLY,
		AIN_5STRTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_5STRTDLY,
		AIN_6NMEAS = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_6NMEAS,
		AIN_6RPTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_6RPTDLY,
		AIN_6STRTDLY = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_6STRTDLY,
		AIN_POLLRATE = ((ushort)mmp_subsys_t.CFG_SECT_AIN << 8) | (ushort)cfg_ain_param_enum_t.CFG_AIN_POLLRATE,
		COPROC_CPBOARD = ((ushort)mmp_subsys_t.CFG_SECT_COPROC << 8) | (ushort)cfg_coproc_param_enum_t.CFG_COPROC_CPBOARD,
		COPROC_FDBCKTAPS = ((ushort)mmp_subsys_t.CFG_SECT_COPROC << 8) | (ushort)cfg_coproc_param_enum_t.CFG_COPROC_FDBCKTAPS,
		COPROC_FDFWDTAPS = ((ushort)mmp_subsys_t.CFG_SECT_COPROC << 8) | (ushort)cfg_coproc_param_enum_t.CFG_COPROC_FDFWDTAPS,
		DAT_ARRIVAL = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_ARRIVAL,
		DAT_BEARINGRESP = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_BEARINGRESP,
		DAT_MAX_ELEV = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_MAX_ELEV,
		DAT_MIN_ELEV = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_MIN_ELEV,
		DAT_ORIENTATION = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_ORIENTATION,
		DAT_PHASEA = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_PHASEA,
		DAT_PHASEB = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_PHASEB,
		DAT_PHASEC = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_PHASEC,
		DAT_PHASED = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_PHASED,
		DAT_PHASEREF = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_PHASEREF,
		DAT_PREGAIN = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_PREGAIN,
		DAT_ROTATION = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_ROTATION,
		DAT_RXONDAT = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_RXONDAT,
		DAT_VERBOSE = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_VERBOSE,
		DAT_VTHRESH = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_VTHRESH,
		DAT_WRAPRANGE = ((ushort)mmp_subsys_t.CFG_SECT_DAT << 8) | (ushort)cfg_dat_param_enum_t.CFG_DAT_WRAPRANGE,
		DATALOG_ACDATA = ((ushort)mmp_subsys_t.CFG_SECT_DATALOG << 8) | (ushort)cfg_datalog_param_enum_t.CFG_DATALOG_ACDATA,
		DATALOG_ACSTATS = ((ushort)mmp_subsys_t.CFG_SECT_DATALOG << 8) | (ushort)cfg_datalog_param_enum_t.CFG_DATALOG_ACSTATS,
		DATALOG_CHRCOUNT = ((ushort)mmp_subsys_t.CFG_SECT_DATALOG << 8) | (ushort)cfg_datalog_param_enum_t.CFG_DATALOG_CHRCOUNT,
		DATALOG_LOGMODE = ((ushort)mmp_subsys_t.CFG_SECT_DATALOG << 8) | (ushort)cfg_datalog_param_enum_t.CFG_DATALOG_LOGMODE,
		DATALOG_LOGSTORE = ((ushort)mmp_subsys_t.CFG_SECT_DATALOG << 8) | (ushort)cfg_datalog_param_enum_t.CFG_DATALOG_LOGSTORE,
		DATALOG_RINGBUF = ((ushort)mmp_subsys_t.CFG_SECT_DATALOG << 8) | (ushort)cfg_datalog_param_enum_t.CFG_DATALOG_RINGBUF,
		DATALOG_SENTINEL = ((ushort)mmp_subsys_t.CFG_SECT_DATALOG << 8) | (ushort)cfg_datalog_param_enum_t.CFG_DATALOG_SENTINEL,
		DATALOG_SUBBLKS = ((ushort)mmp_subsys_t.CFG_SECT_DATALOG << 8) | (ushort)cfg_datalog_param_enum_t.CFG_DATALOG_SUBBLKS,
		JANUS_APPTYPE = ((ushort)mmp_subsys_t.CFG_SECT_JANUS << 8) | (ushort)cfg_janus_param_enum_t.CFG_JANUS_APPTYPE,
		JANUS_CLASSUSERID = ((ushort)mmp_subsys_t.CFG_SECT_JANUS << 8) | (ushort)cfg_janus_param_enum_t.CFG_JANUS_CLASSUSERID,
		JANUS_MACTHRESH = ((ushort)mmp_subsys_t.CFG_SECT_JANUS << 8) | (ushort)cfg_janus_param_enum_t.CFG_JANUS_MACTHRESH,
		MODEM_ACKMODE_DONOTUSE = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_ACKMODE_DONOTUSE,
		MODEM_ACRSPTMOUT = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_ACRSPTMOUT,
		MODEM_ADDRGROUP = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_ADDRGROUP,
		MODEM_APCALPHSM = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_APCALPHSM,
		MODEM_APCALPHSM2 = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_APCALPHSM2,
		MODEM_APCMAXTXP = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_APCMAXTXP,
		MODEM_APCMINTXP = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_APCMINTXP,
		MODEM_APCNOISSEL = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_APCNOISSEL,
		MODEM_AUTODETECTHDR = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_AUTODETECTHDR,
		MODEM_CHIRP_THRESHOLD = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_CHIRP_THRESHOLD,
		MODEM_DATARETRY = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_DATARETRY,
		MODEM_DEVENABLE = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_DEVENABLE,
		MODEM_DOMAINKEY = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_DOMAINKEY,
		MODEM_FWDDELAY = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_FWDDELAY,
		MODEM_HEADERRATE = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_HEADERRATE,
		MODEM_INPUTMODE = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_INPUTMODE,
		MODEM_L2PROTOCOL = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_L2PROTOCOL,
		MODEM_LOCALADDR = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_LOCALADDR,
		MODEM_OPMODE = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_OPMODE,
		MODEM_PRNTHEX = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_PRNTHEX,
		MODEM_REMOTEADDR = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_REMOTEADDR,
		MODEM_RSVD1 = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_RSVD1,
		MODEM_RXPKTTYPE = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_RXPKTTYPE,
		MODEM_SHOWBADDATA = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_SHOWBADDATA,
		MODEM_SMARTRETRY = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_SMARTRETRY,
		MODEM_STARTTONES = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_STARTTONES,
		MODEM_TXATTEN = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_TXATTEN,
		MODEM_TXPOWER = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_TXPOWER,
		MODEM_TXRATE = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_TXRATE,
		MODEM_UNUSED1 = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_UNUSED1,
		MODEM_UNUSED2 = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_UNUSED2,
		MODEM_WAKETONES = ((ushort)mmp_subsys_t.CFG_SECT_MODEM << 8) | (ushort)cfg_modem_param_enum_t.CFG_MODEM_WAKETONES,
		NAV_ALTITUDE = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_ALTITUDE,
		NAV_COMPASS = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_COMPASS,
		NAV_CSOUND = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_CSOUND,
		NAV_DEPTH = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_DEPTH,
		NAV_GPSALT = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_GPSALT,
		NAV_GPSSYNCMSG = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_GPSSYNCMSG,
		NAV_HEADOFFSET = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_HEADOFFSET,
		NAV_LATITUDE = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_LATITUDE,
		NAV_LONGITUDE = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_LONGITUDE,
		NAV_PITCH = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_PITCH,
		NAV_PITCHOFFSET = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_PITCHOFFSET,
		NAV_REPLY_DATA = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_REPLY_DATA,
		NAV_ROLL = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_ROLL,
		NAV_ROLLOFFSET = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_ROLLOFFSET,
		NAV_SYNCRANGING = ((ushort)mmp_subsys_t.CFG_SECT_NAV << 8) | (ushort)cfg_nav_param_enum_t.CFG_NAV_SYNCRANGING,
		PRESSURE_AINCHNL = ((ushort)mmp_subsys_t.CFG_SECT_PRESSURE << 8) | (ushort)cfg_pressure_param_enum_t.CFG_PRESSURE_AINCHNL,
		PRESSURE_ATMOFFSET = ((ushort)mmp_subsys_t.CFG_SECT_PRESSURE << 8) | (ushort)cfg_pressure_param_enum_t.CFG_PRESSURE_ATMOFFSET,
		PRESSURE_METERSPERPSI = ((ushort)mmp_subsys_t.CFG_SECT_PRESSURE << 8) | (ushort)cfg_pressure_param_enum_t.CFG_PRESSURE_METERSPERPSI,
		PRESSURE_PSI = ((ushort)mmp_subsys_t.CFG_SECT_PRESSURE << 8) | (ushort)cfg_pressure_param_enum_t.CFG_PRESSURE_PSI,
		RECORDER_FRONTEND = ((ushort)mmp_subsys_t.CFG_SECT_RECORDER << 8) | (ushort)cfg_recorder_param_enum_t.CFG_RECORDER_FRONTEND,
		RECORDER_NAMEFORMAT = ((ushort)mmp_subsys_t.CFG_SECT_RECORDER << 8) | (ushort)cfg_recorder_param_enum_t.CFG_RECORDER_NAMEFORMAT,
		RECORDER_RECFORMAT = ((ushort)mmp_subsys_t.CFG_SECT_RECORDER << 8) | (ushort)cfg_recorder_param_enum_t.CFG_RECORDER_RECFORMAT,
		RECORDER_RECMODE = ((ushort)mmp_subsys_t.CFG_SECT_RECORDER << 8) | (ushort)cfg_recorder_param_enum_t.CFG_RECORDER_RECMODE,
		RECORDER_RXSENS = ((ushort)mmp_subsys_t.CFG_SECT_RECORDER << 8) | (ushort)cfg_recorder_param_enum_t.CFG_RECORDER_RXSENS,
		RELEASE_ACOUTRIGTERM = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_ACOUTRIGTERM,
		RELEASE_FSKRLSDUR = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_FSKRLSDUR,
		RELEASE_LSTCOMMSCNT = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_LSTCOMMSCNT,
		RELEASE_MOTORTYPE = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_MOTORTYPE,
		RELEASE_RLSCODE = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_RLSCODE,
		RELEASE_RLSMAXENATIME = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_RLSMAXENATIME,
		RELEASE_RLSMINENATIME = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_RLSMINENATIME,
		RELEASE_TIMEDRELEASE = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_TIMEDRELEASE,
		RELEASE_UNUSED1 = ((ushort)mmp_subsys_t.CFG_SECT_RELEASE << 8) | (ushort)cfg_release_param_enum_t.CFG_RELEASE_UNUSED1,
		SERIAL_LPFLOWCTL = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_LPFLOWCTL,
		SERIAL_P1BAUD = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1BAUD,
		SERIAL_P1ECHOCHAR = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1ECHOCHAR,
		SERIAL_P1FLOWCTL = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1FLOWCTL,
		SERIAL_P1IDLEPOL = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1IDLEPOL,
		SERIAL_P1MODE = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1MODE,
		SERIAL_P1NOSLEEP = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1NOSLEEP,
		SERIAL_P1PROMPT = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1PROMPT,
		SERIAL_P1PROTOCOL = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1PROTOCOL,
		SERIAL_P1STRIPB7 = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P1STRIPB7,
		SERIAL_P2BAUD = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2BAUD,
		SERIAL_P2ECHOCHAR = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2ECHOCHAR,
		SERIAL_P2FLOWCTL = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2FLOWCTL,
		SERIAL_P2IDLEPOL = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2IDLEPOL,
		SERIAL_P2MODE = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2MODE,
		SERIAL_P2NOSLEEP = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2NOSLEEP,
		SERIAL_P2PROMPT = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2PROMPT,
		SERIAL_P2PROTOCOL = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2PROTOCOL,
		SERIAL_P2STRIPB7 = ((ushort)mmp_subsys_t.CFG_SECT_SERIAL << 8) | (ushort)cfg_serial_param_enum_t.CFG_SERIAL_P2STRIPB7,
		SYSTEM_ARWAKEHIB = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_ARWAKEHIB,
		SYSTEM_ASCIIBIN = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_ASCIIBIN,
		SYSTEM_AUXINP = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_AUXINP,
		SYSTEM_AUXOUT = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_AUXOUT,
		SYSTEM_AWAKEPOWER = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_AWAKEPOWER,
		SYSTEM_AWAKETIMER = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_AWAKETIMER,
		SYSTEM_BANDWIDTH = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_BANDWIDTH,
		SYSTEM_BATTERYCAPACITY = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_BATTERYCAPACITY,
		SYSTEM_BATTERYMFGDATE = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_BATTERYMFGDATE,
		SYSTEM_BATTERYTYPE = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_BATTERYTYPE,
		SYSTEM_CARRFREQ = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_CARRFREQ,
		SYSTEM_CMFASTWAKE = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_CMFASTWAKE,
		SYSTEM_CMWAKEHIB = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_CMWAKEHIB,
		SYSTEM_CMWAKELISTEN = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_CMWAKELISTEN,
		SYSTEM_COMPMDMRST = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_COMPMDMRST,
		SYSTEM_FHTHRESH = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_FHTHRESH,
		SYSTEM_HALFBW = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_HALFBW,
		SYSTEM_IDLETIMER = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_IDLETIMER,
		SYSTEM_IOMODE0 = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_IOMODE0,
		SYSTEM_MINOPVOLT = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_MINOPVOLT,
		SYSTEM_NAMEFORMAT = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_NAMEFORMAT,
		SYSTEM_PROMPT = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_PROMPT,
		SYSTEM_PULLUP0 = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_PULLUP0,
		SYSTEM_PULLUP1 = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_PULLUP1,
		SYSTEM_PWRONTIMER = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_PWRONTIMER,
		SYSTEM_RLSTYPE = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_RLSTYPE,
		SYSTEM_RXSENS = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_RXSENS,
		SYSTEM_SYNCOUT = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_SYNCOUT,
		SYSTEM_SYNCPPS = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_SYNCPPS,
		SYSTEM_TILTAXIS = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_TILTAXIS,
		SYSTEM_TXINTERP = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_TXINTERP,
		SYSTEM_TXSENS = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_TXSENS,
		SYSTEM_UNUSED1 = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_UNUSED1,
		SYSTEM_VERBOSE = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_VERBOSE,
		SYSTEM_VOLCONT = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_VOLCONT,
		SYSTEM_WAKETHRESH = ((ushort)mmp_subsys_t.CFG_SECT_SYSTEM << 8) | (ushort)cfg_system_param_enum_t.CFG_SYSTEM_WAKETHRESH,
		TEST_DBGLVL = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_DBGLVL,
		TEST_PKTECHO = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_PKTECHO,
		TEST_PKTSIZE = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_PKTSIZE,
		TEST_RCVALL = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_RCVALL,
		TEST_RSPDELAY = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_RSPDELAY,
		TEST_SIMACDLY = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_SIMACDLY,
		TEST_TXSATURATE = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_TXSATURATE,
		TEST_UNUSED1 = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_UNUSED1,
		TEST_UNUSED2 = ((ushort)mmp_subsys_t.CFG_SECT_TEST << 8) | (ushort)cfg_test_param_enum_t.CFG_TEST_UNUSED2,
		TRANSPORT_DST1 = ((ushort)mmp_subsys_t.CFG_SECT_TRANSPORT << 8) | (ushort)cfg_transport_param_enum_t.CFG_TRANSPORT_DST1,
		TRANSPORT_DST2 = ((ushort)mmp_subsys_t.CFG_SECT_TRANSPORT << 8) | (ushort)cfg_transport_param_enum_t.CFG_TRANSPORT_DST2,
		TRANSPORT_DST3 = ((ushort)mmp_subsys_t.CFG_SECT_TRANSPORT << 8) | (ushort)cfg_transport_param_enum_t.CFG_TRANSPORT_DST3,
		TRANSPORT_DST4 = ((ushort)mmp_subsys_t.CFG_SECT_TRANSPORT << 8) | (ushort)cfg_transport_param_enum_t.CFG_TRANSPORT_DST4,
		TRANSPORT_L4ENB = ((ushort)mmp_subsys_t.CFG_SECT_TRANSPORT << 8) | (ushort)cfg_transport_param_enum_t.CFG_TRANSPORT_L4ENB,
		TRANSPORT_SRCP1 = ((ushort)mmp_subsys_t.CFG_SECT_TRANSPORT << 8) | (ushort)cfg_transport_param_enum_t.CFG_TRANSPORT_SRCP1,
		TRANSPORT_SRCP2 = ((ushort)mmp_subsys_t.CFG_SECT_TRANSPORT << 8) | (ushort)cfg_transport_param_enum_t.CFG_TRANSPORT_SRCP2,
		TRANSPORT_TPMODE = ((ushort)mmp_subsys_t.CFG_SECT_TRANSPORT << 8) | (ushort)cfg_transport_param_enum_t.CFG_TRANSPORT_TPMODE,
		USBL_AUTO_DELAY = ((ushort)mmp_subsys_t.CFG_SECT_USBL << 8) | (ushort)cfg_usbl_param_enum_t.CFG_USBL_AUTO_DELAY,
		USBL_AUTO_QUERY = ((ushort)mmp_subsys_t.CFG_SECT_USBL << 8) | (ushort)cfg_usbl_param_enum_t.CFG_USBL_AUTO_QUERY,
		USBL_DEPTH_QUERY = ((ushort)mmp_subsys_t.CFG_SECT_USBL << 8) | (ushort)cfg_usbl_param_enum_t.CFG_USBL_DEPTH_QUERY,
		USBL_FORMAT = ((ushort)mmp_subsys_t.CFG_SECT_USBL << 8) | (ushort)cfg_usbl_param_enum_t.CFG_USBL_FORMAT,
		USBL_REPEAT_QUERY = ((ushort)mmp_subsys_t.CFG_SECT_USBL << 8) | (ushort)cfg_usbl_param_enum_t.CFG_USBL_REPEAT_QUERY,
		USBL_XDCER_DEPTH = ((ushort)mmp_subsys_t.CFG_SECT_USBL << 8) | (ushort)cfg_usbl_param_enum_t.CFG_USBL_XDCER_DEPTH,
		VERSION_DBVERSION = ((ushort)mmp_subsys_t.CFG_SECT_VERSION << 8) | (ushort)cfg_version_param_enum_t.CFG_VERSION_DBVERSION,
		VERSION_SWAPPNAME = ((ushort)mmp_subsys_t.CFG_SECT_VERSION << 8) | (ushort)cfg_version_param_enum_t.CFG_VERSION_SWAPPNAME,
		VERSION_SWVERSION = ((ushort)mmp_subsys_t.CFG_SECT_VERSION << 8) | (ushort)cfg_version_param_enum_t.CFG_VERSION_SWVERSION,
		XPND_AGCREF = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_AGCREF,
		XPND_BANDWIDTH = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_BANDWIDTH,
		XPND_CHIRP_RESP = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_CHIRP_RESP,
		XPND_GAPSRX = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_GAPSRX,
		XPND_GAPSTX = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_GAPSTX,
		XPND_GAPSWAKE = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_GAPSWAKE,
		XPND_HPR400CHAN = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_HPR400CHAN,
		XPND_LBLMODE = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_LBLMODE,
		XPND_LOGRESULTS = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_LOGRESULTS,
		XPND_RESPFREQ = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_RESPFREQ,
		XPND_RESPONDER = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_RESPONDER,
		XPND_RXFREQ = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_RXFREQ,
		XPND_RXLOCKOUT = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_RXLOCKOUT,
		XPND_RXTHRESH = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_RXTHRESH,
		XPND_RXTONEDUR = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_RXTONEDUR,
		XPND_TAT = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_TAT,
		XPND_TXTONEDUR = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_TXTONEDUR,
		XPND_XPNDEMUMODE = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_XPNDEMUMODE,
		XPND_XPNDEMUTAT = ((ushort)mmp_subsys_t.CFG_SECT_XPND << 8) | (ushort)cfg_xpnd_param_enum_t.CFG_XPND_XPNDEMUTAT,
	};



	//===========================================================


// 
// Common header for GET/SET/EXECUTE/NOTIFY packets
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_gsxn_t : iMMP
	{
		public byte _xid;
		public byte _type;
		public byte _nparms;

		// Default constructor
		public mmp_gsxn_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_gsxn_t(byte a_xid = 0, byte a_type = 0, byte a_nparms = 0)
		{
			_xid = a_xid;
			_type = a_type;
			_nparms = a_nparms;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_gsxn_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_xid;
			offset += sizeof(byte);
			data[offset] = (byte)_type;
			offset += sizeof(byte);
			data[offset] = (byte)_nparms;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_gsxn_t deserialize(byte[] data)
		{
			int offset = 0;

			_xid = (byte)data[offset];
			offset += sizeof(byte);
			_type = (byte)data[offset];
			offset += sizeof(byte);
			_nparms = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================


// 
// Specifier for system/field/len use with GET/SET/NOTIFY packets
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_sfl_t : iMMP
	{
		public byte _subsys;
		public byte _field;
		public byte _len_msb;
		public byte _len_lsb;

		// Default constructor
		public mmp_sfl_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_sfl_t(byte a_subsys = 0, byte a_field = 0, byte a_len_msb = 0, byte a_len_lsb = 0)
		{
			_subsys = a_subsys;
			_field = a_field;
			_len_msb = a_len_msb;
			_len_lsb = a_len_lsb;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_sfl_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_subsys;
			offset += sizeof(byte);
			data[offset] = (byte)_field;
			offset += sizeof(byte);
			data[offset] = (byte)_len_msb;
			offset += sizeof(byte);
			data[offset] = (byte)_len_lsb;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_sfl_t deserialize(byte[] data)
		{
			int offset = 0;

			_subsys = (byte)data[offset];
			offset += sizeof(byte);
			_field = (byte)data[offset];
			offset += sizeof(byte);
			_len_msb = (byte)data[offset];
			offset += sizeof(byte);
			_len_lsb = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================


// Used for any command that takes a single remote modem address as an argument
// commands REMOTE_GETSREGS, REMOTE_TESTLINK, etc. (request)
//------------------------------
// 
// cmd=STD::REMOTE_GETSREGS
// cmd=STD::REMOTE_TESTLINK
// cmd=STD::REMOTE_GETBATT
// cmd=STD::REMOTE_CMWAKEUP
// cmd=STD::REMOTE_GETAGCHIST
// cmd=STD::REMOTE_GETBATTCHG
// cmd=STD::REMOTE_GETMETER
// cmd=STD::REMOTE_RESET
// cmd=STD::REMOTE_HANGUP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_t : iMMP
	{
		public ushort _modem_ID;

		// Default constructor
		public mmp_remote_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_t(ushort a_modem_ID = 0)
		{
			_modem_ID = a_modem_ID;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_modem_ID)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_t deserialize(byte[] data)
		{
			int offset = 0;

			_modem_ID = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// Use for any command that takes a single remote modem address as an argument, where that address may be
// 0xFFFF to indicate the local modem.  The only difference from mmp_remote_t is the comment for documentation
// purposes.
//------------------------------
// 
// cmd=DATALOG::CLEAR
// cmd=DATALOG::SIZE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_or_local_t : iMMP
	{
		public ushort _modem_ID;

		// Default constructor
		public mmp_remote_or_local_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_or_local_t(ushort a_modem_ID = 0)
		{
			_modem_ID = a_modem_ID;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_or_local_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_modem_ID)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_or_local_t deserialize(byte[] data)
		{
			int offset = 0;

			_modem_ID = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// 
// cmd=SWCMD::LOADROUTES
// cmd=SWCMD::SAVEROUTES
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_pathname_t : iMMP
	{
		public short _len;
		public sbyte[] _path;

		// Default constructor
		public mmp_pathname_t() : this(0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_pathname_t(short a_len = 0, sbyte[] a_path = null)
		{
			_len = a_len;
			_path = a_path ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_pathname_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + (_path.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			for (int i = 0; i < _path.Length; i++)
			{
				data[offset] = (byte)_path[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_pathname_t deserialize(byte[] data)
		{
			int offset = 0;

			_len = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);

			int i = 0;
			_path = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_path[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// This struct is computed from a battery_rec_t record using config params and other factors from the local
// environment
// 
// cmdresult=STD::BATT_METER
// cmdresult=STD::REMOTE_GETMETER
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class battery_metering_info_t : iMMP
	{
		public uint _time;
		public uint _rxactive_sec_x10;
		public uint _txactive_wattsec_x10;
		public uint _lpactive_sec;
		public uint _hibactive_sec;
		public uint _age_factor_x10K;
		public uint _run_age_x10K;
		public uint _watt_hours_extracted_x1000;
		public ushort _tot_age;
		public short _mfg_date;
		public short _capacity;
		public short _pct_remaining_x10;
		public short[] _voltage;
		public short _temp_C_x10;
		public short _addr;

		// Default constructor
		public battery_metering_info_t() : this(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, (short[])null, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public battery_metering_info_t(uint a_time = 0, uint a_rxactive_sec_x10 = 0, uint a_txactive_wattsec_x10 = 0, uint a_lpactive_sec = 0, uint a_hibactive_sec = 0, uint a_age_factor_x10K = 0, uint a_run_age_x10K = 0, uint a_watt_hours_extracted_x1000 = 0, ushort a_tot_age = 0, short a_mfg_date = 0, short a_capacity = 0, short a_pct_remaining_x10 = 0, short[] a_voltage = null, short a_temp_C_x10 = 0, short a_addr = 0)
		{
			_time = a_time;
			_rxactive_sec_x10 = a_rxactive_sec_x10;
			_txactive_wattsec_x10 = a_txactive_wattsec_x10;
			_lpactive_sec = a_lpactive_sec;
			_hibactive_sec = a_hibactive_sec;
			_age_factor_x10K = a_age_factor_x10K;
			_run_age_x10K = a_run_age_x10K;
			_watt_hours_extracted_x1000 = a_watt_hours_extracted_x1000;
			_tot_age = a_tot_age;
			_mfg_date = a_mfg_date;
			_capacity = a_capacity;
			_pct_remaining_x10 = a_pct_remaining_x10;
			_voltage = a_voltage ?? new short[2];
			_temp_C_x10 = a_temp_C_x10;
			_addr = a_addr;
		}

		// Constructor to initialize class from serial data stream containing field data
		public battery_metering_info_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(short) + (_voltage.Length * sizeof(short)) + sizeof(short) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_rxactive_sec_x10)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_txactive_wattsec_x10)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_lpactive_sec)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_hibactive_sec)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_age_factor_x10K)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_run_age_x10K)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_watt_hours_extracted_x1000)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_tot_age)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_mfg_date)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_capacity)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_pct_remaining_x10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			for (int i = 0; i < _voltage.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_voltage[i])), 0, data, offset, sizeof(short));
				offset += sizeof(short);
			}
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_temp_C_x10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public battery_metering_info_t deserialize(byte[] data)
		{
			int offset = 0;

			_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_rxactive_sec_x10 = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_txactive_wattsec_x10 = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_lpactive_sec = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_hibactive_sec = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_age_factor_x10K = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_run_age_x10K = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_watt_hours_extracted_x1000 = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_tot_age = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_mfg_date = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_capacity = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_pct_remaining_x10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);

			int i = 0;
			for (i = 0; i < _voltage.Length; )
			{
				_voltage[i++] = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
				offset += sizeof(short);
			}
			_temp_C_x10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_addr = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



//*************************
// DATALOG Command Structs & Values
//*************************

// command READ_DATA
//------------------------------
// 
// cmd=DATALOG::READ_DATA
// cmd=DATALOG::READ_SECTOR
// cmd=DATALOG::READ_PAGE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_read_t : iMMP
	{
		public ushort _modem_ID;
		public ushort _number;

		// Default constructor
		public mmp_datalog_read_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_read_t(ushort a_modem_ID = 0, ushort a_number = 0)
		{
			_modem_ID = a_modem_ID;
			_number = a_number;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_read_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_modem_ID)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_number)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_read_t deserialize(byte[] data)
		{
			int offset = 0;

			_modem_ID = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_number = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command WRITE_DATA
//------------------------------
// 
// cmd=DATALOG::WRITE_DATA
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_write_t : iMMP
	{
		public ushort _modem_ID;
		public ushort _bytes;
		public sbyte[] _data;

		// Default constructor
		public mmp_datalog_write_t() : this(0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_write_t(ushort a_modem_ID = 0, ushort a_bytes = 0, sbyte[] a_data = null)
		{
			_modem_ID = a_modem_ID;
			_bytes = a_bytes;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_write_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_modem_ID)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_bytes)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_write_t deserialize(byte[] data)
		{
			int offset = 0;

			_modem_ID = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_bytes = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// command SEEK
//------------------------------
// 
// cmd=DATALOG::SEEK
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_seek_t : iMMP
	{
		public uint _pointer;

		// Default constructor
		public mmp_datalog_seek_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_seek_t(uint a_pointer = 0)
		{
			_pointer = a_pointer;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_seek_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_pointer)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_seek_t deserialize(byte[] data)
		{
			int offset = 0;

			_pointer = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================



// command FIND
//------------------------------
// 
// cmd=DATALOG::FIND
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_find_t : iMMP
	{
		public ushort _size;
		public sbyte[] _query;

		// Default constructor
		public mmp_datalog_find_t() : this(0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_find_t(ushort a_size = 0, sbyte[] a_query = null)
		{
			_size = a_size;
			_query = a_query ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_find_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + (_query.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_size)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _query.Length; i++)
			{
				data[offset] = (byte)_query[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_find_t deserialize(byte[] data)
		{
			int offset = 0;

			_size = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_query = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_query[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// command DUMP
//------------------------------
// 
// cmd=DATALOG::DUMP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_dump_t : iMMP
	{
		public uint _byte_offset_l;
		public byte _byte_offset_h;
		public byte _source;
		public ushort _byte_count;

		// Default constructor
		public mmp_datalog_dump_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_dump_t(uint a_byte_offset_l = 0, byte a_byte_offset_h = 0, byte a_source = 0, ushort a_byte_count = 0)
		{
			_byte_offset_l = a_byte_offset_l;
			_byte_offset_h = a_byte_offset_h;
			_source = a_source;
			_byte_count = a_byte_count;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_dump_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(byte) + sizeof(byte) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_byte_offset_l)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			data[offset] = (byte)_byte_offset_h;
			offset += sizeof(byte);
			data[offset] = (byte)_source;
			offset += sizeof(byte);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_byte_count)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_dump_t deserialize(byte[] data)
		{
			int offset = 0;

			_byte_offset_l = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_byte_offset_h = (byte)data[offset];
			offset += sizeof(byte);
			_source = (byte)data[offset];
			offset += sizeof(byte);
			_byte_count = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command SRCINFO
//------------------------------
// 
// cmd=DATALOG::SRCINFO
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_srcinfo_t : iMMP
	{
		public ushort _source_flags;

		// Default constructor
		public mmp_datalog_srcinfo_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_srcinfo_t(ushort a_source_flags = 0)
		{
			_source_flags = a_source_flags;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_srcinfo_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_source_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_srcinfo_t deserialize(byte[] data)
		{
			int offset = 0;

			_source_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// command REMOTE_GETDLOGBLK
//------------------------------
// 
// cmd=DATALOG::REMOTE_GETDLOGBLK
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_remote_getdlogblk_t : iMMP
	{
		public ushort _addr;
		public ushort _byte_count;
		public uint _byte_offset_l;
		public byte _byte_offset_h;
		public byte _source;

		// Default constructor
		public mmp_datalog_remote_getdlogblk_t() : this(0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_remote_getdlogblk_t(ushort a_addr = 0, ushort a_byte_count = 0, uint a_byte_offset_l = 0, byte a_byte_offset_h = 0, byte a_source = 0)
		{
			_addr = a_addr;
			_byte_count = a_byte_count;
			_byte_offset_l = a_byte_offset_l;
			_byte_offset_h = a_byte_offset_h;
			_source = a_source;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_remote_getdlogblk_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(uint) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_byte_count)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_byte_offset_l)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			data[offset] = (byte)_byte_offset_h;
			offset += sizeof(byte);
			data[offset] = (byte)_source;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_remote_getdlogblk_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_byte_count = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_byte_offset_l = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_byte_offset_h = (byte)data[offset];
			offset += sizeof(byte);
			_source = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================



//*************************
// DATALOG Structs and Values for IFACE::CMDRESULT messages
//*************************

// command SIZE
//------------------------------
// 
// cmdresult=DATALOG::SIZE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_size_t : iMMP
	{
		public uint _size;
		public ushort _use_mb;

		// Default constructor
		public mmp_datalog_cmdresult_size_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_size_t(uint a_size = 0, ushort a_use_mb = 0)
		{
			_size = a_size;
			_use_mb = a_use_mb;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_size_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_size)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_use_mb)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_size_t deserialize(byte[] data)
		{
			int offset = 0;

			_size = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_use_mb = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command READ
//------------------------------
// 
// cmdresult=DATALOG::READ_DATA
// cmdresult=DATALOG::READ_SECTOR
// cmdresult=DATALOG::READ_PAGE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_read_t : iMMP
	{
		public uint _length;
		public sbyte[] _data;

		// Default constructor
		public mmp_datalog_cmdresult_read_t() : this(0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_read_t(uint a_length = 0, sbyte[] a_data = null)
		{
			_length = a_length;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_read_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_length)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_read_t deserialize(byte[] data)
		{
			int offset = 0;

			_length = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// command TELL
//------------------------------
// 
// cmdresult=DATALOG::TELL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_tell_t : iMMP
	{
		public uint _position;
		public uint _remaining;

		// Default constructor
		public mmp_datalog_cmdresult_tell_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_tell_t(uint a_position = 0, uint a_remaining = 0)
		{
			_position = a_position;
			_remaining = a_remaining;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_tell_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_position)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_remaining)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_tell_t deserialize(byte[] data)
		{
			int offset = 0;

			_position = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_remaining = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================



// command WRITE
//------------------------------
// 
// cmdresult=DATALOG::WRITE_DATA
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_write_data_t : iMMP
	{
		public ushort _bytes_writ;
		public short _status;

		// Default constructor
		public mmp_datalog_cmdresult_write_data_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_write_data_t(ushort a_bytes_writ = 0, short a_status = 0)
		{
			_bytes_writ = a_bytes_writ;
			_status = a_status;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_write_data_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_bytes_writ)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_status)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_write_data_t deserialize(byte[] data)
		{
			int offset = 0;

			_bytes_writ = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_status = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// command LIST
//------------------------------
// 
// cmdresult=DATALOG::LIST
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_list_t : iMMP
	{
		public uint _byte_count_l;
		public byte _byte_count_h;
		public byte _storeloc;
		public ushort _source_flags;
		public uint _record_count;
		public uint _first_rec_time;
		public uint _last_rec_time;

		// Default constructor
		public mmp_datalog_cmdresult_list_t() : this(0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_list_t(uint a_byte_count_l = 0, byte a_byte_count_h = 0, byte a_storeloc = 0, ushort a_source_flags = 0, uint a_record_count = 0, uint a_first_rec_time = 0, uint a_last_rec_time = 0)
		{
			_byte_count_l = a_byte_count_l;
			_byte_count_h = a_byte_count_h;
			_storeloc = a_storeloc;
			_source_flags = a_source_flags;
			_record_count = a_record_count;
			_first_rec_time = a_first_rec_time;
			_last_rec_time = a_last_rec_time;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_list_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(byte) + sizeof(byte) + sizeof(ushort) + sizeof(uint) + sizeof(uint) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_byte_count_l)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			data[offset] = (byte)_byte_count_h;
			offset += sizeof(byte);
			data[offset] = (byte)_storeloc;
			offset += sizeof(byte);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_source_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_record_count)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_first_rec_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_last_rec_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_list_t deserialize(byte[] data)
		{
			int offset = 0;

			_byte_count_l = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_byte_count_h = (byte)data[offset];
			offset += sizeof(byte);
			_storeloc = (byte)data[offset];
			offset += sizeof(byte);
			_source_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_record_count = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_first_rec_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_last_rec_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================


// command FIND
//------------------------------
// 
// cmdresult=DATALOG::FIND
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_find_t : iMMP
	{
		public uint _recno;
		public uint _time;
		public ushort _source_flags;
		public ushort _size;
		public sbyte[] _data;

		// Default constructor
		public mmp_datalog_cmdresult_find_t() : this(0, 0, 0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_find_t(uint a_recno = 0, uint a_time = 0, ushort a_source_flags = 0, ushort a_size = 0, sbyte[] a_data = null)
		{
			_recno = a_recno;
			_time = a_time;
			_source_flags = a_source_flags;
			_size = a_size;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_find_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(ushort) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_recno)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_source_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_size)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_find_t deserialize(byte[] data)
		{
			int offset = 0;

			_recno = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_source_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_size = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// command DUMP
//------------------------------
// 
// cmdresult=DATALOG::DUMP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_dump_t : iMMP
	{
		public uint _byte_offset_l;
		public byte _byte_offset_h;
		public byte _source;
		public ushort _length;
		public sbyte[] _data;

		// Default constructor
		public mmp_datalog_cmdresult_dump_t() : this(0, 0, 0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_dump_t(uint a_byte_offset_l = 0, byte a_byte_offset_h = 0, byte a_source = 0, ushort a_length = 0, sbyte[] a_data = null)
		{
			_byte_offset_l = a_byte_offset_l;
			_byte_offset_h = a_byte_offset_h;
			_source = a_source;
			_length = a_length;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_dump_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(byte) + sizeof(byte) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_byte_offset_l)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			data[offset] = (byte)_byte_offset_h;
			offset += sizeof(byte);
			data[offset] = (byte)_source;
			offset += sizeof(byte);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_length)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_dump_t deserialize(byte[] data)
		{
			int offset = 0;

			_byte_offset_l = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_byte_offset_h = (byte)data[offset];
			offset += sizeof(byte);
			_source = (byte)data[offset];
			offset += sizeof(byte);
			_length = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// Use to overlay the variable-length source_counts[] array in mmp_datalog_cmdresult_srcinfo_t, one for each raised bit flag
// The source and byte_count_h fields are 16-bit because multiple instances of this structure will be packed
// and the compiler fleshes the sizeof() the struct out to the next 32-bit interval anyway, so it is
// reflecting reality. 
// 
// subfield=mmp_data_cmdresult_srcinfo_t::source_counts
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_source_counts_t : iMMP
	{
		public uint _record_count;
		public uint _byte_count_l;
		public ushort _byte_count_h;
		public ushort _source;

		// Default constructor
		public mmp_datalog_cmdresult_source_counts_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_source_counts_t(uint a_record_count = 0, uint a_byte_count_l = 0, ushort a_byte_count_h = 0, ushort a_source = 0)
		{
			_record_count = a_record_count;
			_byte_count_l = a_byte_count_l;
			_byte_count_h = a_byte_count_h;
			_source = a_source;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_source_counts_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_record_count)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_byte_count_l)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_byte_count_h)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_source)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_source_counts_t deserialize(byte[] data)
		{
			int offset = 0;

			_record_count = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_byte_count_l = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_byte_count_h = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_source = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command SRCINFO
//------------------------------
// 
// cmdresult=DATALOG::SRCINFO
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_datalog_cmdresult_srcinfo_t : iMMP
	{
		public ushort _source_flags;
		public byte _storeloc;
		public byte _size;
		public ushort[] _source_counts;

		// Default constructor
		public mmp_datalog_cmdresult_srcinfo_t() : this(0, 0, 0, (ushort[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_datalog_cmdresult_srcinfo_t(ushort a_source_flags = 0, byte a_storeloc = 0, byte a_size = 0, ushort[] a_source_counts = null)
		{
			_source_flags = a_source_flags;
			_storeloc = a_storeloc;
			_size = a_size;
			_source_counts = a_source_counts ?? new ushort[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_datalog_cmdresult_srcinfo_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(byte) + sizeof(byte) + (_source_counts.Length * sizeof(ushort))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_source_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			data[offset] = (byte)_storeloc;
			offset += sizeof(byte);
			data[offset] = (byte)_size;
			offset += sizeof(byte);
			for (int i = 0; i < _source_counts.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_source_counts[i])), 0, data, offset, sizeof(ushort));
				offset += sizeof(ushort);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_datalog_cmdresult_srcinfo_t deserialize(byte[] data)
		{
			int offset = 0;

			_source_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_storeloc = (byte)data[offset];
			offset += sizeof(byte);
			_size = (byte)data[offset];
			offset += sizeof(byte);

			int i = 0;
			_source_counts = new ushort[(data.Length - offset) / sizeof(ushort)];
			while (offset < data.Length)
			{
				_source_counts[i++] = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
				offset += sizeof(ushort);
			}
			return this;
		}
	};

	//===========================================================




//*************************
// RNGRLS Command Structs & Values
//*************************

// command TRANSPOND
//------------------------------
// 
// cmd=RNGRLS::TRANSPOND
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_transpond_t : iMMP
	{
		public uint _freq;
		public ushort _silent;
		public ushort _rcv_only;

		// Default constructor
		public mmp_rngrls_transpond_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_transpond_t(uint a_freq = 0, ushort a_silent = 0, ushort a_rcv_only = 0)
		{
			_freq = a_freq;
			_silent = a_silent;
			_rcv_only = a_rcv_only;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_transpond_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_freq)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_silent)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_rcv_only)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_transpond_t deserialize(byte[] data)
		{
			int offset = 0;

			_freq = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_silent = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_rcv_only = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command TRANSPOND_W_TIMEOUT
//------------------------------
// 
// cmd=RNGRLS::TRANSPOND_W_TIMEOUT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_transpond_w_timeout_t : iMMP
	{
		public uint _freq;
		public ushort _silent;
		public ushort _rcv_only;
		public ushort _timeout_x10;

		// Default constructor
		public mmp_rngrls_transpond_w_timeout_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_transpond_w_timeout_t(uint a_freq = 0, ushort a_silent = 0, ushort a_rcv_only = 0, ushort a_timeout_x10 = 0)
		{
			_freq = a_freq;
			_silent = a_silent;
			_rcv_only = a_rcv_only;
			_timeout_x10 = a_timeout_x10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_transpond_w_timeout_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_freq)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_silent)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_rcv_only)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_timeout_x10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_transpond_w_timeout_t deserialize(byte[] data)
		{
			int offset = 0;

			_freq = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_silent = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_rcv_only = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_timeout_x10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command RANGE, RANGE_W_TIMEOUT
//------------------------------
// 
// cmd=RNGRLS::RANGE
// cmd=RNGRLS::RANGE_W_TIMEOUT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_range_t : iMMP
	{
		public ushort _address;
		public ushort _timeout_x10;

		// Default constructor
		public mmp_rngrls_range_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_range_t(ushort a_address = 0, ushort a_timeout_x10 = 0)
		{
			_address = a_address;
			_timeout_x10 = a_timeout_x10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_range_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_timeout_x10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_range_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_timeout_x10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command RANGE_USBL_REPEAT
//------------------------------
// 
// cmd=RNGRLS::RANGE_USBL_REPEAT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_range_repeat_t : iMMP
	{
		public ushort _address;
		public ushort _timeout_x10;
		public ushort _repeats;

		// Default constructor
		public mmp_rngrls_range_repeat_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_range_repeat_t(ushort a_address = 0, ushort a_timeout_x10 = 0, ushort a_repeats = 0)
		{
			_address = a_address;
			_timeout_x10 = a_timeout_x10;
			_repeats = a_repeats;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_range_repeat_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_timeout_x10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_repeats)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_range_repeat_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_timeout_x10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_repeats = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// command BEARING
//------------------------------
// 
// cmd=RNGRLS::BEARING
// cmd=RNGRLS::BEARING_W_TIMEOUT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_bearing_t : iMMP
	{
		public ushort _address;
		public ushort _type;
		public ushort _tat;
		public ushort _timeout_x10;

		// Default constructor
		public mmp_rngrls_bearing_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_bearing_t(ushort a_address = 0, ushort a_type = 0, ushort a_tat = 0, ushort a_timeout_x10 = 0)
		{
			_address = a_address;
			_type = a_type;
			_tat = a_tat;
			_timeout_x10 = a_timeout_x10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_bearing_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_type)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_tat)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_timeout_x10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_bearing_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_type = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_tat = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_timeout_x10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command NAVDATA
//------------------------------
// 
// cmd=RNGRLS::NAVDATA
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_navdata_t : iMMP
	{
		public ushort _address;
		public ushort _type;

		// Default constructor
		public mmp_rngrls_navdata_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_navdata_t(ushort a_address = 0, ushort a_type = 0)
		{
			_address = a_address;
			_type = a_type;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_navdata_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_type)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_navdata_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_type = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// command ABSREL
//------------------------------
// 
// cmd=RNGRLS::ABSREL
// cmd=RNGRLS::ABSCMPDEP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_absrel_t : iMMP
	{
		public ushort _address;

		// Default constructor
		public mmp_rngrls_absrel_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_absrel_t(ushort a_address = 0)
		{
			_address = a_address;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_absrel_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_absrel_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================




// command STATUS
//------------------------------
// 
// cmd=RNGRLS::RELEASE_STATUS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_release_status_t : iMMP
	{
		public ushort _address;

		// Default constructor
		public mmp_rngrls_release_status_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_release_status_t(ushort a_address = 0)
		{
			_address = a_address;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_release_status_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_release_status_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command SMART_RELEASE / BURNWIRE
//------------------------------
// 
// cmd=RNGRLS::SMART_RELEASE
// cmd=RNGRLS::BURNWIRE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_smart_release_burnwire_t : iMMP
	{
		public ushort _address;
		public ushort _code;

		// Default constructor
		public mmp_rngrls_smart_release_burnwire_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_smart_release_burnwire_t(ushort a_address = 0, ushort a_code = 0)
		{
			_address = a_address;
			_code = a_code;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_smart_release_burnwire_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_code)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_smart_release_burnwire_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_code = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command FSK_RELEASE
//------------------------------
// 
// cmd=RNGRLS::FSK_RELEASE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_fsk_param_t : iMMP
	{
		public ushort _duration;
		public ushort _code;
		public uint _freq;

		// Default constructor
		public mmp_rngrls_fsk_param_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_fsk_param_t(ushort a_duration = 0, ushort a_code = 0, uint a_freq = 0)
		{
			_duration = a_duration;
			_code = a_code;
			_freq = a_freq;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_fsk_param_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_duration)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_code)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_freq)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_fsk_param_t deserialize(byte[] data)
		{
			int offset = 0;

			_duration = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_code = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_freq = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================



// command EDGETECH_RELEASE
//------------------------------
// 
// cmd=RNGRLS::EDGETECH_RELEASE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_edgetech_param_t : iMMP
	{
		public ushort _freq_spec;
		public ushort _code;

		// Default constructor
		public mmp_rngrls_edgetech_param_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_edgetech_param_t(ushort a_freq_spec = 0, ushort a_code = 0)
		{
			_freq_spec = a_freq_spec;
			_code = a_code;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_edgetech_param_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_freq_spec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_code)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_edgetech_param_t deserialize(byte[] data)
		{
			int offset = 0;

			_freq_spec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_code = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command URI_RELEASE
//------------------------------
// 
// cmd=RNGRLS::URI_RELEASE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_uri_param_t : iMMP
	{
		public ushort _code;

		// Default constructor
		public mmp_rngrls_uri_param_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_uri_param_t(ushort a_code = 0)
		{
			_code = a_code;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_uri_param_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_code)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_uri_param_t deserialize(byte[] data)
		{
			int offset = 0;

			_code = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// command GEOPRO_RELEASE
//------------------------------
// 
// cmd=RNGRLS::GEOPRO_RELEASE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_geopro_param_t : iMMP
	{
		public ushort _cmdtype;
		public ushort _addr;

		// Default constructor
		public mmp_rngrls_geopro_param_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_geopro_param_t(ushort a_cmdtype = 0, ushort a_addr = 0)
		{
			_cmdtype = a_cmdtype;
			_addr = a_addr;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_geopro_param_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_cmdtype)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_geopro_param_t deserialize(byte[] data)
		{
			int offset = 0;

			_cmdtype = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command CHANNEL_PROBE
//------------------------------
// 
// cmd=RNGRLS::CHANNEL_PROBE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_channel_probe_param_t : iMMP
	{
		public ushort _addr;
		public ushort _log;

		// Default constructor
		public mmp_rngrls_channel_probe_param_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_channel_probe_param_t(ushort a_addr = 0, ushort a_log = 0)
		{
			_addr = a_addr;
			_log = a_log;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_channel_probe_param_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_log)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_channel_probe_param_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_log = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// command RESPONDER_RANGE
//------------------------------
// 
// cmd=RNGRLS::RESPONDER_RANGE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_responder_range_t : iMMP
	{
		public ushort _timeout_x10;

		// Default constructor
		public mmp_rngrls_responder_range_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_responder_range_t(ushort a_timeout_x10 = 0)
		{
			_timeout_x10 = a_timeout_x10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_responder_range_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_timeout_x10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_responder_range_t deserialize(byte[] data)
		{
			int offset = 0;

			_timeout_x10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command RSERIES_RANGE
//------------------------------
// 
// cmd=RNGRLS::RSERIES_RANGE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_rseries_range_t : iMMP
	{
		public ushort _address;
		public ushort _timeout_x10;

		// Default constructor
		public mmp_rngrls_rseries_range_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_rseries_range_t(ushort a_address = 0, ushort a_timeout_x10 = 0)
		{
			_address = a_address;
			_timeout_x10 = a_timeout_x10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_rseries_range_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_timeout_x10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_rseries_range_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_timeout_x10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command RSERIES_ACTIVATE
//------------------------------
// 
// cmd=RNGRLS::RSERIES_ACTIVATE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_rseries_activate_t : iMMP
	{
		public ushort _address;
		public ushort _wake_up;
		public ushort _awake_mins;

		// Default constructor
		public mmp_rngrls_rseries_activate_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_rseries_activate_t(ushort a_address = 0, ushort a_wake_up = 0, ushort a_awake_mins = 0)
		{
			_address = a_address;
			_wake_up = a_wake_up;
			_awake_mins = a_awake_mins;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_rseries_activate_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_wake_up)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_awake_mins)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_rseries_activate_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_wake_up = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_awake_mins = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command RSERIES_HIBERNATE /  DB lock
//------------------------------
// 
// cmd=RNGRLS::RSERIES_HIBERNATE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_rseries_hib_t : iMMP
	{
		public ushort _address;
		public ushort _wake_up;

		// Default constructor
		public mmp_rngrls_rseries_hib_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_rseries_hib_t(ushort a_address = 0, ushort a_wake_up = 0)
		{
			_address = a_address;
			_wake_up = a_wake_up;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_rseries_hib_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_wake_up)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_rseries_hib_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_wake_up = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command RSERIES_DB_LOCK/UNLOCK
//------------------------------
// 
// cmd=RNGRLS::RSERIES_DB_UNLOCK
// cmd=RNGRLS::RSERIES_DB_LOCK
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_rseries_dblock_t : iMMP
	{
		public ushort _address;
		public ushort _wake_up;
		public uint _serial_no;

		// Default constructor
		public mmp_rngrls_rseries_dblock_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_rseries_dblock_t(ushort a_address = 0, ushort a_wake_up = 0, uint a_serial_no = 0)
		{
			_address = a_address;
			_wake_up = a_wake_up;
			_serial_no = a_serial_no;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_rseries_dblock_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_wake_up)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_serial_no)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_rseries_dblock_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_wake_up = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_serial_no = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================



// command RSERIES_RELEASE
//------------------------------
// 
// cmd=RNGRLS::RSERIES_RELEASE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_rseries_release_t : iMMP
	{
		public ushort _address;
		public ushort _wake_up;
		public ushort _code;

		// Default constructor
		public mmp_rngrls_rseries_release_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_rseries_release_t(ushort a_address = 0, ushort a_wake_up = 0, ushort a_code = 0)
		{
			_address = a_address;
			_wake_up = a_wake_up;
			_code = a_code;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_rseries_release_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_wake_up)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_code)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_rseries_release_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_wake_up = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_code = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// command RSERIES_XPND_MODE / STD_XPND_MODE
//------------------------------
// 
// cmd=RNGRLS::RSERIES_XPND_MODE
// cmd=RNGRLS::STD_XPND_MODE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_xpnd_mode_t : iMMP
	{
		public ushort _address;
		public ushort _wake_up;
		public ushort _xpnd_mode;

		// Default constructor
		public mmp_rngrls_xpnd_mode_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_xpnd_mode_t(ushort a_address = 0, ushort a_wake_up = 0, ushort a_xpnd_mode = 0)
		{
			_address = a_address;
			_wake_up = a_wake_up;
			_xpnd_mode = a_xpnd_mode;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_xpnd_mode_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_wake_up)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_xpnd_mode)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_xpnd_mode_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_wake_up = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_xpnd_mode = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// command VRSERIES_LOCALRLS
//------------------------------
// 
// cmd=RNGRLS::VRSERIES_LOCALRLS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_vrseries_localrls_t : iMMP
	{
		public ushort _code;
		public ushort _delay_s;

		// Default constructor
		public mmp_rngrls_vrseries_localrls_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_vrseries_localrls_t(ushort a_code = 0, ushort a_delay_s = 0)
		{
			_code = a_code;
			_delay_s = a_delay_s;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_vrseries_localrls_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_code)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_delay_s)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_vrseries_localrls_t deserialize(byte[] data)
		{
			int offset = 0;

			_code = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_delay_s = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================




// command ACOUSTIC_TRIGGER
//------------------------------
// 
// cmd=RNGRLS::ACOUSTIC_TRIGGER
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_acoustic_trigger_t : iMMP
	{
		public ushort _address;
		public ushort _code;
		public byte _assert_time;
		public byte _wake_up;

		// Default constructor
		public mmp_rngrls_acoustic_trigger_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_acoustic_trigger_t(ushort a_address = 0, ushort a_code = 0, byte a_assert_time = 0, byte a_wake_up = 0)
		{
			_address = a_address;
			_code = a_code;
			_assert_time = a_assert_time;
			_wake_up = a_wake_up;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_acoustic_trigger_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_code)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			data[offset] = (byte)_assert_time;
			offset += sizeof(byte);
			data[offset] = (byte)_wake_up;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_acoustic_trigger_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_code = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_assert_time = (byte)data[offset];
			offset += sizeof(byte);
			_wake_up = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================


//*************************
// RNGRLS Structs and Values for IFACE::CMDRESULT messages
//*************************

// command RANGE
//------------------------------
// 
// cmdresult=RNGRLS::RANGE
// cmdresult=RNGRLS::RANGE_W_TIMEOUT
// cmdresult=RNGRLS::RSERIES_RANGE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_range_t : iMMP
	{
		public uint _range;
		public uint _rt_time;

		// Default constructor
		public mmp_rngrls_cmdresult_range_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_range_t(uint a_range = 0, uint a_rt_time = 0)
		{
			_range = a_range;
			_rt_time = a_rt_time;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_range_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_range)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_rt_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_range_t deserialize(byte[] data)
		{
			int offset = 0;

			_range = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_rt_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================


// command BEARING
//------------------------------
// This is a subset of mmp_rngrls_cmdresult_navdata_t and must match the start of that structure.  Changes made
// to one must be made to the other to keep them in sync.
// 
// cmdresult=RNGRLS::BEARING
// cmdresult=RNGRLS::BEARING_W_TIMEOUT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_bearing_t : iMMP
	{
		public uint _range;
		public uint _rt_time;
		public int _doppler;
		public short _azimuth;
		public short _elevation;

		// Default constructor
		public mmp_rngrls_cmdresult_bearing_t() : this(0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_bearing_t(uint a_range = 0, uint a_rt_time = 0, int a_doppler = 0, short a_azimuth = 0, short a_elevation = 0)
		{
			_range = a_range;
			_rt_time = a_rt_time;
			_doppler = a_doppler;
			_azimuth = a_azimuth;
			_elevation = a_elevation;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_bearing_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(int) + sizeof(short) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_range)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_rt_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_doppler)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_azimuth)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_bearing_t deserialize(byte[] data)
		{
			int offset = 0;

			_range = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_rt_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_doppler = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_azimuth = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


// command RANGE_USBL_REPEAT
//------------------------------
// This is a subset of mmp_rngrls_cmdresult_navdata_t and must match the start of that structure.  Changes made
// to one must be made to the other to keep them in sync.
// 
// cmdresult=RNGRLS::RANGE_USBL_REPEAT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_range_usbl_repeat_t : iMMP
	{
		public uint _range;
		public uint _trip_time;
		public int _doppler;
		public short _azimuth;
		public short _elevation;

		// Default constructor
		public mmp_rngrls_cmdresult_range_usbl_repeat_t() : this(0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_range_usbl_repeat_t(uint a_range = 0, uint a_trip_time = 0, int a_doppler = 0, short a_azimuth = 0, short a_elevation = 0)
		{
			_range = a_range;
			_trip_time = a_trip_time;
			_doppler = a_doppler;
			_azimuth = a_azimuth;
			_elevation = a_elevation;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_range_usbl_repeat_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(int) + sizeof(short) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_range)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_trip_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_doppler)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_azimuth)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_range_usbl_repeat_t deserialize(byte[] data)
		{
			int offset = 0;

			_range = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_trip_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_doppler = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_azimuth = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// command NAVDATA
//------------------------------
// This is a superset of mmp_rngrls_cmdresult_bearing_t and the start of this structure must match the 
// entirety of that structure.  Changes made to one must be made to the other to keep them in sync.
// 
// cmdresult=RNGRLS::NAVDATA
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_navdata_t : iMMP
	{
		public uint _range;
		public uint _rt_time;
		public uint _type;
		public short _azimuth;
		public short _elevation;
		public int _latitude;
		public int _longitude;
		public int _depth;
		public int _altitude;

		// Default constructor
		public mmp_rngrls_cmdresult_navdata_t() : this(0, 0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_navdata_t(uint a_range = 0, uint a_rt_time = 0, uint a_type = 0, short a_azimuth = 0, short a_elevation = 0, int a_latitude = 0, int a_longitude = 0, int a_depth = 0, int a_altitude = 0)
		{
			_range = a_range;
			_rt_time = a_rt_time;
			_type = a_type;
			_azimuth = a_azimuth;
			_elevation = a_elevation;
			_latitude = a_latitude;
			_longitude = a_longitude;
			_depth = a_depth;
			_altitude = a_altitude;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_navdata_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(short) + sizeof(short) + sizeof(int) + sizeof(int) + sizeof(int) + sizeof(int)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_range)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_rt_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_type)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_azimuth)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_latitude)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_longitude)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_depth)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_altitude)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_navdata_t deserialize(byte[] data)
		{
			int offset = 0;

			_range = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_rt_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_type = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_azimuth = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_latitude = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_longitude = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_depth = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_altitude = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			return this;
		}
	};

	//===========================================================



// command ABSREL
//------------------------------
// 
// cmdresult=RNGRLS::ABSREL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_absrel_t : iMMP
	{
		public uint _range;
		public uint _rt_time;
		public int _doppler;
		public ushort _bearing;
		public short _inclination;
		public ushort _azimuth;
		public short _elevation;

		// Default constructor
		public mmp_rngrls_cmdresult_absrel_t() : this(0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_absrel_t(uint a_range = 0, uint a_rt_time = 0, int a_doppler = 0, ushort a_bearing = 0, short a_inclination = 0, ushort a_azimuth = 0, short a_elevation = 0)
		{
			_range = a_range;
			_rt_time = a_rt_time;
			_doppler = a_doppler;
			_bearing = a_bearing;
			_inclination = a_inclination;
			_azimuth = a_azimuth;
			_elevation = a_elevation;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_absrel_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(int) + sizeof(ushort) + sizeof(short) + sizeof(ushort) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_range)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_rt_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_doppler)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_bearing)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_inclination)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_azimuth)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_absrel_t deserialize(byte[] data)
		{
			int offset = 0;

			_range = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_rt_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_doppler = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_bearing = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_inclination = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_azimuth = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


// command ABSCMPDEP
//------------------------------
// 
// cmdresult=RNGRLS::ABSCMPDEP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_abscmpdep_t : iMMP
	{
		public uint _range;
		public uint _rt_time;
		public int _doppler;
		public ushort _bearing;
		public short _inclination;
		public ushort _compass;
		public short _depth;

		// Default constructor
		public mmp_rngrls_cmdresult_abscmpdep_t() : this(0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_abscmpdep_t(uint a_range = 0, uint a_rt_time = 0, int a_doppler = 0, ushort a_bearing = 0, short a_inclination = 0, ushort a_compass = 0, short a_depth = 0)
		{
			_range = a_range;
			_rt_time = a_rt_time;
			_doppler = a_doppler;
			_bearing = a_bearing;
			_inclination = a_inclination;
			_compass = a_compass;
			_depth = a_depth;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_abscmpdep_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(int) + sizeof(ushort) + sizeof(short) + sizeof(ushort) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_range)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_rt_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_doppler)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_bearing)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_inclination)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_compass)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_depth)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_abscmpdep_t deserialize(byte[] data)
		{
			int offset = 0;

			_range = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_rt_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_doppler = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_bearing = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_inclination = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_compass = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_depth = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


// command CHANNEL_PROBE
//------------------------------
// 
// cmdresult=RNGRLS::CHANNEL_PROBE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_channel_probe_t : iMMP
	{
		public int _first;
		public int _peak;
		public int _EDT;
		public int _T10;
		public short _C25;
		public short _C50;
		public int _period;
		public ushort[] _data;

		// Default constructor
		public mmp_rngrls_cmdresult_channel_probe_t() : this(0, 0, 0, 0, 0, 0, 0, (ushort[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_channel_probe_t(int a_first = 0, int a_peak = 0, int a_EDT = 0, int a_T10 = 0, short a_C25 = 0, short a_C50 = 0, int a_period = 0, ushort[] a_data = null)
		{
			_first = a_first;
			_peak = a_peak;
			_EDT = a_EDT;
			_T10 = a_T10;
			_C25 = a_C25;
			_C50 = a_C50;
			_period = a_period;
			_data = a_data ?? new ushort[512];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_channel_probe_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(int) + sizeof(int) + sizeof(int) + sizeof(int) + sizeof(short) + sizeof(short) + sizeof(int) + (_data.Length * sizeof(ushort))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_first)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_peak)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_EDT)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_T10)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_C25)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_C50)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_period)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			for (int i = 0; i < _data.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_data[i])), 0, data, offset, sizeof(ushort));
				offset += sizeof(ushort);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_channel_probe_t deserialize(byte[] data)
		{
			int offset = 0;

			_first = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_peak = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_EDT = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_T10 = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_C25 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_C50 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_period = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);

			int i = 0;
			for (i = 0; i < _data.Length; )
			{
				_data[i++] = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
				offset += sizeof(ushort);
			}
			return this;
		}
	};

	//===========================================================



// command ACOU_SAMPLE
//------------------------------
// 
// cmdresult=RNGRLS::ACOU_SAMPLE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_acou_sample_t : iMMP
	{
		public uint _Fs;
		public uint _Fc;
		public uint _Bw;
		public short _gain;
		public byte _cell;
		public byte _total_cells;
		public byte _clip;
		public byte _spare;
		public short[] _data;

		// Default constructor
		public mmp_rngrls_cmdresult_acou_sample_t() : this(0, 0, 0, 0, 0, 0, 0, 0, (short[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_acou_sample_t(uint a_Fs = 0, uint a_Fc = 0, uint a_Bw = 0, short a_gain = 0, byte a_cell = 0, byte a_total_cells = 0, byte a_clip = 0, byte a_spare = 0, short[] a_data = null)
		{
			_Fs = a_Fs;
			_Fc = a_Fc;
			_Bw = a_Bw;
			_gain = a_gain;
			_cell = a_cell;
			_total_cells = a_total_cells;
			_clip = a_clip;
			_spare = a_spare;
			_data = a_data ?? new short[1024];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_acou_sample_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(short) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + (_data.Length * sizeof(short))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_Fs)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_Fc)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_Bw)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_gain)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			data[offset] = (byte)_cell;
			offset += sizeof(byte);
			data[offset] = (byte)_total_cells;
			offset += sizeof(byte);
			data[offset] = (byte)_clip;
			offset += sizeof(byte);
			data[offset] = (byte)_spare;
			offset += sizeof(byte);
			for (int i = 0; i < _data.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_data[i])), 0, data, offset, sizeof(short));
				offset += sizeof(short);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_acou_sample_t deserialize(byte[] data)
		{
			int offset = 0;

			_Fs = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_Fc = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_Bw = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_gain = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_cell = (byte)data[offset];
			offset += sizeof(byte);
			_total_cells = (byte)data[offset];
			offset += sizeof(byte);
			_clip = (byte)data[offset];
			offset += sizeof(byte);
			_spare = (byte)data[offset];
			offset += sizeof(byte);

			int i = 0;
			for (i = 0; i < _data.Length; )
			{
				_data[i++] = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
				offset += sizeof(short);
			}
			return this;
		}
	};

	//===========================================================



// command SPECTRUM_MODE
//------------------------------
// 
// cmd=RNGRLS::SPECTRUM_MODE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_spectrum_mode_t : iMMP
	{
		public byte _update_rate;
		public byte _freq_bins;

		// Default constructor
		public mmp_rngrls_spectrum_mode_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_spectrum_mode_t(byte a_update_rate = 0, byte a_freq_bins = 0)
		{
			_update_rate = a_update_rate;
			_freq_bins = a_freq_bins;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_spectrum_mode_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_update_rate;
			offset += sizeof(byte);
			data[offset] = (byte)_freq_bins;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_spectrum_mode_t deserialize(byte[] data)
		{
			int offset = 0;

			_update_rate = (byte)data[offset];
			offset += sizeof(byte);
			_freq_bins = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================




// response to all RELEASE / BURNWIRE commands
//----------------------------------
// 
// cmdresult=RNGRLS::SMART_RELEASE
// cmdresult=RNGRLS::BURNWIRE
// cmdresult=RNGRLS::RSERIES_RELEASE
// cmdresult=RNGRLS::ACOUSTIC_TRIGGER
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_release_response_t : iMMP
	{
		public ushort _status;

		// Default constructor
		public mmp_rngrls_cmdresult_release_response_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_release_response_t(ushort a_status = 0)
		{
			_status = a_status;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_release_response_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_status)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_release_response_t deserialize(byte[] data)
		{
			int offset = 0;

			_status = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command STATUS
//------------------------------
// 
// cmdresult=RNGRLS::RELEASE_STATUS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rngrls_cmdresult_release_status_t : iMMP
	{
		public ushort _status;
		public ushort _tilt;
		public ushort _battery;

		// Default constructor
		public mmp_rngrls_cmdresult_release_status_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rngrls_cmdresult_release_status_t(ushort a_status = 0, ushort a_tilt = 0, ushort a_battery = 0)
		{
			_status = a_status;
			_tilt = a_tilt;
			_battery = a_battery;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rngrls_cmdresult_release_status_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_status)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_tilt)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_battery)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rngrls_cmdresult_release_status_t deserialize(byte[] data)
		{
			int offset = 0;

			_status = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_tilt = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_battery = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



//*************************
// STD Command Structs & Values
//*************************

// command REMOTE_MMPREQ
//------------------------------
// 
// cmd=STD::REMOTE_MMPREQ
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_request_t : iMMP
	{
		public ushort _addr;
		public ushort _flags;
		public ushort _len;
		public sbyte[] _data;

		// Default constructor
		public mmp_remote_request_t() : this(0, 0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_request_t(ushort a_addr = 0, ushort a_flags = 0, ushort a_len = 0, sbyte[] a_data = null)
		{
			_addr = a_addr;
			_flags = a_flags;
			_len = a_len;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_request_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_request_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// command REMOTE_SETACOUBAUD
//------------------------------
// 
// cmd=STD::REMOTE_SETACOUBAUD
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_setacoubaud_t : iMMP
	{
		public ushort _addr;
		public ushort _modspec;

		// Default constructor
		public mmp_remote_setacoubaud_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_setacoubaud_t(ushort a_addr = 0, ushort a_modspec = 0)
		{
			_addr = a_addr;
			_modspec = a_modspec;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_setacoubaud_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_modspec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_setacoubaud_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_modspec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_SETTXPOWER
//------------------------------
// 
// cmd=STD::REMOTE_SETTXPOWER
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_settxpower_t : iMMP
	{
		public ushort _addr;
		public ushort _txpower;

		// Default constructor
		public mmp_remote_settxpower_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_settxpower_t(ushort a_addr = 0, ushort a_txpower = 0)
		{
			_addr = a_addr;
			_txpower = a_txpower;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_settxpower_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_txpower)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_settxpower_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_txpower = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_SETONESREG
//------------------------------
// 
// cmd=STD::REMOTE_SETONESREG
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_setonesreg_t : iMMP
	{
		public ushort _addr;
		public ushort _sreg;
		public ushort _value;

		// Default constructor
		public mmp_remote_setonesreg_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_setonesreg_t(ushort a_addr = 0, ushort a_sreg = 0, ushort a_value = 0)
		{
			_addr = a_addr;
			_sreg = a_sreg;
			_value = a_value;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_setonesreg_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_sreg)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_value)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_setonesreg_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_sreg = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_value = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_GETSREGS (response)
//------------------------------
// 
// cmdresult=STD::REMOTE_GETSREGS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_sregisters_t : iMMP
	{
		public ushort _addr;
		public ushort[] _sregs;

		// Default constructor
		public mmp_remote_sregisters_t() : this(0, (ushort[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_sregisters_t(ushort a_addr = 0, ushort[] a_sregs = null)
		{
			_addr = a_addr;
			_sregs = a_sregs ?? new ushort[21];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_sregisters_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + (_sregs.Length * sizeof(ushort))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _sregs.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_sregs[i])), 0, data, offset, sizeof(ushort));
				offset += sizeof(ushort);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_sregisters_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			for (i = 0; i < _sregs.Length; )
			{
				_sregs[i++] = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
				offset += sizeof(ushort);
			}
			return this;
		}
	};

	//===========================================================


// command REMOTE_GETONESREG
//------------------------------
// 
// cmd=STD::REMOTE_GETONESREG
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_getonesreg_t : iMMP
	{
		public ushort _addr;
		public ushort _sreg;

		// Default constructor
		public mmp_remote_getonesreg_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_getonesreg_t(ushort a_addr = 0, ushort a_sreg = 0)
		{
			_addr = a_addr;
			_sreg = a_sreg;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_getonesreg_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_sreg)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_getonesreg_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_sreg = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_GETONESREG (response)
//------------------------------
// 
// cmdresult=STD::REMOTE_GETONESREG
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_getonesreg_resp_t : iMMP
	{
		public ushort _addr;
		public ushort _sreg;
		public ushort _value;

		// Default constructor
		public mmp_remote_getonesreg_resp_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_getonesreg_resp_t(ushort a_addr = 0, ushort a_sreg = 0, ushort a_value = 0)
		{
			_addr = a_addr;
			_sreg = a_sreg;
			_value = a_value;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_getonesreg_resp_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_sreg)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_value)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_getonesreg_resp_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_sreg = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_value = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_SENDDATA
//------------------------------
// 
// cmd=STD::REMOTE_SENDDATA
// cmd=STD::REMOTE_SENDCMD
// cmd=STD::REMOTE_SENDBREAK
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_senddata_t : iMMP
	{
		public ushort _addr;
		public ushort _transport;
		public ushort _len;
		public sbyte[] _data;

		// Default constructor
		public mmp_remote_senddata_t() : this(0, 0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_senddata_t(ushort a_addr = 0, ushort a_transport = 0, ushort a_len = 0, sbyte[] a_data = null)
		{
			_addr = a_addr;
			_transport = a_transport;
			_len = a_len;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_senddata_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_transport)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_senddata_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_transport = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// command REMOTE_MMPREQ (response)
//----------------------------
// 
// cmdresult=STD::REMOTE_MMPREQ
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_mmpresp_t : iMMP
	{
		public ushort _addr;
		public ushort _len;
		public sbyte[] _data;

		// Default constructor
		public mmp_remote_mmpresp_t() : this(0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_mmpresp_t(ushort a_addr = 0, ushort a_len = 0, sbyte[] a_data = null)
		{
			_addr = a_addr;
			_len = a_len;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_mmpresp_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_mmpresp_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// command UPDATE_FIRMWARE
//------------------------------
// 
// cmd=STD::UPDATE_FIRMWARE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_update_firmware_t : iMMP
	{
		public uint _addr;

		// Default constructor
		public mmp_update_firmware_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_update_firmware_t(uint a_addr = 0)
		{
			_addr = a_addr;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_update_firmware_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_addr)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_update_firmware_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================


// command REMOTE_CMWAKEUP
//------------------------------
// 
// cmd=STD::REMOTE_CMWAKEUP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_cmwakeup_t : iMMP
	{
		public ushort _addr;
		public ushort _stay_awake_mins;

		// Default constructor
		public mmp_remote_cmwakeup_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_cmwakeup_t(ushort a_addr = 0, ushort a_stay_awake_mins = 0)
		{
			_addr = a_addr;
			_stay_awake_mins = a_stay_awake_mins;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_cmwakeup_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_stay_awake_mins)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_cmwakeup_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_stay_awake_mins = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command TILT_ACCEL
//------------------------------
// 
// cmd=STD::TILT_ACCEL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_tilt_accel_t : iMMP
	{
		public ushort _g_lpf;

		// Default constructor
		public mmp_tilt_accel_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_tilt_accel_t(ushort a_g_lpf = 0)
		{
			_g_lpf = a_g_lpf;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_tilt_accel_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_g_lpf)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_tilt_accel_t deserialize(byte[] data)
		{
			int offset = 0;

			_g_lpf = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================





// command REMOTE_TESTLINK (response)
//------------------------------
// 
// cmdresult=STD::REMOTE_TESTLINK
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_testmsgstats_t : iMMP
	{
		public ushort _addr;
		public ushort _mod_spec;
		public short _speedx10;
		public short _acq_SNRx10;
		public ushort _acq_MPDx10;
		public ushort _acq_RCT;
		public short _acq_FSNR;
		public short _hdr_SNRx10;
		public ushort _hdr_CCERR;
		public ushort _msg_ERR;
		public short _msg_SNRx10;
		public ushort _msg_AGC;
		public ushort _msg_CCERR;
		public short _remote_txpwr;

		// Default constructor
		public mmp_remote_testmsgstats_t() : this(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_testmsgstats_t(ushort a_addr = 0, ushort a_mod_spec = 0, short a_speedx10 = 0, short a_acq_SNRx10 = 0, ushort a_acq_MPDx10 = 0, ushort a_acq_RCT = 0, short a_acq_FSNR = 0, short a_hdr_SNRx10 = 0, ushort a_hdr_CCERR = 0, ushort a_msg_ERR = 0, short a_msg_SNRx10 = 0, ushort a_msg_AGC = 0, ushort a_msg_CCERR = 0, short a_remote_txpwr = 0)
		{
			_addr = a_addr;
			_mod_spec = a_mod_spec;
			_speedx10 = a_speedx10;
			_acq_SNRx10 = a_acq_SNRx10;
			_acq_MPDx10 = a_acq_MPDx10;
			_acq_RCT = a_acq_RCT;
			_acq_FSNR = a_acq_FSNR;
			_hdr_SNRx10 = a_hdr_SNRx10;
			_hdr_CCERR = a_hdr_CCERR;
			_msg_ERR = a_msg_ERR;
			_msg_SNRx10 = a_msg_SNRx10;
			_msg_AGC = a_msg_AGC;
			_msg_CCERR = a_msg_CCERR;
			_remote_txpwr = a_remote_txpwr;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_testmsgstats_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_mod_spec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_speedx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_acq_SNRx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_acq_MPDx10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_acq_RCT)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_acq_FSNR)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_hdr_SNRx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_hdr_CCERR)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msg_ERR)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_msg_SNRx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msg_AGC)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msg_CCERR)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_remote_txpwr)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_testmsgstats_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_mod_spec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_speedx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_acq_SNRx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_acq_MPDx10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_acq_RCT = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_acq_FSNR = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_hdr_SNRx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_hdr_CCERR = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msg_ERR = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msg_SNRx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_msg_AGC = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msg_CCERR = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_remote_txpwr = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


// command REMOTE_GETBATT (response)
// ---------------------------------
// 
// cmdresult=STD::REMOTE_GETBATT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_battvoltage_t : iMMP
	{
		public ushort _addr;
		public ushort _batt_voltage;
		public ushort _aux_voltage;

		// Default constructor
		public mmp_remote_battvoltage_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_battvoltage_t(ushort a_addr = 0, ushort a_batt_voltage = 0, ushort a_aux_voltage = 0)
		{
			_addr = a_addr;
			_batt_voltage = a_batt_voltage;
			_aux_voltage = a_aux_voltage;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_battvoltage_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_batt_voltage)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_aux_voltage)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_battvoltage_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_batt_voltage = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_aux_voltage = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_GETAGCHIST (response)
//------------------------------
// 
// cmdresult=STD::REMOTE_GETAGCHIST
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_agchist_t : iMMP
	{
		public ushort _addr;
		public ushort[] _rem_agc;

		// Default constructor
		public mmp_remote_agchist_t() : this(0, (ushort[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_agchist_t(ushort a_addr = 0, ushort[] a_rem_agc = null)
		{
			_addr = a_addr;
			_rem_agc = a_rem_agc ?? new ushort[10];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_agchist_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + (_rem_agc.Length * sizeof(ushort))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _rem_agc.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_rem_agc[i])), 0, data, offset, sizeof(ushort));
				offset += sizeof(ushort);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_agchist_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			for (i = 0; i < _rem_agc.Length; )
			{
				_rem_agc[i++] = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
				offset += sizeof(ushort);
			}
			return this;
		}
	};

	//===========================================================




// command REMOTE_AUTOBAUD
//------------------------------
// 
// cmd=STD::REMOTE_AUTOBAUD
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_autobaud_t : iMMP
	{
		public ushort _addr;
		public ushort _max_modspec;
		public ushort _min_modspec;
		public ushort _max_bit_errs;
		public ushort _set_flags;

		// Default constructor
		public mmp_remote_autobaud_t() : this(0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_autobaud_t(ushort a_addr = 0, ushort a_max_modspec = 0, ushort a_min_modspec = 0, ushort a_max_bit_errs = 0, ushort a_set_flags = 0)
		{
			_addr = a_addr;
			_max_modspec = a_max_modspec;
			_min_modspec = a_min_modspec;
			_max_bit_errs = a_max_bit_errs;
			_set_flags = a_set_flags;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_autobaud_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_max_modspec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_min_modspec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_max_bit_errs)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_set_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_autobaud_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_max_modspec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_min_modspec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_max_bit_errs = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_set_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_AUTOBAUD (response)
//------------------------------
// 
// cmdresult=STD::REMOTE_AUTOBAUD
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_autobaud_result_t : iMMP
	{
		public ushort _addr;
		public ushort _modspec;
		public ushort _bit_errs;
		public ushort _set_flags;

		// Default constructor
		public mmp_remote_autobaud_result_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_autobaud_result_t(ushort a_addr = 0, ushort a_modspec = 0, ushort a_bit_errs = 0, ushort a_set_flags = 0)
		{
			_addr = a_addr;
			_modspec = a_modspec;
			_bit_errs = a_bit_errs;
			_set_flags = a_set_flags;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_autobaud_result_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_modspec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_bit_errs)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_set_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_autobaud_result_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_modspec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_bit_errs = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_set_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_GETBATTCHG (response)
// ---------------------------------
// 
// cmdresult=STD::REMOTE_GETBATTCHG
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_battcharge_t : iMMP
	{
		public ushort _addr;
		public ushort _charge;

		// Default constructor
		public mmp_remote_battcharge_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_battcharge_t(ushort a_addr = 0, ushort a_charge = 0)
		{
			_addr = a_addr;
			_charge = a_charge;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_battcharge_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_charge)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_battcharge_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_charge = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command TILT_ACCEL (response)
//------------------------------
// 
// cmdresult=STD::TILT_ACCEL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_tilt_accel_response_t : iMMP
	{
		public short _one_g;
		public short[] _xyz_accel;
		public short[] _xyz_tilt;
		public short _g;

		// Default constructor
		public mmp_tilt_accel_response_t() : this(0, (short[])null, (short[])null, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_tilt_accel_response_t(short a_one_g = 0, short[] a_xyz_accel = null, short[] a_xyz_tilt = null, short a_g = 0)
		{
			_one_g = a_one_g;
			_xyz_accel = a_xyz_accel ?? new short[3];
			_xyz_tilt = a_xyz_tilt ?? new short[3];
			_g = a_g;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_tilt_accel_response_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + (_xyz_accel.Length * sizeof(short)) + (_xyz_tilt.Length * sizeof(short)) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_one_g)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			for (int i = 0; i < _xyz_accel.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_xyz_accel[i])), 0, data, offset, sizeof(short));
				offset += sizeof(short);
			}
			for (int i = 0; i < _xyz_tilt.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_xyz_tilt[i])), 0, data, offset, sizeof(short));
				offset += sizeof(short);
			}
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_g)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_tilt_accel_response_t deserialize(byte[] data)
		{
			int offset = 0;

			_one_g = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);

			int i = 0;
			for (i = 0; i < _xyz_accel.Length; )
			{
				_xyz_accel[i++] = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
				offset += sizeof(short);
			}

			for (i = 0; i < _xyz_tilt.Length; )
			{
				_xyz_tilt[i++] = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
				offset += sizeof(short);
			}
			_g = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


// command AXIS_TILT (response)
//------------------------------
// 
// cmdresult=STD::AXIS_TILT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_axis_tilt_response_t : iMMP
	{
		public byte _tilt;
		public byte _axis_w_pol;

		// Default constructor
		public mmp_axis_tilt_response_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_axis_tilt_response_t(byte a_tilt = 0, byte a_axis_w_pol = 0)
		{
			_tilt = a_tilt;
			_axis_w_pol = a_axis_w_pol;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_axis_tilt_response_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_tilt;
			offset += sizeof(byte);
			data[offset] = (byte)_axis_w_pol;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_axis_tilt_response_t deserialize(byte[] data)
		{
			int offset = 0;

			_tilt = (byte)data[offset];
			offset += sizeof(byte);
			_axis_w_pol = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================


//*************************

// command GETBATT (response)
// ---------------------------------
// 
// cmdresult=STD::GETBATT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_battvoltage_t : iMMP
	{
		public ushort _batt_voltage;
		public ushort _aux_voltage;

		// Default constructor
		public mmp_battvoltage_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_battvoltage_t(ushort a_batt_voltage = 0, ushort a_aux_voltage = 0)
		{
			_batt_voltage = a_batt_voltage;
			_aux_voltage = a_aux_voltage;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_battvoltage_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_batt_voltage)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_aux_voltage)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_battvoltage_t deserialize(byte[] data)
		{
			int offset = 0;

			_batt_voltage = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_aux_voltage = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command GETBATTCHG (response)
// ---------------------------------
// 
// cmdresult=STD::GETBATTCHG
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_battcharge_t : iMMP
	{
		public ushort _charge;

		// Default constructor
		public mmp_battcharge_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_battcharge_t(ushort a_charge = 0)
		{
			_charge = a_charge;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_battcharge_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_charge)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_battcharge_t deserialize(byte[] data)
		{
			int offset = 0;

			_charge = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command GETAGCHIST (response)
//------------------------------
// 
// cmdresult=STD::GETAGCHIST
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_agchist_t : iMMP
	{
		public ushort[] _agchist;

		// Default constructor
		public mmp_agchist_t() : this((ushort[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_agchist_t(ushort[] a_agchist = null)
		{
			_agchist = a_agchist ?? new ushort[10];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_agchist_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return((_agchist.Length * sizeof(ushort))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			for (int i = 0; i < _agchist.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_agchist[i])), 0, data, offset, sizeof(ushort));
				offset += sizeof(ushort);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_agchist_t deserialize(byte[] data)
		{
			int offset = 0;


			int i = 0;
			for (i = 0; i < _agchist.Length; )
			{
				_agchist[i++] = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
				offset += sizeof(ushort);
			}
			return this;
		}
	};

	//===========================================================



// command BOARD_TEMP
//------------------------------
// 
// cmd=STD::BOARD_TEMP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_board_temp_t : iMMP
	{
		public ushort _thermistor;

		// Default constructor
		public mmp_board_temp_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_board_temp_t(ushort a_thermistor = 0)
		{
			_thermistor = a_thermistor;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_board_temp_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_thermistor)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_board_temp_t deserialize(byte[] data)
		{
			int offset = 0;

			_thermistor = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command BOARD_TEMP (response)
//------------------------------
// 
// cmdresult=STD::BOARD_TEMP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_board_temp_resp_t : iMMP
	{
		public short _temp_C_x10;

		// Default constructor
		public mmp_board_temp_resp_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_board_temp_resp_t(short a_temp_C_x10 = 0)
		{
			_temp_C_x10 = a_temp_C_x10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_board_temp_resp_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_temp_C_x10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_board_temp_resp_t deserialize(byte[] data)
		{
			int offset = 0;

			_temp_C_x10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// cmd CONT_XMIT_TEST
//------------------------------
// 
// cmd=STD::CONT_XMIT_TEST
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_std_contxmit_enable_t : iMMP
	{
		public ushort _enable;

		// Default constructor
		public mmp_std_contxmit_enable_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_std_contxmit_enable_t(ushort a_enable = 0)
		{
			_enable = a_enable;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_std_contxmit_enable_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_enable)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_std_contxmit_enable_t deserialize(byte[] data)
		{
			int offset = 0;

			_enable = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// cmd SET_REMOTE_GROUP
//------------------------------
// 
// cmd=STD::SET_REMOTE_GROUP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_std_set_remote_group_t : iMMP
	{
		public ushort _address;
		public ushort _group;

		// Default constructor
		public mmp_std_set_remote_group_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_std_set_remote_group_t(ushort a_address = 0, ushort a_group = 0)
		{
			_address = a_address;
			_group = a_group;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_std_set_remote_group_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_address)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_group)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_std_set_remote_group_t deserialize(byte[] data)
		{
			int offset = 0;

			_address = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_group = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// cmd GETSMARTBATTDATA
//------------------------------
// 
// cmd=STD::GETSMARTBATTDATA
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_std_getsmartbattdata_t : iMMP
	{
		public ushort _battery;

		// Default constructor
		public mmp_std_getsmartbattdata_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_std_getsmartbattdata_t(ushort a_battery = 0)
		{
			_battery = a_battery;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_std_getsmartbattdata_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_battery)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_std_getsmartbattdata_t deserialize(byte[] data)
		{
			int offset = 0;

			_battery = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// response object in smart_batt.h


// cmd ADDFEATUREKEY, DELFEATUREKEY
//------------------------------
// 
// cmd=STD::ADDFEATUREKEY
// cmd=STD::DELFEATUREKEY
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_std_featkeystring_t : iMMP
	{
		public sbyte[] _key;

		// Default constructor
		public mmp_std_featkeystring_t() : this((sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_std_featkeystring_t(sbyte[] a_key = null)
		{
			_key = a_key ?? new sbyte[42];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_std_featkeystring_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return((_key.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			for (int i = 0; i < _key.Length; i++)
			{
				data[offset] = (byte)_key[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_std_featkeystring_t deserialize(byte[] data)
		{
			int offset = 0;


			int i = 0;
			for (i = 0; i < _key.Length; )
			{
				_key[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// command WRITE_DEVICE
//------------------------------
// 
// cmd=STD::WRITE_DEVICE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_write_device_t : iMMP
	{
		public ushort _device_num;
		public ushort _len;
		public sbyte[] _data;

		// Default constructor
		public mmp_write_device_t() : this(0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_write_device_t(ushort a_device_num = 0, ushort a_len = 0, sbyte[] a_data = null)
		{
			_device_num = a_device_num;
			_len = a_len;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_write_device_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_device_num)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_write_device_t deserialize(byte[] data)
		{
			int offset = 0;

			_device_num = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// command WRITE_DEVICE(response)
//------------------------------
// 
// cmdresult=STD::WRITE_DEVICE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_write_device_result_t : iMMP
	{
		public ushort _bytes_writ;
		public short _status;

		// Default constructor
		public mmp_write_device_result_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_write_device_result_t(ushort a_bytes_writ = 0, short a_status = 0)
		{
			_bytes_writ = a_bytes_writ;
			_status = a_status;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_write_device_result_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_bytes_writ)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_status)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_write_device_result_t deserialize(byte[] data)
		{
			int offset = 0;

			_bytes_writ = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_status = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


// command READ_DEVICE
//------------------------------
// 
// cmd=STD::READ_DEVICE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_read_device_t : iMMP
	{
		public ushort _device_num;
		public ushort _len;

		// Default constructor
		public mmp_read_device_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_read_device_t(ushort a_device_num = 0, ushort a_len = 0)
		{
			_device_num = a_device_num;
			_len = a_len;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_read_device_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_device_num)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_read_device_t deserialize(byte[] data)
		{
			int offset = 0;

			_device_num = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command READ_DEVICE (response)
//------------------------------
// 
// cmdresult=STD::READ_DEVICE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_read_device_result_t : iMMP
	{
		public short _status;
		public ushort _len;
		public sbyte[] _data;

		// Default constructor
		public mmp_read_device_result_t() : this(0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_read_device_result_t(short a_status = 0, ushort a_len = 0, sbyte[] a_data = null)
		{
			_status = a_status;
			_len = a_len;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_read_device_result_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_status)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_read_device_result_t deserialize(byte[] data)
		{
			int offset = 0;

			_status = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// command LEN_DEVICE
//------------------------------
// 
// cmd=STD::LEN_DEVICE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_len_device_t : iMMP
	{
		public ushort _device_num;

		// Default constructor
		public mmp_len_device_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_len_device_t(ushort a_device_num = 0)
		{
			_device_num = a_device_num;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_len_device_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_device_num)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_len_device_t deserialize(byte[] data)
		{
			int offset = 0;

			_device_num = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command LEN_DEVICE (response)
//------------------------------
// 
// cmdresult=STD::LEN_DEVICE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_len_device_result_t : iMMP
	{
		public ushort _device_num;
		public ushort _len;

		// Default constructor
		public mmp_len_device_result_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_len_device_result_t(ushort a_device_num = 0, ushort a_len = 0)
		{
			_device_num = a_device_num;
			_len = a_len;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_len_device_result_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_device_num)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_len_device_result_t deserialize(byte[] data)
		{
			int offset = 0;

			_device_num = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// command FIND_DEVICE
//------------------------------
// 
// cmd=STD::FIND_DEVICE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_find_device_t : iMMP
	{
		public ushort _len;
		public sbyte[] _name;

		// Default constructor
		public mmp_find_device_t() : this(0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_find_device_t(ushort a_len = 0, sbyte[] a_name = null)
		{
			_len = a_len;
			_name = a_name ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_find_device_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + (_name.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _name.Length; i++)
			{
				data[offset] = (byte)_name[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_find_device_t deserialize(byte[] data)
		{
			int offset = 0;

			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_name = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_name[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// command FIND_DEVICE (response)
//------------------------------
// 
// cmdresult=STD::FIND_DEVICE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_find_device_result_t : iMMP
	{
		public ushort _device_num;

		// Default constructor
		public mmp_find_device_result_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_find_device_result_t(ushort a_device_num = 0)
		{
			_device_num = a_device_num;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_find_device_result_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_device_num)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_find_device_result_t deserialize(byte[] data)
		{
			int offset = 0;

			_device_num = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// command REMOTE_MMPREQ
//------------------------------
// 
// cmd=SWCMD::REMOTE_MMPREQ
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_swb_remote_request_t : iMMP
	{
		public ushort _addr;
		public ushort _cellid;
		public ushort _flags;
		public ushort _len;
		public sbyte[] _data;

		// Default constructor
		public mmp_swb_remote_request_t() : this(0, 0, 0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_swb_remote_request_t(ushort a_addr = 0, ushort a_cellid = 0, ushort a_flags = 0, ushort a_len = 0, sbyte[] a_data = null)
		{
			_addr = a_addr;
			_cellid = a_cellid;
			_flags = a_flags;
			_len = a_len;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_swb_remote_request_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_cellid)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_swb_remote_request_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_cellid = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


//**************************
// CFG Fields
//**************************


//**************************
// CFG Structs & Field Values
//**************************

// 
// field=CFG_SECT_COPROC::*
// field=CFG_SECT_DATALOG::*
// field=CFG_SECT_MODEM::*
// field=CFG_SECT_RELEASE::*
// field=CFG_SECT_SEAWEB::*
// field=CFG_SECT_SERIAL::*
// field=CFG_SECT_SYSTEM::*
// field=CFG_SECT_TEST::*
// field=CFG_SECT_VERSION::*
// field=CFG_SECT_XPND::*
// field=CFG_SECT_NETWORK::*
// field=CFG_SECT_NAV::*
// field=CFG_SECT_DAT::*
// field=CFG_SECT_RECORDER::*
// field=CFG_SECT_SONAR::*
// field=CFG_SECT_TRANSPORT::*
// field=CFG_SECT_WHOI::*
// field=CFG_SECT_USBL::*
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_cfg_paramval_t : iMMP
	{
		public int _val_or_len;
		public byte _places;
		public byte _type;
		public sbyte[] _buf;

		// Default constructor
		public mmp_cfg_paramval_t() : this(0, 0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_cfg_paramval_t(int a_val_or_len = 0, byte a_places = 0, byte a_type = 0, sbyte[] a_buf = null)
		{
			_val_or_len = a_val_or_len;
			_places = a_places;
			_type = a_type;
			_buf = a_buf ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_cfg_paramval_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(int) + sizeof(byte) + sizeof(byte) + (_buf.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_val_or_len)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			data[offset] = (byte)_places;
			offset += sizeof(byte);
			data[offset] = (byte)_type;
			offset += sizeof(byte);
			for (int i = 0; i < _buf.Length; i++)
			{
				data[offset] = (byte)_buf[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_cfg_paramval_t deserialize(byte[] data)
		{
			int offset = 0;

			_val_or_len = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_places = (byte)data[offset];
			offset += sizeof(byte);
			_type = (byte)data[offset];
			offset += sizeof(byte);

			int i = 0;
			_buf = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_buf[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



//**************************
// DATA Structs & Field Values
//**************************

// field ACK -- uses ack codes from pmdef.h
//------------------------------
// 
// field=DATA::ACK
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_ack_t : iMMP
	{
		public ushort _ack;

		// Default constructor
		public mmp_data_ack_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_ack_t(ushort a_ack = 0)
		{
			_ack = a_ack;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_ack_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_ack)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_ack_t deserialize(byte[] data)
		{
			int offset = 0;

			_ack = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field REMOTE_DATA, REMOTE_DLOGBLK
//------------------------------
// Note the data[1] item is variable length, but declared as 1-element to allow array indexing
// 
// field=DATA::REMOTE_DATA
// field=DATA::REMOTE_DLOGBLK
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_remote_data_t : iMMP
	{
		public ushort _addr;
		public ushort _transport;
		public ushort _invalid_blks;
		public ushort _len;
		public sbyte[] _data;

		// Default constructor
		public mmp_remote_data_t() : this(0, 0, 0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_remote_data_t(ushort a_addr = 0, ushort a_transport = 0, ushort a_invalid_blks = 0, ushort a_len = 0, sbyte[] a_data = null)
		{
			_addr = a_addr;
			_transport = a_transport;
			_invalid_blks = a_invalid_blks;
			_len = a_len;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_remote_data_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_transport)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_invalid_blks)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_remote_data_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_transport = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_invalid_blks = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// field XMIT_OVERTEMP
//------------------------------
// 
// field=DATA::XMIT_OVERTEMP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_xmit_overtemp_t : iMMP
	{
		public ushort _sensor;
		public ushort _setpoint_x_100;

		// Default constructor
		public mmp_data_xmit_overtemp_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_xmit_overtemp_t(ushort a_sensor = 0, ushort a_setpoint_x_100 = 0)
		{
			_sensor = a_sensor;
			_setpoint_x_100 = a_setpoint_x_100;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_xmit_overtemp_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_sensor)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_setpoint_x_100)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_xmit_overtemp_t deserialize(byte[] data)
		{
			int offset = 0;

			_sensor = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_setpoint_x_100 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field BURN_COMPLETE, BURN_TIMEOUT
//------------------------------
// 
// field=DATA::BURN_COMPLETE
// field=DATA::BURN_TIMEOUT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_burn_complete_t : iMMP
	{
		public ushort _addr;

		// Default constructor
		public mmp_burn_complete_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_burn_complete_t(ushort a_addr = 0)
		{
			_addr = a_addr;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_burn_complete_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_burn_complete_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field ACOUTRIG_COMPLETE, ACOUTRIG_TIMEOUT
//------------------------------
// 
// field=DATA::ACOUTRIG_COMPLETE
// field=DATA::ACOUTRIG_TIMEOUT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_acoutrig_complete_t : iMMP
	{
		public ushort _addr;
		public ushort _assert_state;

		// Default constructor
		public mmp_acoutrig_complete_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_acoutrig_complete_t(ushort a_addr = 0, ushort a_assert_state = 0)
		{
			_addr = a_addr;
			_assert_state = a_assert_state;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_acoutrig_complete_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_assert_state)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_acoutrig_complete_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_assert_state = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field TRRC_STATUS   
//------------------------------
// 
// field=DATA::TRRC_STATUS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_trrc_status_t : iMMP
	{
		public ushort _tr_read_fail;
		public ushort _rc_read_fail;
		public ushort _tr_band_fail;
		public ushort _rc_band_fail;

		// Default constructor
		public mmp_data_trrc_status_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_trrc_status_t(ushort a_tr_read_fail = 0, ushort a_rc_read_fail = 0, ushort a_tr_band_fail = 0, ushort a_rc_band_fail = 0)
		{
			_tr_read_fail = a_tr_read_fail;
			_rc_read_fail = a_rc_read_fail;
			_tr_band_fail = a_tr_band_fail;
			_rc_band_fail = a_rc_band_fail;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_trrc_status_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_tr_read_fail)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_rc_read_fail)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_tr_band_fail)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_rc_band_fail)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_trrc_status_t deserialize(byte[] data)
		{
			int offset = 0;

			_tr_read_fail = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_rc_read_fail = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_tr_band_fail = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_rc_band_fail = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field FEAT_KEY_STATUS
//------------------------------------
// 
// field=DATA::FEAT_KEY_STATUS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_feat_key_status_t : iMMP
	{
		public uint _available_features;
		public uint _expected_features;
		public uint _enabled_features;
		public uint _unauthorized_features;

		// Default constructor
		public mmp_data_feat_key_status_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_feat_key_status_t(uint a_available_features = 0, uint a_expected_features = 0, uint a_enabled_features = 0, uint a_unauthorized_features = 0)
		{
			_available_features = a_available_features;
			_expected_features = a_expected_features;
			_enabled_features = a_enabled_features;
			_unauthorized_features = a_unauthorized_features;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_feat_key_status_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_available_features)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_expected_features)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_enabled_features)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_unauthorized_features)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_feat_key_status_t deserialize(byte[] data)
		{
			int offset = 0;

			_available_features = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_expected_features = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_enabled_features = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_unauthorized_features = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================



// field DATA::REMOTE_HEADER   
//------------------------------
// 
// field=DATA::REMOTE_HEADER
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_remote_header_t : iMMP
	{
		public byte _type;
		public byte _extension;
		public byte _parm1;
		public byte _parm2;
		public byte _parm3;
		public byte _Rx_addr;
		public byte _Tx_addr;
		public byte _CRC;

		// Default constructor
		public mmp_data_remote_header_t() : this(0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_remote_header_t(byte a_type = 0, byte a_extension = 0, byte a_parm1 = 0, byte a_parm2 = 0, byte a_parm3 = 0, byte a_Rx_addr = 0, byte a_Tx_addr = 0, byte a_CRC = 0)
		{
			_type = a_type;
			_extension = a_extension;
			_parm1 = a_parm1;
			_parm2 = a_parm2;
			_parm3 = a_parm3;
			_Rx_addr = a_Rx_addr;
			_Tx_addr = a_Tx_addr;
			_CRC = a_CRC;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_remote_header_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_type;
			offset += sizeof(byte);
			data[offset] = (byte)_extension;
			offset += sizeof(byte);
			data[offset] = (byte)_parm1;
			offset += sizeof(byte);
			data[offset] = (byte)_parm2;
			offset += sizeof(byte);
			data[offset] = (byte)_parm3;
			offset += sizeof(byte);
			data[offset] = (byte)_Rx_addr;
			offset += sizeof(byte);
			data[offset] = (byte)_Tx_addr;
			offset += sizeof(byte);
			data[offset] = (byte)_CRC;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_remote_header_t deserialize(byte[] data)
		{
			int offset = 0;

			_type = (byte)data[offset];
			offset += sizeof(byte);
			_extension = (byte)data[offset];
			offset += sizeof(byte);
			_parm1 = (byte)data[offset];
			offset += sizeof(byte);
			_parm2 = (byte)data[offset];
			offset += sizeof(byte);
			_parm3 = (byte)data[offset];
			offset += sizeof(byte);
			_Rx_addr = (byte)data[offset];
			offset += sizeof(byte);
			_Tx_addr = (byte)data[offset];
			offset += sizeof(byte);
			_CRC = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================


// field MMP_DATA_FLD_FPM_VERSION
//------------------------------------
// 
// field=DATA::FPM_VERSION
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_fpm_version_t : iMMP
	{
		public byte _ver_major;
		public byte _ver_minor;

		// Default constructor
		public mmp_data_fpm_version_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_fpm_version_t(byte a_ver_major = 0, byte a_ver_minor = 0)
		{
			_ver_major = a_ver_major;
			_ver_minor = a_ver_minor;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_fpm_version_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_ver_major;
			offset += sizeof(byte);
			data[offset] = (byte)_ver_minor;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_fpm_version_t deserialize(byte[] data)
		{
			int offset = 0;

			_ver_major = (byte)data[offset];
			offset += sizeof(byte);
			_ver_minor = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================



// field TIMESTAMP
//------------------------------
// 
// field=DATA::TIMESTAMP
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_timestamp_t : iMMP
	{
		public ushort _event;
		public ushort _hour;
		public ushort _min;
		public ushort _sec;
		public ushort _msec10;

		// Default constructor
		public mmp_data_timestamp_t() : this(0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_timestamp_t(ushort a_event = 0, ushort a_hour = 0, ushort a_min = 0, ushort a_sec = 0, ushort a_msec10 = 0)
		{
			_event = a_event;
			_hour = a_hour;
			_min = a_min;
			_sec = a_sec;
			_msec10 = a_msec10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_timestamp_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_event)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_hour)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_min)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_sec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msec10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_timestamp_t deserialize(byte[] data)
		{
			int offset = 0;

			_event = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_hour = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_min = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_sec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msec10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// field DOPPLER
//------------------------------
// 
// field=DATA::DOPPLER
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_doppler_t : iMMP
	{
		public short _speed;

		// Default constructor
		public mmp_data_doppler_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_doppler_t(short a_speed = 0)
		{
			_speed = a_speed;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_doppler_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_speed)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_doppler_t deserialize(byte[] data)
		{
			int offset = 0;

			_speed = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


// field DIRECTIONAL
//------------------------------
//
// field=DATA::DIRECTIONAL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_directional_t : iMMP
	{
		public short _raw_bearing;
		public short _raw_elevation;
		public short _cal_bearing;
		public short _cal_elevation;
		public short _bearing;
		public short _elevation;
		public ushort _range;
		public short _compass;
		public short _pitch;
		public short _roll;
		public int _latitude;
		public int _longitude;

		// Default constructor
		public mmp_data_directional_t() : this(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_directional_t(short a_raw_bearing = 0, short a_raw_elevation = 0, short a_cal_bearing = 0, short a_cal_elevation = 0, short a_bearing = 0, short a_elevation = 0, ushort a_range = 0, short a_compass = 0, short a_pitch = 0, short a_roll = 0, int a_latitude = 0, int a_longitude = 0)
		{
			_raw_bearing = a_raw_bearing;
			_raw_elevation = a_raw_elevation;
			_cal_bearing = a_cal_bearing;
			_cal_elevation = a_cal_elevation;
			_bearing = a_bearing;
			_elevation = a_elevation;
			_range = a_range;
			_compass = a_compass;
			_pitch = a_pitch;
			_roll = a_roll;
			_latitude = a_latitude;
			_longitude = a_longitude;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_directional_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(int) + sizeof(int)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_raw_bearing)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_raw_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_cal_bearing)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_cal_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_bearing)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_range)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_compass)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_pitch)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_roll)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_latitude)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			Buffer.BlockCopy(BitConverter.GetBytes((int)ip.HostToNetworkOrder((int)_longitude)), 0, data, offset, sizeof(int));
			offset += sizeof(int);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_directional_t deserialize(byte[] data)
		{
			int offset = 0;

			_raw_bearing = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_raw_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_cal_bearing = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_cal_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_bearing = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_range = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_compass = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_pitch = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_roll = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_latitude = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			_longitude = (int)ip.NetworkToHostOrder((int)BitConverter.ToInt32(data, offset));
			offset += sizeof(int);
			return this;
		}
	};

	//===========================================================



// field DIRECTIONAL_DEBUG
//------------------------------
//
// field=DATA::DIRECTIONAL_DEBUG
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_directional_debug_t : iMMP
	{
		public short _cal_bearing;
		public short _cal_elevation;
		public short _AGC;
		public short _vector;
		public short _level_1;
		public short _level_2;
		public short _level_3;
		public short _level_4;

		// Default constructor
		public mmp_data_directional_debug_t() : this(0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_directional_debug_t(short a_cal_bearing = 0, short a_cal_elevation = 0, short a_AGC = 0, short a_vector = 0, short a_level_1 = 0, short a_level_2 = 0, short a_level_3 = 0, short a_level_4 = 0)
		{
			_cal_bearing = a_cal_bearing;
			_cal_elevation = a_cal_elevation;
			_AGC = a_AGC;
			_vector = a_vector;
			_level_1 = a_level_1;
			_level_2 = a_level_2;
			_level_3 = a_level_3;
			_level_4 = a_level_4;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_directional_debug_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_cal_bearing)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_cal_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_AGC)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_vector)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_level_1)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_level_2)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_level_3)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_level_4)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_directional_debug_t deserialize(byte[] data)
		{
			int offset = 0;

			_cal_bearing = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_cal_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_AGC = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_vector = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_level_1 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_level_2 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_level_3 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_level_4 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


// field DIRECTIONAL_LOCDEBUG
//------------------------------
//
// field=DATA::DIRECTIONAL_LOCDEBUG
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_directional_locdebug_t : iMMP
	{
		public short _compass;
		public short _pitch;
		public short _roll;
		public short _vector;
		public short _level_1;
		public short _level_2;
		public short _level_3;
		public short _level_4;

		// Default constructor
		public mmp_data_directional_locdebug_t() : this(0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_directional_locdebug_t(short a_compass = 0, short a_pitch = 0, short a_roll = 0, short a_vector = 0, short a_level_1 = 0, short a_level_2 = 0, short a_level_3 = 0, short a_level_4 = 0)
		{
			_compass = a_compass;
			_pitch = a_pitch;
			_roll = a_roll;
			_vector = a_vector;
			_level_1 = a_level_1;
			_level_2 = a_level_2;
			_level_3 = a_level_3;
			_level_4 = a_level_4;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_directional_locdebug_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_compass)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_pitch)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_roll)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_vector)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_level_1)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_level_2)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_level_3)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_level_4)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_directional_locdebug_t deserialize(byte[] data)
		{
			int offset = 0;

			_compass = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_pitch = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_roll = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_vector = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_level_1 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_level_2 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_level_3 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_level_4 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


//**************************
// field TONAL_LOCATOR
//------------------------------
// 
// field=DATA::TONAL_LOCATOR
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_locator_t : iMMP
	{
		public short _bearing;
		public short _elevation;
		public short _vector;
		public short _AGC;
		public ushort _frequency;
		public ushort _hour;
		public ushort _min;
		public ushort _sec;
		public ushort _msec10;

		// Default constructor
		public mmp_data_locator_t() : this(0, 0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_locator_t(short a_bearing = 0, short a_elevation = 0, short a_vector = 0, short a_AGC = 0, ushort a_frequency = 0, ushort a_hour = 0, ushort a_min = 0, ushort a_sec = 0, ushort a_msec10 = 0)
		{
			_bearing = a_bearing;
			_elevation = a_elevation;
			_vector = a_vector;
			_AGC = a_AGC;
			_frequency = a_frequency;
			_hour = a_hour;
			_min = a_min;
			_sec = a_sec;
			_msec10 = a_msec10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_locator_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(short) + sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_bearing)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_vector)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_AGC)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_frequency)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_hour)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_min)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_sec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msec10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_locator_t deserialize(byte[] data)
		{
			int offset = 0;

			_bearing = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_vector = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_AGC = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_frequency = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_hour = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_min = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_sec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msec10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================

//**************************

// field LOW_POWER
//------------------------------
// 
// field=DATA::LOW_POWER
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_lowpower_t : iMMP
	{
		public ushort _lpstat;
		public ushort _waketype;
		public uint _sleep_secs;

		// Default constructor
		public mmp_data_lowpower_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_lowpower_t(ushort a_lpstat = 0, ushort a_waketype = 0, uint a_sleep_secs = 0)
		{
			_lpstat = a_lpstat;
			_waketype = a_waketype;
			_sleep_secs = a_sleep_secs;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_lowpower_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_lpstat)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_waketype)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_sleep_secs)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_lowpower_t deserialize(byte[] data)
		{
			int offset = 0;

			_lpstat = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_waketype = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_sleep_secs = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================



// field ACSTATS
//------------------------------
// 
// field=DATA::ACSTATS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_acstats_t : iMMP
	{
		public ushort _addr;
		public ushort _mod_spec;
		public short _speedx10;
		public short _acq_SNRx10;
		public ushort _acq_MPDx10;
		public ushort _acq_RCT;
		public short _acq_FSNR;
		public short _hdr_SNRx10;
		public ushort _hdr_CCERR;
		public ushort _msg_ERR;
		public short _msg_SNRx10;
		public ushort _msg_AGC;
		public ushort _msg_CCERR;
		public ushort _msg_CRC;

		// Default constructor
		public mmp_data_acstats_t() : this(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_acstats_t(ushort a_addr = 0, ushort a_mod_spec = 0, short a_speedx10 = 0, short a_acq_SNRx10 = 0, ushort a_acq_MPDx10 = 0, ushort a_acq_RCT = 0, short a_acq_FSNR = 0, short a_hdr_SNRx10 = 0, ushort a_hdr_CCERR = 0, ushort a_msg_ERR = 0, short a_msg_SNRx10 = 0, ushort a_msg_AGC = 0, ushort a_msg_CCERR = 0, ushort a_msg_CRC = 0)
		{
			_addr = a_addr;
			_mod_spec = a_mod_spec;
			_speedx10 = a_speedx10;
			_acq_SNRx10 = a_acq_SNRx10;
			_acq_MPDx10 = a_acq_MPDx10;
			_acq_RCT = a_acq_RCT;
			_acq_FSNR = a_acq_FSNR;
			_hdr_SNRx10 = a_hdr_SNRx10;
			_hdr_CCERR = a_hdr_CCERR;
			_msg_ERR = a_msg_ERR;
			_msg_SNRx10 = a_msg_SNRx10;
			_msg_AGC = a_msg_AGC;
			_msg_CCERR = a_msg_CCERR;
			_msg_CRC = a_msg_CRC;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_acstats_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_addr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_mod_spec)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_speedx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_acq_SNRx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_acq_MPDx10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_acq_RCT)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_acq_FSNR)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_hdr_SNRx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_hdr_CCERR)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msg_ERR)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_msg_SNRx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msg_AGC)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msg_CCERR)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_msg_CRC)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_acstats_t deserialize(byte[] data)
		{
			int offset = 0;

			_addr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_mod_spec = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_speedx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_acq_SNRx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_acq_MPDx10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_acq_RCT = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_acq_FSNR = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_hdr_SNRx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_hdr_CCERR = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msg_ERR = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msg_SNRx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_msg_AGC = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msg_CCERR = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_msg_CRC = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field HEADER ERROR
//------------------------------
// 
// field=DATA::HEADER_ERROR
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_hdrerr_t : iMMP
	{
		public short _speedx10;
		public short _acq_SNRx10;
		public ushort _acq_MPDx10;
		public ushort _acq_RCT;
		public short _acq_FSNR;
		public short _hdr_SNRx10;
		public ushort _hdr_CCERR;

		// Default constructor
		public mmp_data_hdrerr_t() : this(0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_hdrerr_t(short a_speedx10 = 0, short a_acq_SNRx10 = 0, ushort a_acq_MPDx10 = 0, ushort a_acq_RCT = 0, short a_acq_FSNR = 0, short a_hdr_SNRx10 = 0, ushort a_hdr_CCERR = 0)
		{
			_speedx10 = a_speedx10;
			_acq_SNRx10 = a_acq_SNRx10;
			_acq_MPDx10 = a_acq_MPDx10;
			_acq_RCT = a_acq_RCT;
			_acq_FSNR = a_acq_FSNR;
			_hdr_SNRx10 = a_hdr_SNRx10;
			_hdr_CCERR = a_hdr_CCERR;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_hdrerr_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_speedx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_acq_SNRx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_acq_MPDx10)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_acq_RCT)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_acq_FSNR)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_hdr_SNRx10)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_hdr_CCERR)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_hdrerr_t deserialize(byte[] data)
		{
			int offset = 0;

			_speedx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_acq_SNRx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_acq_MPDx10 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_acq_RCT = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_acq_FSNR = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_hdr_SNRx10 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_hdr_CCERR = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field RANGE_UPDATE
//------------------------------
// 
// field=DATA::RANGE_UPDATE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_rangeupdate_t : iMMP
	{
		public ushort _node;
		public short _range_type;
		public uint _range_x10;
		public uint _propdly_x10;

		// Default constructor
		public mmp_data_rangeupdate_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_rangeupdate_t(ushort a_node = 0, short a_range_type = 0, uint a_range_x10 = 0, uint a_propdly_x10 = 0)
		{
			_node = a_node;
			_range_type = a_range_type;
			_range_x10 = a_range_x10;
			_propdly_x10 = a_propdly_x10;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_rangeupdate_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(short) + sizeof(uint) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_node)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_range_type)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_range_x10)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_propdly_x10)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_rangeupdate_t deserialize(byte[] data)
		{
			int offset = 0;

			_node = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_range_type = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_range_x10 = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_propdly_x10 = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================


// field MMP_DATA_FLD_NAV_STATUS
//------------------------------------
// 
// field=DATA::NAV_STATUS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_nav_status_t : iMMP
	{
		public short _location;
		public short _heading;
		public short _attitude;

		// Default constructor
		public mmp_data_nav_status_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_nav_status_t(short a_location = 0, short a_heading = 0, short a_attitude = 0)
		{
			_location = a_location;
			_heading = a_heading;
			_attitude = a_attitude;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_nav_status_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(short) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_location)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_heading)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_attitude)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_nav_status_t deserialize(byte[] data)
		{
			int offset = 0;

			_location = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_heading = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_attitude = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// field FPM_BOOT_FAIL
//------------------------------------
// 
// field=DATA::FPM_BOOT_FAIL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_fpm_boot_failure_t : iMMP
	{
		public short _failure;

		// Default constructor
		public mmp_data_fpm_boot_failure_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_fpm_boot_failure_t(short a_failure = 0)
		{
			_failure = a_failure;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_fpm_boot_failure_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_failure)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_fpm_boot_failure_t deserialize(byte[] data)
		{
			int offset = 0;

			_failure = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// field MMP_DATA_FLD_RCV_GAIN
//------------------------------------
// 
// field=DATA::RCV_GAIN
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_rcv_gain_t : iMMP
	{
		public short _rc_atten_step1;
		public short _rc_atten_step2;
		public short _rc_total_gain;

		// Default constructor
		public mmp_data_rcv_gain_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_rcv_gain_t(short a_rc_atten_step1 = 0, short a_rc_atten_step2 = 0, short a_rc_total_gain = 0)
		{
			_rc_atten_step1 = a_rc_atten_step1;
			_rc_atten_step2 = a_rc_atten_step2;
			_rc_total_gain = a_rc_total_gain;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_rcv_gain_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(short) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_rc_atten_step1)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_rc_atten_step2)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_rc_total_gain)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_rcv_gain_t deserialize(byte[] data)
		{
			int offset = 0;

			_rc_atten_step1 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_rc_atten_step2 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_rc_total_gain = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// field SPECTRUM_STATUS
//------------------------------
// 
// field=DATA::SPECTRUM_STATUS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_spectrum_stat_t : iMMP
	{
		public byte _stat;
		public byte _bins;
		public ushort _step;
		public uint _freq_low;
		public uint _freq_high;

		// Default constructor
		public mmp_spectrum_stat_t() : this(0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_spectrum_stat_t(byte a_stat = 0, byte a_bins = 0, ushort a_step = 0, uint a_freq_low = 0, uint a_freq_high = 0)
		{
			_stat = a_stat;
			_bins = a_bins;
			_step = a_step;
			_freq_low = a_freq_low;
			_freq_high = a_freq_high;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_spectrum_stat_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(ushort) + sizeof(uint) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_stat;
			offset += sizeof(byte);
			data[offset] = (byte)_bins;
			offset += sizeof(byte);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_step)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_freq_low)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_freq_high)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_spectrum_stat_t deserialize(byte[] data)
		{
			int offset = 0;

			_stat = (byte)data[offset];
			offset += sizeof(byte);
			_bins = (byte)data[offset];
			offset += sizeof(byte);
			_step = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_freq_low = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_freq_high = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================



// field SPECTRUM_DATA
//------------------------------
// Note the data[1] item is variable length, but declared as 1-element to allow array indexing
// 
// field=DATA::SPECTRUM_DATA
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_spectrum_data_t : iMMP
	{
		public short _AGC;
		public short _bins;
		public sbyte[] _data;

		// Default constructor
		public mmp_spectrum_data_t() : this(0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_spectrum_data_t(short a_AGC = 0, short a_bins = 0, sbyte[] a_data = null)
		{
			_AGC = a_AGC;
			_bins = a_bins;
			_data = a_data ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_spectrum_data_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short) + sizeof(short) + (_data.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_AGC)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_bins)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			for (int i = 0; i < _data.Length; i++)
			{
				data[offset] = (byte)_data[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_spectrum_data_t deserialize(byte[] data)
		{
			int offset = 0;

			_AGC = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_bins = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);

			int i = 0;
			_data = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_data[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// field RLS_CMOTOR_STATUS
//------------------------------
// 
// field=DATA::RLS_CMOTOR_STATUS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_rls_cmotor_status_t : iMMP
	{
		public short _status;

		// Default constructor
		public mmp_data_rls_cmotor_status_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_rls_cmotor_status_t(short a_status = 0)
		{
			_status = a_status;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_rls_cmotor_status_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_status)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_rls_cmotor_status_t deserialize(byte[] data)
		{
			int offset = 0;

			_status = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// field JANUS_PACKET
//------------------------------
// 
// field=DATA::JANUS_PACKET
// cmd=STD::SENDJANUSPACKET
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_janus_packet_t : iMMP
	{
		public byte _version;
		public byte _mobility_flag;
		public byte _txrx_flag;
		public byte _forwarding_flag;
		public byte _class_userid;
		public byte _app_type;
		public byte _schedule_type;
		public byte _schedule_index_adb_upper;
		public uint _adb_lower;
		public ushort _cargo_len;
		public sbyte[] _cargo;

		// Default constructor
		public mmp_data_janus_packet_t() : this(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_janus_packet_t(byte a_version = 0, byte a_mobility_flag = 0, byte a_txrx_flag = 0, byte a_forwarding_flag = 0, byte a_class_userid = 0, byte a_app_type = 0, byte a_schedule_type = 0, byte a_schedule_index_adb_upper = 0, uint a_adb_lower = 0, ushort a_cargo_len = 0, sbyte[] a_cargo = null)
		{
			_version = a_version;
			_mobility_flag = a_mobility_flag;
			_txrx_flag = a_txrx_flag;
			_forwarding_flag = a_forwarding_flag;
			_class_userid = a_class_userid;
			_app_type = a_app_type;
			_schedule_type = a_schedule_type;
			_schedule_index_adb_upper = a_schedule_index_adb_upper;
			_adb_lower = a_adb_lower;
			_cargo_len = a_cargo_len;
			_cargo = a_cargo ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_janus_packet_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(uint) + sizeof(ushort) + (_cargo.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_version;
			offset += sizeof(byte);
			data[offset] = (byte)_mobility_flag;
			offset += sizeof(byte);
			data[offset] = (byte)_txrx_flag;
			offset += sizeof(byte);
			data[offset] = (byte)_forwarding_flag;
			offset += sizeof(byte);
			data[offset] = (byte)_class_userid;
			offset += sizeof(byte);
			data[offset] = (byte)_app_type;
			offset += sizeof(byte);
			data[offset] = (byte)_schedule_type;
			offset += sizeof(byte);
			data[offset] = (byte)_schedule_index_adb_upper;
			offset += sizeof(byte);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_adb_lower)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_cargo_len)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _cargo.Length; i++)
			{
				data[offset] = (byte)_cargo[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_janus_packet_t deserialize(byte[] data)
		{
			int offset = 0;

			_version = (byte)data[offset];
			offset += sizeof(byte);
			_mobility_flag = (byte)data[offset];
			offset += sizeof(byte);
			_txrx_flag = (byte)data[offset];
			offset += sizeof(byte);
			_forwarding_flag = (byte)data[offset];
			offset += sizeof(byte);
			_class_userid = (byte)data[offset];
			offset += sizeof(byte);
			_app_type = (byte)data[offset];
			offset += sizeof(byte);
			_schedule_type = (byte)data[offset];
			offset += sizeof(byte);
			_schedule_index_adb_upper = (byte)data[offset];
			offset += sizeof(byte);
			_adb_lower = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_cargo_len = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_cargo = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_cargo[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// field RNGBRG_UPDATE
//------------------------------
// 
// field=DATA::RNGBRG_UPDATE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_data_rngbrg_update_t : iMMP
	{
		public uint _range;
		public uint _propdly_x10;
		public ushort _node;
		public short _azimuth;
		public short _elevation;

		// Default constructor
		public mmp_data_rngbrg_update_t() : this(0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_data_rngbrg_update_t(uint a_range = 0, uint a_propdly_x10 = 0, ushort a_node = 0, short a_azimuth = 0, short a_elevation = 0)
		{
			_range = a_range;
			_propdly_x10 = a_propdly_x10;
			_node = a_node;
			_azimuth = a_azimuth;
			_elevation = a_elevation;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_data_rngbrg_update_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(ushort) + sizeof(short) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_range)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_propdly_x10)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_node)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_azimuth)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_elevation)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_data_rngbrg_update_t deserialize(byte[] data)
		{
			int offset = 0;

			_range = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_propdly_x10 = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_node = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_azimuth = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_elevation = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



//**************************
// DECKBOX Structs & Field Values
//**************************

// field SPKRVOL/PHONESVOL
//------------------------------
// 
// field=DECKBOX::SPKRVOL
// field=DECKBOX::PHONESVOL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_spkr_phones_vol_t : iMMP
	{
		public byte _volume;
		public byte _mute;

		// Default constructor
		public mmp_spkr_phones_vol_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_spkr_phones_vol_t(byte a_volume = 0, byte a_mute = 0)
		{
			_volume = a_volume;
			_mute = a_mute;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_spkr_phones_vol_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_volume;
			offset += sizeof(byte);
			data[offset] = (byte)_mute;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_spkr_phones_vol_t deserialize(byte[] data)
		{
			int offset = 0;

			_volume = (byte)data[offset];
			offset += sizeof(byte);
			_mute = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================



// field PWRSENSE
//------------------------------
// 
// field=DECKBOX::PWRSENSE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_pwrsense_t : iMMP
	{
		public ushort _device;
		public byte _charge;
		public byte _charging;

		// Default constructor
		public mmp_pwrsense_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_pwrsense_t(ushort a_device = 0, byte a_charge = 0, byte a_charging = 0)
		{
			_device = a_device;
			_charge = a_charge;
			_charging = a_charging;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_pwrsense_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_device)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			data[offset] = (byte)_charge;
			offset += sizeof(byte);
			data[offset] = (byte)_charging;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_pwrsense_t deserialize(byte[] data)
		{
			int offset = 0;

			_device = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_charge = (byte)data[offset];
			offset += sizeof(byte);
			_charging = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================



// field BATTLEV
//------------------------------
// 
// field=DECKBOX::BATTLEV
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_battlev_t : iMMP
	{
		public ushort _charge;

		// Default constructor
		public mmp_battlev_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_battlev_t(ushort a_charge = 0)
		{
			_charge = a_charge;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_battlev_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_charge)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_battlev_t deserialize(byte[] data)
		{
			int offset = 0;

			_charge = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field BATTVOLT
//------------------------------
// 
// field=DECKBOX::BATTVOLT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_battvolt_t : iMMP
	{
		public ushort _volts_x_100;

		// Default constructor
		public mmp_battvolt_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_battvolt_t(ushort a_volts_x_100 = 0)
		{
			_volts_x_100 = a_volts_x_100;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_battvolt_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_volts_x_100)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_battvolt_t deserialize(byte[] data)
		{
			int offset = 0;

			_volts_x_100 = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// field MODEL
//------------------------------
// 
// field=DECKBOX::MODEL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_udb_model_t : iMMP
	{
		public ushort _model;

		// Default constructor
		public mmp_udb_model_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_udb_model_t(ushort a_model = 0)
		{
			_model = a_model;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_udb_model_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_model)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_udb_model_t deserialize(byte[] data)
		{
			int offset = 0;

			_model = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// field GPS_RELAY
//------------------------------
// 
// field=DECKBOX::GPS_RELAY
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_gps_relay_t : iMMP
	{
		public ushort _status;

		// Default constructor
		public mmp_gps_relay_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_gps_relay_t(ushort a_status = 0)
		{
			_status = a_status;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_gps_relay_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_status)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_gps_relay_t deserialize(byte[] data)
		{
			int offset = 0;

			_status = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field XDCR_SWITCH
//------------------------------
// 
// field=HWCTL::XDCR_SWITCH
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_xdcr_switch_t : iMMP
	{
		public short _which;

		// Default constructor
		public mmp_xdcr_switch_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_xdcr_switch_t(short a_which = 0)
		{
			_which = a_which;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_xdcr_switch_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_which)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_xdcr_switch_t deserialize(byte[] data)
		{
			int offset = 0;

			_which = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



//**************************
// IFACE Structs & Field Values
//**************************

// field MMPSTAT
//------------------------------
// 
// field=IFACE::MMPSTAT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_stat_t : iMMP
	{
		public ushort _stat;

		// Default constructor
		public mmp_iface_stat_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_stat_t(ushort a_stat = 0)
		{
			_stat = a_stat;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_stat_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_stat)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_stat_t deserialize(byte[] data)
		{
			int offset = 0;

			_stat = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field ERR
//----------------------------
// Structure used to return MMP error codes.  Contains error type and the subsystem/field of the 
// request that generated it
// 
// field=IFACE::ERR
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_sfl_err_t : iMMP
	{
		public byte _subsys;
		public byte _field;
		public ushort _err;

		// Default constructor
		public mmp_sfl_err_t() : this(0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_sfl_err_t(byte a_subsys = 0, byte a_field = 0, ushort a_err = 0)
		{
			_subsys = a_subsys;
			_field = a_field;
			_err = a_err;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_sfl_err_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_subsys;
			offset += sizeof(byte);
			data[offset] = (byte)_field;
			offset += sizeof(byte);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_err)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_sfl_err_t deserialize(byte[] data)
		{
			int offset = 0;

			_subsys = (byte)data[offset];
			offset += sizeof(byte);
			_field = (byte)data[offset];
			offset += sizeof(byte);
			_err = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field VERSION
//------------------------------
// 
// field=IFACE::VERSION
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_version_t : iMMP
	{
		public ushort _major;
		public ushort _minor;

		// Default constructor
		public mmp_version_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_version_t(ushort a_major = 0, ushort a_minor = 0)
		{
			_major = a_major;
			_minor = a_minor;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_version_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_major)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_minor)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_version_t deserialize(byte[] data)
		{
			int offset = 0;

			_major = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_minor = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field CMDRESULT
//-------------------------------
// 
// field=IFACE::CMDRESULT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_cmd_result_t : iMMP
	{
		public byte _cmdsect;
		public byte _cmd;
		public byte _seqno;
		public byte _message;

		// Default constructor
		public mmp_cmd_result_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_cmd_result_t(byte a_cmdsect = 0, byte a_cmd = 0, byte a_seqno = 0, byte a_message = 0)
		{
			_cmdsect = a_cmdsect;
			_cmd = a_cmd;
			_seqno = a_seqno;
			_message = a_message;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_cmd_result_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_cmdsect;
			offset += sizeof(byte);
			data[offset] = (byte)_cmd;
			offset += sizeof(byte);
			data[offset] = (byte)_seqno;
			offset += sizeof(byte);
			data[offset] = (byte)_message;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_cmd_result_t deserialize(byte[] data)
		{
			int offset = 0;

			_cmdsect = (byte)data[offset];
			offset += sizeof(byte);
			_cmd = (byte)data[offset];
			offset += sizeof(byte);
			_seqno = (byte)data[offset];
			offset += sizeof(byte);
			_message = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================


// field BLOCKNOTIFY, UNBLOCKNOTIFY
//----------------------------
// 
// field=IFACE::BLOCKNOTIFY
// field=IFACE::UNBLOCKNOTIFY
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_blocknotify_t : iMMP
	{
		public ushort _numsubsys;
		public sbyte[] _subsys;

		// Default constructor
		public mmp_iface_blocknotify_t() : this(0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_blocknotify_t(ushort a_numsubsys = 0, sbyte[] a_subsys = null)
		{
			_numsubsys = a_numsubsys;
			_subsys = a_subsys ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_blocknotify_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + (_subsys.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_numsubsys)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _subsys.Length; i++)
			{
				data[offset] = (byte)_subsys[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_blocknotify_t deserialize(byte[] data)
		{
			int offset = 0;

			_numsubsys = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_subsys = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_subsys[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// field PRIVLEV
//----------------------------
// 
// field=IFACE::PRIVLEV
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_privlev_t : iMMP
	{
		public byte _privlev;
		public byte _pwlen;
		public sbyte[] _password;

		// Default constructor
		public mmp_iface_privlev_t() : this(0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_privlev_t(byte a_privlev = 0, byte a_pwlen = 0, sbyte[] a_password = null)
		{
			_privlev = a_privlev;
			_pwlen = a_pwlen;
			_password = a_password ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_privlev_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + (_password.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_privlev;
			offset += sizeof(byte);
			data[offset] = (byte)_pwlen;
			offset += sizeof(byte);
			for (int i = 0; i < _password.Length; i++)
			{
				data[offset] = (byte)_password[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_privlev_t deserialize(byte[] data)
		{
			int offset = 0;

			_privlev = (byte)data[offset];
			offset += sizeof(byte);
			_pwlen = (byte)data[offset];
			offset += sizeof(byte);

			int i = 0;
			_password = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_password[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


// field DSP_SW_VERSION
//------------------------------
// 
// field=IFACE::DSP_SW_VERSION
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_dsp_sw_version_t : iMMP
	{
		public byte _major;
		public byte _minor;
		public ushort _revision;
		public uint _svnver;

		// Default constructor
		public mmp_iface_dsp_sw_version_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_dsp_sw_version_t(byte a_major = 0, byte a_minor = 0, ushort a_revision = 0, uint a_svnver = 0)
		{
			_major = a_major;
			_minor = a_minor;
			_revision = a_revision;
			_svnver = a_svnver;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_dsp_sw_version_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(ushort) + sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_major;
			offset += sizeof(byte);
			data[offset] = (byte)_minor;
			offset += sizeof(byte);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_revision)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_svnver)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_dsp_sw_version_t deserialize(byte[] data)
		{
			int offset = 0;

			_major = (byte)data[offset];
			offset += sizeof(byte);
			_minor = (byte)data[offset];
			offset += sizeof(byte);
			_revision = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_svnver = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================



// field FEATURE_KEY
//------------------------------
// 
// field=IFACE::FEATURE_KEY
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_featurekey_t : iMMP
	{
		public sbyte[] _key;

		// Default constructor
		public mmp_iface_featurekey_t() : this((sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_featurekey_t(sbyte[] a_key = null)
		{
			_key = a_key ?? new sbyte[16];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_featurekey_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return((_key.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			for (int i = 0; i < _key.Length; i++)
			{
				data[offset] = (byte)_key[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_featurekey_t deserialize(byte[] data)
		{
			int offset = 0;


			int i = 0;
			for (i = 0; i < _key.Length; )
			{
				_key[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================



// field UNIT_SERNO
//------------------------------
// 
// field=IFACE::UNIT_SERNO
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_unit_serno_t : iMMP
	{
		public uint _serno;

		// Default constructor
		public mmp_iface_unit_serno_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_unit_serno_t(uint a_serno = 0)
		{
			_serno = a_serno;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_unit_serno_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_serno)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_unit_serno_t deserialize(byte[] data)
		{
			int offset = 0;

			_serno = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			return this;
		}
	};

	//===========================================================


//**************************

// field NTFY_COUNT, NTFY_CKSUM
//------------------------------
// 
// field=IFACE::NTFY_COUNT
// field=IFACE::NTFY_CKSUM
// field=IFACE::GATE_DATA_DIRECTIONAL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_flag_enable_t : iMMP
	{
		public ushort _enable;

		// Default constructor
		public mmp_iface_flag_enable_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_flag_enable_t(ushort a_enable = 0)
		{
			_enable = a_enable;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_flag_enable_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_enable)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_flag_enable_t deserialize(byte[] data)
		{
			int offset = 0;

			_enable = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field AES_USER_KEY
//------------------------------
// 
// field=IFACE::AES_USER_KEY
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_aes_key_t : iMMP
	{
		public ushort _timeout_hrs;
		public ushort[] _key;

		// Default constructor
		public mmp_iface_aes_key_t() : this(0, (ushort[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_aes_key_t(ushort a_timeout_hrs = 0, ushort[] a_key = null)
		{
			_timeout_hrs = a_timeout_hrs;
			_key = a_key ?? new ushort[16];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_aes_key_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + (_key.Length * sizeof(ushort))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_timeout_hrs)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _key.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_key[i])), 0, data, offset, sizeof(ushort));
				offset += sizeof(ushort);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_aes_key_t deserialize(byte[] data)
		{
			int offset = 0;

			_timeout_hrs = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			for (i = 0; i < _key.Length; )
			{
				_key[i++] = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
				offset += sizeof(ushort);
			}
			return this;
		}
	};

	//===========================================================


// field COMPATIBILITY
//------------------------------
// 
// field=IFACE::COMPATIBILITY
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_compatibility_t : iMMP
	{
		public byte _compat_1;
		public byte _compat_2;

		// Default constructor
		public mmp_iface_compatibility_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_compatibility_t(byte a_compat_1 = 0, byte a_compat_2 = 0)
		{
			_compat_1 = a_compat_1;
			_compat_2 = a_compat_2;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_compatibility_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_compat_1;
			offset += sizeof(byte);
			data[offset] = (byte)_compat_2;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_compatibility_t deserialize(byte[] data)
		{
			int offset = 0;

			_compat_1 = (byte)data[offset];
			offset += sizeof(byte);
			_compat_2 = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================



// field FEATURE_KEY_INVENTORY
//------------------------------
// 
// field=IFACE::FEATURE_KEY_INVENTORY
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_iface_featurekeyinventory_t : iMMP
	{
		public ushort _numkeys;
		public ushort _totlen;
		public sbyte[] _keys;

		// Default constructor
		public mmp_iface_featurekeyinventory_t() : this(0, 0, (sbyte[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_iface_featurekeyinventory_t(ushort a_numkeys = 0, ushort a_totlen = 0, sbyte[] a_keys = null)
		{
			_numkeys = a_numkeys;
			_totlen = a_totlen;
			_keys = a_keys ?? new sbyte[0];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_iface_featurekeyinventory_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort) + (_keys.Length * sizeof(sbyte))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_numkeys)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_totlen)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			for (int i = 0; i < _keys.Length; i++)
			{
				data[offset] = (byte)_keys[i];
				offset += sizeof(sbyte);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_iface_featurekeyinventory_t deserialize(byte[] data)
		{
			int offset = 0;

			_numkeys = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_totlen = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);

			int i = 0;
			_keys = new sbyte[(data.Length - offset) / sizeof(sbyte)];
			while (offset < data.Length)
			{
				_keys[i++] = (sbyte)data[offset];
				offset += sizeof(sbyte);
			}
			return this;
		}
	};

	//===========================================================


//**************************
// SREG Structs & Field Values
//**************************
// 
// field=SREG::*
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_sreg_fld_val_t : iMMP
	{
		public ushort _val;

		// Default constructor
		public mmp_sreg_fld_val_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_sreg_fld_val_t(ushort a_val = 0)
		{
			_val = a_val;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_sreg_fld_val_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_val)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_sreg_fld_val_t deserialize(byte[] data)
		{
			int offset = 0;

			_val = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// 
// field=SREG::ALL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_sreg_fld_val_all_t : iMMP
	{
		public ushort[] _val;

		// Default constructor
		public mmp_sreg_fld_val_all_t() : this((ushort[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_sreg_fld_val_all_t(ushort[] a_val = null)
		{
			_val = a_val ?? new ushort[60];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_sreg_fld_val_all_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return((_val.Length * sizeof(ushort))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			for (int i = 0; i < _val.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_val[i])), 0, data, offset, sizeof(ushort));
				offset += sizeof(ushort);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_sreg_fld_val_all_t deserialize(byte[] data)
		{
			int offset = 0;


			int i = 0;
			for (i = 0; i < _val.Length; )
			{
				_val[i++] = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
				offset += sizeof(ushort);
			}
			return this;
		}
	};

	//===========================================================



//**************************
// TIME Structs & Field Values
//**************************

// field TIMEDATE
//------------------------------
// 
// field=TIME::TIMEDATE
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_time_t : iMMP
	{
		public byte _isdst;
		public byte _hh;
		public byte _mm;
		public byte _ss;
		public byte _mo;
		public byte _da;
		public ushort _yr;
		public short _tz;

		// Default constructor
		public mmp_time_t() : this(0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_time_t(byte a_isdst = 0, byte a_hh = 0, byte a_mm = 0, byte a_ss = 0, byte a_mo = 0, byte a_da = 0, ushort a_yr = 0, short a_tz = 0)
		{
			_isdst = a_isdst;
			_hh = a_hh;
			_mm = a_mm;
			_ss = a_ss;
			_mo = a_mo;
			_da = a_da;
			_yr = a_yr;
			_tz = a_tz;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_time_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(ushort) + sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_isdst;
			offset += sizeof(byte);
			data[offset] = (byte)_hh;
			offset += sizeof(byte);
			data[offset] = (byte)_mm;
			offset += sizeof(byte);
			data[offset] = (byte)_ss;
			offset += sizeof(byte);
			data[offset] = (byte)_mo;
			offset += sizeof(byte);
			data[offset] = (byte)_da;
			offset += sizeof(byte);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_yr)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_tz)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_time_t deserialize(byte[] data)
		{
			int offset = 0;

			_isdst = (byte)data[offset];
			offset += sizeof(byte);
			_hh = (byte)data[offset];
			offset += sizeof(byte);
			_mm = (byte)data[offset];
			offset += sizeof(byte);
			_ss = (byte)data[offset];
			offset += sizeof(byte);
			_mo = (byte)data[offset];
			offset += sizeof(byte);
			_da = (byte)data[offset];
			offset += sizeof(byte);
			_yr = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_tz = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// field DSTPARMS
//-------------------------------
// 
// field=TIME::DSTPARMS
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_dst_t : iMMP
	{
		public byte _fwd_hr;
		public byte _fwd_mo;
		public byte _fwd_wk;
		public byte _fwd_dotw;
		public byte _back_hr;
		public byte _back_mo;
		public byte _back_wk;
		public byte _back_dotw;

		// Default constructor
		public mmp_dst_t() : this(0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_dst_t(byte a_fwd_hr = 0, byte a_fwd_mo = 0, byte a_fwd_wk = 0, byte a_fwd_dotw = 0, byte a_back_hr = 0, byte a_back_mo = 0, byte a_back_wk = 0, byte a_back_dotw = 0)
		{
			_fwd_hr = a_fwd_hr;
			_fwd_mo = a_fwd_mo;
			_fwd_wk = a_fwd_wk;
			_fwd_dotw = a_fwd_dotw;
			_back_hr = a_back_hr;
			_back_mo = a_back_mo;
			_back_wk = a_back_wk;
			_back_dotw = a_back_dotw;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_dst_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_fwd_hr;
			offset += sizeof(byte);
			data[offset] = (byte)_fwd_mo;
			offset += sizeof(byte);
			data[offset] = (byte)_fwd_wk;
			offset += sizeof(byte);
			data[offset] = (byte)_fwd_dotw;
			offset += sizeof(byte);
			data[offset] = (byte)_back_hr;
			offset += sizeof(byte);
			data[offset] = (byte)_back_mo;
			offset += sizeof(byte);
			data[offset] = (byte)_back_wk;
			offset += sizeof(byte);
			data[offset] = (byte)_back_dotw;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_dst_t deserialize(byte[] data)
		{
			int offset = 0;

			_fwd_hr = (byte)data[offset];
			offset += sizeof(byte);
			_fwd_mo = (byte)data[offset];
			offset += sizeof(byte);
			_fwd_wk = (byte)data[offset];
			offset += sizeof(byte);
			_fwd_dotw = (byte)data[offset];
			offset += sizeof(byte);
			_back_hr = (byte)data[offset];
			offset += sizeof(byte);
			_back_mo = (byte)data[offset];
			offset += sizeof(byte);
			_back_wk = (byte)data[offset];
			offset += sizeof(byte);
			_back_dotw = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================



// field RTCBATT
//-------------------------------
// 
// field=TIME::RTCBATT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_rtcbatt_t : iMMP
	{
		public short _rtcbatt_x100;

		// Default constructor
		public mmp_rtcbatt_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_rtcbatt_t(short a_rtcbatt_x100 = 0)
		{
			_rtcbatt_x100 = a_rtcbatt_x100;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_rtcbatt_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_rtcbatt_x100)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_rtcbatt_t deserialize(byte[] data)
		{
			int offset = 0;

			_rtcbatt_x100 = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================


//**************************

// field SYNCINFO
//-------------------------------
// 
// field=TIME::SYNCINFO
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_time_syncinfo_t : iMMP
	{
		public byte _pps_state;
		public byte _qualifying;
		public byte _time_sync;
		public byte _ext_time;

		// Default constructor
		public mmp_time_syncinfo_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_time_syncinfo_t(byte a_pps_state = 0, byte a_qualifying = 0, byte a_time_sync = 0, byte a_ext_time = 0)
		{
			_pps_state = a_pps_state;
			_qualifying = a_qualifying;
			_time_sync = a_time_sync;
			_ext_time = a_ext_time;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_time_syncinfo_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			data[offset] = (byte)_pps_state;
			offset += sizeof(byte);
			data[offset] = (byte)_qualifying;
			offset += sizeof(byte);
			data[offset] = (byte)_time_sync;
			offset += sizeof(byte);
			data[offset] = (byte)_ext_time;
			offset += sizeof(byte);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_time_syncinfo_t deserialize(byte[] data)
		{
			int offset = 0;

			_pps_state = (byte)data[offset];
			offset += sizeof(byte);
			_qualifying = (byte)data[offset];
			offset += sizeof(byte);
			_time_sync = (byte)data[offset];
			offset += sizeof(byte);
			_ext_time = (byte)data[offset];
			offset += sizeof(byte);
			return this;
		}
	};

	//===========================================================



//**************************
// TRANSPOND Structs & Field Values
//**************************

// field STAT
//------------------------------
// 
// field=TRANSPOND::STAT
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_transpond_stat_t : iMMP
	{
		public ushort _stat;
		public ushort _timeout;

		// Default constructor
		public mmp_transpond_stat_t() : this(0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_transpond_stat_t(ushort a_stat = 0, ushort a_timeout = 0)
		{
			_stat = a_stat;
			_timeout = a_timeout;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_transpond_stat_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_stat)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_timeout)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_transpond_stat_t deserialize(byte[] data)
		{
			int offset = 0;

			_stat = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_timeout = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================



// field PINGRCVD
//-------------------------------
// 
// field=TRANSPOND::PINGRCVD
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_transpond_pingrcvd_t : iMMP
	{
		public uint _freq;
		public uint _rt_time;
		public uint _detect_lev;
		public ushort _flags;

		// Default constructor
		public mmp_transpond_pingrcvd_t() : this(0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public mmp_transpond_pingrcvd_t(uint a_freq = 0, uint a_rt_time = 0, uint a_detect_lev = 0, ushort a_flags = 0)
		{
			_freq = a_freq;
			_rt_time = a_rt_time;
			_detect_lev = a_detect_lev;
			_flags = a_flags;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_transpond_pingrcvd_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(uint) + sizeof(uint) + sizeof(uint) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_freq)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_rt_time)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((uint)ip.HostToNetworkOrder((int)_detect_lev)), 0, data, offset, sizeof(uint));
			offset += sizeof(uint);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_flags)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_transpond_pingrcvd_t deserialize(byte[] data)
		{
			int offset = 0;

			_freq = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_rt_time = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_detect_lev = (uint)ip.NetworkToHostOrder((int)BitConverter.ToUInt32(data, offset));
			offset += sizeof(uint);
			_flags = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

	//===========================================================


// field CHNLRXADJ_<x> (except ALL)
//-------------------------------
// 
// field=TRANSPOND::CHNLRXADJ_0
// field=TRANSPOND::CHNLRXADJ_1
// field=TRANSPOND::CHNLRXADJ_2
// field=TRANSPOND::CHNLRXADJ_3
// field=TRANSPOND::CHNLRXADJ_4
// field=TRANSPOND::CHNLRXADJ_5
// field=TRANSPOND::CHNLRXADJ_6
// field=TRANSPOND::CHNLRXADJ_7
// field=TRANSPOND::CHNLRXADJ_8
// field=TRANSPOND::CHNLRXADJ_9
// field=TRANSPOND::CHNLRXADJ_10
// field=TRANSPOND::CHNLRXADJ_11
// field=TRANSPOND::CHNLRXADJ_12
// field=TRANSPOND::CHNLRXADJ_13
// field=TRANSPOND::CHNLRXADJ_14
// field=TRANSPOND::CHNLRXADJ_15
// field=TRANSPOND::CHNLRXADJ_16
// field=TRANSPOND::CHNLRXADJ_17
// field=TRANSPOND::CHNLRXADJ_18
// field=TRANSPOND::CHNLRXADJ_19
// field=TRANSPOND::CHNLRXADJ_20
// field=TRANSPOND::CHNLRXADJ_21
// field=TRANSPOND::CHNLRXADJ_22
// field=TRANSPOND::CHNLRXADJ_23
// field=TRANSPOND::CHNLRXADJ_24
// field=TRANSPOND::CHNLRXADJ_25
// field=TRANSPOND::CHNLRXADJ_26
// field=TRANSPOND::CHNLRXADJ_27
// field=TRANSPOND::CHNLRXADJ_28
// field=TRANSPOND::CHNLRXADJ_29
// field=TRANSPOND::CHNLRXADJ_30
// field=TRANSPOND::CHNLRXADJ_31
// field=TRANSPOND::CHNLRXADJ_32
// field=TRANSPOND::CHNLRXADJ_33
// field=TRANSPOND::CHNLRXADJ_34
// field=TRANSPOND::CHNLRXADJ_35
// field=TRANSPOND::CHNLRXADJ_36
// field=TRANSPOND::CHNLRXADJ_37
// field=TRANSPOND::CHNLRXADJ_38
// field=TRANSPOND::CHNLRXADJ_39
// field=TRANSPOND::CHNLRXADJ_40
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_transpond_rxadj_t : iMMP
	{
		public short _adjustment;

		// Default constructor
		public mmp_transpond_rxadj_t() : this(0) { }

		// Constructor with sequential class fields in argument list
		public mmp_transpond_rxadj_t(short a_adjustment = 0)
		{
			_adjustment = a_adjustment;
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_transpond_rxadj_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(short)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_adjustment)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_transpond_rxadj_t deserialize(byte[] data)
		{
			int offset = 0;

			_adjustment = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			return this;
		}
	};

	//===========================================================



// field CHNLRXADJ_ALL
//-------------------------------
// 
// field=TRANSPOND::CHNLRXADJ_ALL
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class mmp_transpond_rxadjall_t : iMMP
	{
		public short[] _adjustment;

		// Default constructor
		public mmp_transpond_rxadjall_t() : this((short[])null) { }

		// Constructor with sequential class fields in argument list
		public mmp_transpond_rxadjall_t(short[] a_adjustment = null)
		{
			_adjustment = a_adjustment ?? new short[41];
		}

		// Constructor to initialize class from serial data stream containing field data
		public mmp_transpond_rxadjall_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return((_adjustment.Length * sizeof(short))); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			for (int i = 0; i < _adjustment.Length; i++)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_adjustment[i])), 0, data, offset, sizeof(short));
				offset += sizeof(short);
			}
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public mmp_transpond_rxadjall_t deserialize(byte[] data)
		{
			int offset = 0;


			int i = 0;
			for (i = 0; i < _adjustment.Length; )
			{
				_adjustment[i++] = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
				offset += sizeof(short);
			}
			return this;
		}
	};

	//===========================================================

// Structures populated on demand by get_smartbatt_info() API call
// 
// cmdresult=STD::GETSMARTBATTDATA
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class smartbatt_info_t : iMMP
	{
		public ushort _batt_mode;
		public short _temperature;
		public ushort _voltage;
		public short _current;
		public short _avg_current;
		public ushort _max_error;
		public ushort _batt_charge;
		public ushort _abs_charge;
		public ushort _rem_capacity;
		public ushort _full_chg_capacity;
		public short _mins_to_empty;
		public short _mins_to_full;
		public ushort _batt_status;
		public ushort _cycle_count;
		public ushort _design_capacity;
		public ushort _mfg_date;
		public ushort _serno;

		// Default constructor
		public smartbatt_info_t() : this(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) { }

		// Constructor with sequential class fields in argument list
		public smartbatt_info_t(ushort a_batt_mode = 0, short a_temperature = 0, ushort a_voltage = 0, short a_current = 0, short a_avg_current = 0, ushort a_max_error = 0, ushort a_batt_charge = 0, ushort a_abs_charge = 0, ushort a_rem_capacity = 0, ushort a_full_chg_capacity = 0, short a_mins_to_empty = 0, short a_mins_to_full = 0, ushort a_batt_status = 0, ushort a_cycle_count = 0, ushort a_design_capacity = 0, ushort a_mfg_date = 0, ushort a_serno = 0)
		{
			_batt_mode = a_batt_mode;
			_temperature = a_temperature;
			_voltage = a_voltage;
			_current = a_current;
			_avg_current = a_avg_current;
			_max_error = a_max_error;
			_batt_charge = a_batt_charge;
			_abs_charge = a_abs_charge;
			_rem_capacity = a_rem_capacity;
			_full_chg_capacity = a_full_chg_capacity;
			_mins_to_empty = a_mins_to_empty;
			_mins_to_full = a_mins_to_full;
			_batt_status = a_batt_status;
			_cycle_count = a_cycle_count;
			_design_capacity = a_design_capacity;
			_mfg_date = a_mfg_date;
			_serno = a_serno;
		}

		// Constructor to initialize class from serial data stream containing field data
		public smartbatt_info_t(byte[] data) : this()
		{
			this.deserialize(data);
		}

		// Retrieve the size of this object as instantiated, including any variable length members
		public int Size
		{
			get { return(sizeof(ushort) + sizeof(short) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(short) + sizeof(short) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(ushort)); }
		}

		// Write out the members of this class to an MMP-compatible serial data stream
		public byte[] serialize()
		{
			int offset = 0;
			byte[] data = new byte[this.Size];
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_batt_mode)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_temperature)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_voltage)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_current)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_avg_current)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_max_error)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_batt_charge)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_abs_charge)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_rem_capacity)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_full_chg_capacity)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_mins_to_empty)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((short)ip.HostToNetworkOrder((short)_mins_to_full)), 0, data, offset, sizeof(short));
			offset += sizeof(short);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_batt_status)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_cycle_count)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_design_capacity)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_mfg_date)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			Buffer.BlockCopy(BitConverter.GetBytes((ushort)ip.HostToNetworkOrder((short)_serno)), 0, data, offset, sizeof(ushort));
			offset += sizeof(ushort);
			return data;
		}

		// Populate the members of this class from an MMP-compatible serial data stream
		public smartbatt_info_t deserialize(byte[] data)
		{
			int offset = 0;

			_batt_mode = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_temperature = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_voltage = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_current = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_avg_current = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_max_error = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_batt_charge = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_abs_charge = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_rem_capacity = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_full_chg_capacity = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_mins_to_empty = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_mins_to_full = (short)ip.NetworkToHostOrder((short)BitConverter.ToInt16(data, offset));
			offset += sizeof(short);
			_batt_status = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_cycle_count = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_design_capacity = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_mfg_date = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			_serno = (ushort)ip.NetworkToHostOrder((short)BitConverter.ToUInt16(data, offset));
			offset += sizeof(ushort);
			return this;
		}
	};

    public class MMP_field_cmd_info
    {
        public Type msgbody;
        public Type cmdresult_msgbody;

        public MMP_field_cmd_info(Type a_msgbody, Type a_cmdresult_msgbody)
        {
            msgbody = a_msgbody;
            cmdresult_msgbody = a_cmdresult_msgbody;
        }
    }

    public class MMP_subsys_cmdsect_info
    {
        public Type enumerations;
        public Dictionary<byte, MMP_field_cmd_info> dict;

        public MMP_subsys_cmdsect_info(Type a_enum, Dictionary<byte, MMP_field_cmd_info> a_dict)
        {
            enumerations = a_enum;
            dict = a_dict;
        }
    }

    public static class MMP_Dictionary
    {
        public static Dictionary<Byte, MMP_subsys_cmdsect_info> subsys_dict;
        public static Dictionary<Byte, MMP_subsys_cmdsect_info> cmdsect_dict;
        public static Dictionary<Type, Dictionary<String, Type>> msgbody_dict;
        
		static MMP_Dictionary()
		{

			subsys_dict = new Dictionary<Byte, MMP_subsys_cmdsect_info>
			{
				{ (byte)mmp_subsys_t.MMP_SUBSYS_IFACE,
					new MMP_subsys_cmdsect_info(typeof(mmp_iface_fld_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_MMPSTAT, 
								new MMP_field_cmd_info(typeof(mmp_iface_stat_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_ERR, 
								new MMP_field_cmd_info(typeof(mmp_sfl_err_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_UNIT_SERNO, 
								new MMP_field_cmd_info(typeof(mmp_iface_unit_serno_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_NTFY_COUNT, 
								new MMP_field_cmd_info(typeof(mmp_iface_flag_enable_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_NTFY_CKSUM, 
								new MMP_field_cmd_info(typeof(mmp_iface_flag_enable_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_AES_USER_KEY, 
								new MMP_field_cmd_info(typeof(mmp_iface_aes_key_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_COMPATIBILITY, 
								new MMP_field_cmd_info(typeof(mmp_iface_compatibility_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_FEATURE_KEY_INVENTORY, 
								new MMP_field_cmd_info(typeof(mmp_iface_featurekeyinventory_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_GATE_DATA_DIRECTIONAL, 
								new MMP_field_cmd_info(typeof(mmp_iface_flag_enable_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_VERSION, 
								new MMP_field_cmd_info(typeof(mmp_version_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_CMDRESULT, 
								new MMP_field_cmd_info(typeof(mmp_cmd_result_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_BLOCKNOTIFY, 
								new MMP_field_cmd_info(typeof(mmp_iface_blocknotify_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_UNBLOCKNOTIFY, 
								new MMP_field_cmd_info(typeof(mmp_iface_blocknotify_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_DSP_SW_VERSION, 
								new MMP_field_cmd_info(typeof(mmp_iface_dsp_sw_version_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_PRIVLEV, 
								new MMP_field_cmd_info(typeof(mmp_iface_privlev_t), null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_REMOTE_MMPRESP, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_iface_fld_t.MMP_IFACE_FLD_FEATURE_KEY, 
								new MMP_field_cmd_info(typeof(mmp_iface_featurekey_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.MMP_SUBSYS_SREG,
					new MMP_subsys_cmdsect_info(typeof(mmp_sreg_fld_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_VERSION, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_LPTIMEOUT, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_FLOWCTRL, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_TESTMSGLEN, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_VERBOSITY, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_REMADDR, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_LOCADDR, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_POSACK, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_RXTHRESHOLD, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_BAND, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_ALL, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_all_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_SERBAUD, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_TXPULSEWIDTH, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_RXPULSEWIDTH, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_ACOUBAUD, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_TAT, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_PPSSYNC, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_RXFREQ, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_XPNDLOCKOUT, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_TXPOWER, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_RESPTIMEOUT, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_FWDDELAY, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
							{ (byte)mmp_sreg_fld_t.MMP_SREG_FLD_COPROC, 
								new MMP_field_cmd_info(typeof(mmp_sreg_fld_val_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.MMP_SUBSYS_DECKBOX,
					new MMP_subsys_cmdsect_info(typeof(mmp_deckbox_fld_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_deckbox_fld_t.MMP_DECKBOX_FLD_SPKRVOL, 
								new MMP_field_cmd_info(typeof(mmp_spkr_phones_vol_t), null) },
							{ (byte)mmp_deckbox_fld_t.MMP_DECKBOX_FLD_PHONESVOL, 
								new MMP_field_cmd_info(typeof(mmp_spkr_phones_vol_t), null) },
							{ (byte)mmp_deckbox_fld_t.MMP_DECKBOX_FLD_PWRSENSE, 
								new MMP_field_cmd_info(typeof(mmp_pwrsense_t), null) },
							{ (byte)mmp_deckbox_fld_t.MMP_DECKBOX_FLD_BATTLEV, 
								new MMP_field_cmd_info(typeof(mmp_battlev_t), null) },
							{ (byte)mmp_deckbox_fld_t.MMP_DECKBOX_FLD_BATTVOLT, 
								new MMP_field_cmd_info(typeof(mmp_battvolt_t), null) },
							{ (byte)mmp_deckbox_fld_t.MMP_DECKBOX_FLD_MODEL, 
								new MMP_field_cmd_info(typeof(mmp_udb_model_t), null) },
							{ (byte)mmp_deckbox_fld_t.MMP_DECKBOX_FLD_GPS_RELAY, 
								new MMP_field_cmd_info(typeof(mmp_gps_relay_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.MMP_SUBSYS_DATA,
					new MMP_subsys_cmdsect_info(typeof(mmp_data_fld_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_ACK, 
								new MMP_field_cmd_info(typeof(mmp_data_ack_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_REMOTE_DATA, 
								new MMP_field_cmd_info(typeof(mmp_remote_data_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_DIRECTIONAL, 
								new MMP_field_cmd_info(typeof(mmp_data_directional_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_FPM_VERSION, 
								new MMP_field_cmd_info(typeof(mmp_data_fpm_version_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_PSK_PKT_NO_COPROC, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_LOW_POWER, 
								new MMP_field_cmd_info(typeof(mmp_data_lowpower_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_ACSTATS, 
								new MMP_field_cmd_info(typeof(mmp_data_acstats_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_REMOTE_DLOGBLK, 
								new MMP_field_cmd_info(typeof(mmp_remote_data_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_HEADER_ERROR, 
								new MMP_field_cmd_info(typeof(mmp_data_hdrerr_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_NAV_STATUS, 
								new MMP_field_cmd_info(typeof(mmp_data_nav_status_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_RANGE_UPDATE, 
								new MMP_field_cmd_info(typeof(mmp_data_rangeupdate_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_FPM_BOOT_FAIL, 
								new MMP_field_cmd_info(typeof(mmp_data_fpm_boot_failure_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_XMIT_OVERTEMP, 
								new MMP_field_cmd_info(typeof(mmp_data_xmit_overtemp_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_RCV_GAIN, 
								new MMP_field_cmd_info(typeof(mmp_data_rcv_gain_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_SPECTRUM_STATUS, 
								new MMP_field_cmd_info(typeof(mmp_spectrum_stat_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_SPECTRUM_DATA, 
								new MMP_field_cmd_info(typeof(mmp_spectrum_data_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_DIRECTIONAL_DEBUG, 
								new MMP_field_cmd_info(typeof(mmp_data_directional_debug_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_TONAL_LOCATOR, 
								new MMP_field_cmd_info(typeof(mmp_data_locator_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_DIRECTIONAL_LOCDEBUG, 
								new MMP_field_cmd_info(typeof(mmp_data_directional_locdebug_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_JANUS_PACKET, 
								new MMP_field_cmd_info(typeof(mmp_data_janus_packet_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_ACOUTRIG_COMPLETE, 
								new MMP_field_cmd_info(typeof(mmp_acoutrig_complete_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_ACOUTRIG_TIMEOUT, 
								new MMP_field_cmd_info(typeof(mmp_acoutrig_complete_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_BURN_COMPLETE, 
								new MMP_field_cmd_info(typeof(mmp_burn_complete_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_RESPBUFFER_XMIT, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_RNGBRG_UPDATE, 
								new MMP_field_cmd_info(typeof(mmp_data_rngbrg_update_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_TRRC_STATUS, 
								new MMP_field_cmd_info(typeof(mmp_data_trrc_status_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_FEAT_KEY_STATUS, 
								new MMP_field_cmd_info(typeof(mmp_data_feat_key_status_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_REMOTE_HEADER, 
								new MMP_field_cmd_info(typeof(mmp_data_remote_header_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_TIMESTAMP, 
								new MMP_field_cmd_info(typeof(mmp_data_timestamp_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_DOPPLER, 
								new MMP_field_cmd_info(typeof(mmp_data_doppler_t), null) },
							{ (byte)mmp_data_fld_t.MMP_DATA_FLD_BURN_TIMEOUT, 
								new MMP_field_cmd_info(typeof(mmp_burn_complete_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.MMP_SUBSYS_TRANSPOND,
					new MMP_subsys_cmdsect_info(typeof(mmp_transpond_fld_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_STAT, 
								new MMP_field_cmd_info(typeof(mmp_transpond_stat_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_PINGRCVD, 
								new MMP_field_cmd_info(typeof(mmp_transpond_pingrcvd_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_8, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_9, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_10, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_11, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_12, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_13, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_14, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_15, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_16, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_17, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_0, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_18, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_19, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_20, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_21, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_22, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_23, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_24, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_25, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_26, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_27, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_1, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_28, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_29, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_30, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_31, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_32, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_33, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_34, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_35, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_36, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_37, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_2, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_38, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_39, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_40, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_ALL, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadjall_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_3, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_4, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_5, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_6, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
							{ (byte)mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_7, 
								new MMP_field_cmd_info(typeof(mmp_transpond_rxadj_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.MMP_SUBSYS_TIME,
					new MMP_subsys_cmdsect_info(typeof(mmp_time_fld_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_time_fld_t.MMP_TIME_FLD_1PPS_PULSE, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_time_fld_t.MMP_TIME_FLD_TIMEDATE, 
								new MMP_field_cmd_info(typeof(mmp_time_t), null) },
							{ (byte)mmp_time_fld_t.MMP_TIME_FLD_DSTPARMS, 
								new MMP_field_cmd_info(typeof(mmp_dst_t), null) },
							{ (byte)mmp_time_fld_t.MMP_TIME_FLD_RTCBATT, 
								new MMP_field_cmd_info(typeof(mmp_rtcbatt_t), null) },
							{ (byte)mmp_time_fld_t.MMP_TIME_FLD_SYNCINFO, 
								new MMP_field_cmd_info(typeof(mmp_time_syncinfo_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.MMP_SUBSYS_CFG_ALL,
					new MMP_subsys_cmdsect_info(null,
						new Dictionary<Byte, MMP_field_cmd_info>
						{
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_COPROC,
					new MMP_subsys_cmdsect_info(typeof(cfg_coproc_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_coproc_param_enum_t.CFG_COPROC_CPBOARD, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_coproc_param_enum_t.CFG_COPROC_FDFWDTAPS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_coproc_param_enum_t.CFG_COPROC_FDBCKTAPS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_DATALOG,
					new MMP_subsys_cmdsect_info(typeof(cfg_datalog_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_datalog_param_enum_t.CFG_DATALOG_ACDATA, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_datalog_param_enum_t.CFG_DATALOG_ACSTATS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_datalog_param_enum_t.CFG_DATALOG_RINGBUF, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_datalog_param_enum_t.CFG_DATALOG_SUBBLKS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_datalog_param_enum_t.CFG_DATALOG_LOGMODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_datalog_param_enum_t.CFG_DATALOG_SENTINEL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_datalog_param_enum_t.CFG_DATALOG_CHRCOUNT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_datalog_param_enum_t.CFG_DATALOG_LOGSTORE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_MODEM,
					new MMP_subsys_cmdsect_info(typeof(cfg_modem_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_DATARETRY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_ACRSPTMOUT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_RXPKTTYPE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_SHOWBADDATA, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_STARTTONES, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_TXRATE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_TXPOWER, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_WAKETONES, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_RSVD1, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_INPUTMODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_SMARTRETRY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_L2PROTOCOL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_OPMODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_HEADERRATE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_DOMAINKEY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_AUTODETECTHDR, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_CHIRP_THRESHOLD, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_TXATTEN, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_ADDRGROUP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_APCNOISSEL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_APCALPHSM, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_APCALPHSM2, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_APCMAXTXP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_DEVENABLE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_APCMINTXP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_ACKMODE_DONOTUSE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_UNUSED1, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_FWDDELAY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_UNUSED2, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_LOCALADDR, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_PRNTHEX, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_modem_param_enum_t.CFG_MODEM_REMOTEADDR, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_RELEASE,
					new MMP_subsys_cmdsect_info(typeof(cfg_release_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_FSKRLSDUR, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_LSTCOMMSCNT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_RLSCODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_UNUSED1, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_TIMEDRELEASE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_MOTORTYPE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_RLSMINENATIME, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_RLSMAXENATIME, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_release_param_enum_t.CFG_RELEASE_ACOUTRIGTERM, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_SERIAL,
					new MMP_subsys_cmdsect_info(typeof(cfg_serial_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1BAUD, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1ECHOCHAR, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2IDLEPOL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2STRIPB7, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2NOSLEEP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1MODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2MODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2PROTOCOL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_LPFLOWCTL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1PROMPT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2PROMPT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1FLOWCTL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1IDLEPOL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1PROTOCOL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1STRIPB7, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P1NOSLEEP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2BAUD, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2ECHOCHAR, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_serial_param_enum_t.CFG_SERIAL_P2FLOWCTL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_SYSTEM,
					new MMP_subsys_cmdsect_info(typeof(cfg_system_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_AUXINP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_ASCIIBIN, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_SYNCPPS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_VERBOSE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_WAKETHRESH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_AUXOUT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_UNUSED1, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_VOLCONT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_CMFASTWAKE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_NAMEFORMAT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_IDLETIMER, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_PROMPT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_BANDWIDTH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_SYNCOUT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_PULLUP0, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_PULLUP1, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_MINOPVOLT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_BATTERYTYPE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_BATTERYCAPACITY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_BATTERYMFGDATE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_TILTAXIS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_PWRONTIMER, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_AWAKETIMER, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_CARRFREQ, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_ARWAKEHIB, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_RXSENS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_AWAKEPOWER, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_TXSENS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_TXINTERP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_IOMODE0, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_COMPMDMRST, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_CMWAKEHIB, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_CMWAKELISTEN, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_HALFBW, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_FHTHRESH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_system_param_enum_t.CFG_SYSTEM_RLSTYPE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_TEST,
					new MMP_subsys_cmdsect_info(typeof(cfg_test_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_test_param_enum_t.CFG_TEST_DBGLVL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_test_param_enum_t.CFG_TEST_RCVALL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_test_param_enum_t.CFG_TEST_RSPDELAY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_test_param_enum_t.CFG_TEST_PKTECHO, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_test_param_enum_t.CFG_TEST_PKTSIZE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_test_param_enum_t.CFG_TEST_UNUSED1, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_test_param_enum_t.CFG_TEST_SIMACDLY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_test_param_enum_t.CFG_TEST_TXSATURATE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_test_param_enum_t.CFG_TEST_UNUSED2, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_VERSION,
					new MMP_subsys_cmdsect_info(typeof(cfg_version_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_version_param_enum_t.CFG_VERSION_SWAPPNAME, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_version_param_enum_t.CFG_VERSION_SWVERSION, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_version_param_enum_t.CFG_VERSION_DBVERSION, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_XPND,
					new MMP_subsys_cmdsect_info(typeof(cfg_xpnd_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_RXFREQ, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_RXLOCKOUT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_XPNDEMUMODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_HPR400CHAN, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_RESPONDER, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_CHIRP_RESP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_BANDWIDTH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_LOGRESULTS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_GAPSRX, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_GAPSTX, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_GAPSWAKE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_RXTONEDUR, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_TAT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_TXTONEDUR, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_RXTHRESH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_AGCREF, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_RESPFREQ, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_LBLMODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_xpnd_param_enum_t.CFG_XPND_XPNDEMUTAT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_DAT,
					new MMP_subsys_cmdsect_info(typeof(cfg_dat_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_PREGAIN, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_ROTATION, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_BEARINGRESP, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_VTHRESH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_MIN_ELEV, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_MAX_ELEV, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_PHASEREF, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_ARRIVAL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_VERBOSE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_RXONDAT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_WRAPRANGE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_ORIENTATION, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_PHASEA, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_PHASEB, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_PHASEC, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_dat_param_enum_t.CFG_DAT_PHASED, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_NAV,
					new MMP_subsys_cmdsect_info(typeof(cfg_nav_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_LATITUDE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_LONGITUDE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_HEADOFFSET, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_SYNCRANGING, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_PITCHOFFSET, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_ROLLOFFSET, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_GPSSYNCMSG, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_GPSALT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_ALTITUDE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_DEPTH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_COMPASS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_PITCH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_ROLL, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_CSOUND, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_nav_param_enum_t.CFG_NAV_REPLY_DATA, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_RECORDER,
					new MMP_subsys_cmdsect_info(typeof(cfg_recorder_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_recorder_param_enum_t.CFG_RECORDER_FRONTEND, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_recorder_param_enum_t.CFG_RECORDER_RECMODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_recorder_param_enum_t.CFG_RECORDER_RECFORMAT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_recorder_param_enum_t.CFG_RECORDER_NAMEFORMAT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_recorder_param_enum_t.CFG_RECORDER_RXSENS, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_TRANSPORT,
					new MMP_subsys_cmdsect_info(typeof(cfg_transport_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_transport_param_enum_t.CFG_TRANSPORT_L4ENB, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_transport_param_enum_t.CFG_TRANSPORT_TPMODE, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_transport_param_enum_t.CFG_TRANSPORT_DST1, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_transport_param_enum_t.CFG_TRANSPORT_DST2, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_transport_param_enum_t.CFG_TRANSPORT_DST3, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_transport_param_enum_t.CFG_TRANSPORT_DST4, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_transport_param_enum_t.CFG_TRANSPORT_SRCP1, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_transport_param_enum_t.CFG_TRANSPORT_SRCP2, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_AIN,
					new MMP_subsys_cmdsect_info(typeof(cfg_ain_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_POLLRATE, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_1NMEAS, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_3STRTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_3RPTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_4NMEAS, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_4STRTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_4RPTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_5NMEAS, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_5STRTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_5RPTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_6NMEAS, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_6STRTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_1STRTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_6RPTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_1RPTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_1TYPE, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_2NMEAS, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_2STRTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_2RPTDLY, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_2TYPE, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_ain_param_enum_t.CFG_AIN_3NMEAS, 
								new MMP_field_cmd_info(null, null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_PRESSURE,
					new MMP_subsys_cmdsect_info(typeof(cfg_pressure_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_pressure_param_enum_t.CFG_PRESSURE_AINCHNL, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_pressure_param_enum_t.CFG_PRESSURE_METERSPERPSI, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_pressure_param_enum_t.CFG_PRESSURE_ATMOFFSET, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_pressure_param_enum_t.CFG_PRESSURE_PSI, 
								new MMP_field_cmd_info(null, null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_USBL,
					new MMP_subsys_cmdsect_info(typeof(cfg_usbl_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_usbl_param_enum_t.CFG_USBL_FORMAT, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_usbl_param_enum_t.CFG_USBL_DEPTH_QUERY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_usbl_param_enum_t.CFG_USBL_REPEAT_QUERY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_usbl_param_enum_t.CFG_USBL_AUTO_QUERY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_usbl_param_enum_t.CFG_USBL_AUTO_DELAY, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
							{ (byte)cfg_usbl_param_enum_t.CFG_USBL_XDCER_DEPTH, 
								new MMP_field_cmd_info(typeof(mmp_cfg_paramval_t), null) },
						})
				},
				{ (byte)mmp_subsys_t.CFG_SECT_JANUS,
					new MMP_subsys_cmdsect_info(typeof(cfg_janus_param_enum_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)cfg_janus_param_enum_t.CFG_JANUS_CLASSUSERID, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_janus_param_enum_t.CFG_JANUS_APPTYPE, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)cfg_janus_param_enum_t.CFG_JANUS_MACTHRESH, 
								new MMP_field_cmd_info(null, null) },
						})
				},
			};

			cmdsect_dict = new Dictionary<Byte, MMP_subsys_cmdsect_info>
			{
				{ (byte)mmp_cmdsect_t.MMP_CMDSECT_NULL,
					new MMP_subsys_cmdsect_info(null,
						new Dictionary<Byte, MMP_field_cmd_info>
						{
						})
				},
				{ (byte)mmp_cmdsect_t.MMP_CMDSECT_STD,
					new MMP_subsys_cmdsect_info(typeof(mmp_std_cmd_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_INFO, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_MMPREQ, 
								new MMP_field_cmd_info(typeof(mmp_remote_request_t), typeof(mmp_remote_mmpresp_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_RESET, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETBATT, 
								new MMP_field_cmd_info(typeof(mmp_remote_t), typeof(mmp_remote_battvoltage_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_CMWAKEUP, 
								new MMP_field_cmd_info(typeof(mmp_remote_cmwakeup_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETAGCHIST, 
								new MMP_field_cmd_info(typeof(mmp_remote_t), typeof(mmp_remote_agchist_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_AUTOBAUD, 
								new MMP_field_cmd_info(typeof(mmp_remote_autobaud_t), typeof(mmp_remote_autobaud_result_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETBATTCHG, 
								new MMP_field_cmd_info(typeof(mmp_remote_t), typeof(mmp_remote_battcharge_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SENDCMD, 
								new MMP_field_cmd_info(typeof(mmp_remote_senddata_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_TILT_ACCEL, 
								new MMP_field_cmd_info(typeof(mmp_tilt_accel_t), typeof(mmp_tilt_accel_response_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_AXIS_TILT, 
								new MMP_field_cmd_info(null, typeof(mmp_axis_tilt_response_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_RESET_BATT_METERING, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_FLASH_SREGS, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_BATT_METER, 
								new MMP_field_cmd_info(null, typeof(battery_metering_info_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETMETER, 
								new MMP_field_cmd_info(typeof(mmp_remote_t), typeof(battery_metering_info_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_GETBATT, 
								new MMP_field_cmd_info(null, typeof(mmp_battvoltage_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_GETBATTCHG, 
								new MMP_field_cmd_info(null, typeof(mmp_battcharge_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_GETAGCHIST, 
								new MMP_field_cmd_info(null, typeof(mmp_agchist_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETONESREG, 
								new MMP_field_cmd_info(typeof(mmp_remote_getonesreg_t), typeof(mmp_remote_getonesreg_resp_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SETONESREG, 
								new MMP_field_cmd_info(typeof(mmp_remote_setonesreg_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_RESET, 
								new MMP_field_cmd_info(typeof(mmp_remote_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_BOARD_TEMP, 
								new MMP_field_cmd_info(typeof(mmp_board_temp_t), typeof(mmp_board_temp_resp_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SENDBREAK, 
								new MMP_field_cmd_info(typeof(mmp_remote_senddata_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_RESET_SREGS, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_CONT_XMIT_TEST, 
								new MMP_field_cmd_info(typeof(mmp_std_contxmit_enable_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_SET_REMOTE_GROUP, 
								new MMP_field_cmd_info(typeof(mmp_std_set_remote_group_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_GETSMARTBATTDATA, 
								new MMP_field_cmd_info(typeof(mmp_std_getsmartbattdata_t), typeof(smartbatt_info_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_ADDFEATUREKEY, 
								new MMP_field_cmd_info(typeof(mmp_std_featkeystring_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_DELFEATUREKEY, 
								new MMP_field_cmd_info(typeof(mmp_std_featkeystring_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_HANGUP, 
								new MMP_field_cmd_info(typeof(mmp_remote_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_SENDJANUSPACKET, 
								new MMP_field_cmd_info(typeof(mmp_data_janus_packet_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_WRITE_DEVICE, 
								new MMP_field_cmd_info(typeof(mmp_write_device_t), typeof(mmp_write_device_result_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_READ_DEVICE, 
								new MMP_field_cmd_info(typeof(mmp_read_device_t), typeof(mmp_read_device_result_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_LEN_DEVICE, 
								new MMP_field_cmd_info(typeof(mmp_len_device_t), typeof(mmp_len_device_result_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SETACOUBAUD, 
								new MMP_field_cmd_info(typeof(mmp_remote_setacoubaud_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_FIND_DEVICE, 
								new MMP_field_cmd_info(typeof(mmp_find_device_t), typeof(mmp_find_device_result_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SETTXPOWER, 
								new MMP_field_cmd_info(typeof(mmp_remote_settxpower_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETSREGS, 
								new MMP_field_cmd_info(typeof(mmp_remote_t), typeof(mmp_remote_sregisters_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SENDDATA, 
								new MMP_field_cmd_info(typeof(mmp_remote_senddata_t), null) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_REMOTE_TESTLINK, 
								new MMP_field_cmd_info(typeof(mmp_remote_t), typeof(mmp_remote_testmsgstats_t)) },
							{ (byte)mmp_std_cmd_t.MMP_STD_CMD_UPDATE_FIRMWARE, 
								new MMP_field_cmd_info(typeof(mmp_update_firmware_t), null) },
						})
				},
				{ (byte)mmp_cmdsect_t.MMP_CMDSECT_RNGRLS,
					new MMP_subsys_cmdsect_info(typeof(mmp_rngrls_cmd_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_TRANSPOND, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_transpond_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RANGE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_range_t), typeof(mmp_rngrls_cmdresult_range_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_GEOPRO_RELEASE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_geopro_param_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_NAVDATA, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_navdata_t), typeof(mmp_rngrls_cmdresult_navdata_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_CHANNEL_PROBE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_channel_probe_param_t), typeof(mmp_rngrls_cmdresult_channel_probe_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_RANGE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_rseries_range_t), typeof(mmp_rngrls_cmdresult_range_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_ACTIVATE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_rseries_activate_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_HIBERNATE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_rseries_hib_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_XPND_MODE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_xpnd_mode_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_STD_XPND_MODE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_xpnd_mode_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_DB_UNLOCK, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_rseries_dblock_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_DB_LOCK, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_rseries_dblock_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RELEASE_STATUS, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_release_status_t), typeof(mmp_rngrls_cmdresult_release_status_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_RELEASE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_rseries_release_t), typeof(mmp_rngrls_cmdresult_release_response_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RESPONDER_RANGE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_responder_range_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_TRANSPOND_W_TIMEOUT, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_transpond_w_timeout_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RANGE_W_TIMEOUT, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_range_t), typeof(mmp_rngrls_cmdresult_range_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_SPECTRUM_MODE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_spectrum_mode_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RANGE_USBL_REPEAT, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_range_repeat_t), typeof(mmp_rngrls_cmdresult_range_usbl_repeat_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_ABSREL, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_absrel_t), typeof(mmp_rngrls_cmdresult_absrel_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_ACOU_SAMPLE, 
								new MMP_field_cmd_info(null, typeof(mmp_rngrls_cmdresult_acou_sample_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_SMART_RELEASE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_smart_release_burnwire_t), typeof(mmp_rngrls_cmdresult_release_response_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_ABSCMPDEP, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_absrel_t), typeof(mmp_rngrls_cmdresult_abscmpdep_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_ACOUSTIC_TRIGGER, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_acoustic_trigger_t), typeof(mmp_rngrls_cmdresult_release_response_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_BEARING_W_TIMEOUT, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_bearing_t), typeof(mmp_rngrls_cmdresult_bearing_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_BURNWIRE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_smart_release_burnwire_t), typeof(mmp_rngrls_cmdresult_release_response_t)) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_FSK_RELEASE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_fsk_param_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_EDGETECH_RELEASE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_edgetech_param_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_URI_RELEASE, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_uri_param_t), null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_FLASH_XPNDADJ, 
								new MMP_field_cmd_info(null, null) },
							{ (byte)mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_BEARING, 
								new MMP_field_cmd_info(typeof(mmp_rngrls_bearing_t), typeof(mmp_rngrls_cmdresult_bearing_t)) },
						})
				},
				{ (byte)mmp_cmdsect_t.MMP_CMDSECT_DATALOG,
					new MMP_subsys_cmdsect_info(typeof(mmp_datalog_cmd_t),
						new Dictionary<Byte, MMP_field_cmd_info>
						{
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_CLEAR, 
								new MMP_field_cmd_info(typeof(mmp_remote_or_local_t), null) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_SIZE, 
								new MMP_field_cmd_info(typeof(mmp_remote_or_local_t), typeof(mmp_datalog_cmdresult_size_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_DUMP, 
								new MMP_field_cmd_info(typeof(mmp_datalog_dump_t), typeof(mmp_datalog_cmdresult_dump_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_SRCINFO, 
								new MMP_field_cmd_info(typeof(mmp_datalog_srcinfo_t), typeof(mmp_datalog_cmdresult_srcinfo_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_REMOTE_GETDLOGBLK, 
								new MMP_field_cmd_info(typeof(mmp_datalog_remote_getdlogblk_t), null) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_READ_DATA, 
								new MMP_field_cmd_info(typeof(mmp_datalog_read_t), typeof(mmp_datalog_cmdresult_read_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_READ_PAGE, 
								new MMP_field_cmd_info(typeof(mmp_datalog_read_t), typeof(mmp_datalog_cmdresult_read_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_READ_SECTOR, 
								new MMP_field_cmd_info(typeof(mmp_datalog_read_t), typeof(mmp_datalog_cmdresult_read_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_WRITE_DATA, 
								new MMP_field_cmd_info(typeof(mmp_datalog_write_t), typeof(mmp_datalog_cmdresult_write_data_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_SEEK, 
								new MMP_field_cmd_info(typeof(mmp_datalog_seek_t), null) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_TELL, 
								new MMP_field_cmd_info(null, typeof(mmp_datalog_cmdresult_tell_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_LIST, 
								new MMP_field_cmd_info(null, typeof(mmp_datalog_cmdresult_list_t)) },
							{ (byte)mmp_datalog_cmd_t.MMP_DATALOG_CMD_FIND, 
								new MMP_field_cmd_info(typeof(mmp_datalog_find_t), typeof(mmp_datalog_cmdresult_find_t)) },
						})
				},
			};

			msgbody_dict = new Dictionary<Type, Dictionary<String, Type>>
			{
				{ typeof(mmp_axis_tilt_response_t),
					new Dictionary<String, Type>
					{
						{ "_axis_w_pol", typeof(tilt_axis_and_polarity_t) },
					}
				},
				{ typeof(mmp_battcharge_t),
					new Dictionary<String, Type>
					{
						{ "_charge", typeof(mmp_remote_battcharge_charge_t) },
					}
				},
				{ typeof(mmp_battlev_t),
					new Dictionary<String, Type>
					{
						{ "_charge", typeof(mmp_deckbox_battlev_charge_t) },
					}
				},
				{ typeof(mmp_cfg_paramval_t),
					new Dictionary<String, Type>
					{
						{ "_type", typeof(cfg_param_type_t) },
						{ "_val_or_len", typeof(mmp_various_t) },
					}
				},
				{ typeof(mmp_cmd_result_t),
					new Dictionary<String, Type>
					{
						{ "_cmdsect", typeof(mmp_cmdsect_t) },
						{ "_message", typeof(mmp_cmdresult_msg_t) },
					}
				},
				{ typeof(mmp_data_ack_t),
					new Dictionary<String, Type>
					{
						{ "_ack", typeof(ack_code_t) },
					}
				},
				{ typeof(mmp_data_acstats_t),
					new Dictionary<String, Type>
					{
						{ "_mod_spec", typeof(modspec_t) },
					}
				},
				{ typeof(mmp_data_feat_key_status_t),
					new Dictionary<String, Type>
					{
						{ "_available_features", typeof(modem_feature_bitflag_t) },
						{ "_enabled_features", typeof(modem_feature_bitflag_t) },
						{ "_expected_features", typeof(modem_feature_bitflag_t) },
						{ "_unauthorized_features", typeof(modem_feature_bitflag_t) },
					}
				},
				{ typeof(mmp_data_fpm_boot_failure_t),
					new Dictionary<String, Type>
					{
						{ "_failure", typeof(mmp_bool_t) },
					}
				},
				{ typeof(mmp_data_janus_packet_t),
					new Dictionary<String, Type>
					{
						{ "_class_userid", typeof(JANUS_classid_t) },
						{ "_schedule_type", typeof(mmp_janus_schedule_type_t) },
					}
				},
				{ typeof(mmp_data_lowpower_t),
					new Dictionary<String, Type>
					{
						{ "_lpstat", typeof(mmp_lowpower_lpstat_t) },
						{ "_waketype", typeof(wake_type_t) },
					}
				},
				{ typeof(mmp_data_nav_status_t),
					new Dictionary<String, Type>
					{
						{ "_attitude", typeof(nav_validity_t) },
						{ "_heading", typeof(nav_validity_t) },
						{ "_location", typeof(nav_validity_t) },
					}
				},
				{ typeof(mmp_data_rangeupdate_t),
					new Dictionary<String, Type>
					{
						{ "_range_type", typeof(mmp_rangeupdate_range_type_t) },
					}
				},
				{ typeof(mmp_data_remote_header_t),
					new Dictionary<String, Type>
					{
						{ "_type", typeof(std_layer2_command_t) },
					}
				},
				{ typeof(mmp_data_timestamp_t),
					new Dictionary<String, Type>
					{
						{ "_event", typeof(mmp_timestamp_event_t) },
					}
				},
				{ typeof(mmp_data_trrc_status_t),
					new Dictionary<String, Type>
					{
						{ "_rc_band_fail", typeof(mmp_bool_t) },
						{ "_rc_read_fail", typeof(mmp_bool_t) },
						{ "_tr_band_fail", typeof(mmp_bool_t) },
						{ "_tr_read_fail", typeof(mmp_bool_t) },
					}
				},
				{ typeof(mmp_datalog_cmdresult_dump_t),
					new Dictionary<String, Type>
					{
						{ "_source", typeof(datalog_source_t) },
					}
				},
				{ typeof(mmp_datalog_cmdresult_find_t),
					new Dictionary<String, Type>
					{
						{ "_source_flags", typeof(datalog_source_flag_t) },
					}
				},
				{ typeof(mmp_datalog_cmdresult_list_t),
					new Dictionary<String, Type>
					{
						{ "_source_flags", typeof(datalog_source_flag_t) },
						{ "_storeloc", typeof(datalog_store_t) },
					}
				},
				{ typeof(mmp_datalog_cmdresult_srcinfo_t),
					new Dictionary<String, Type>
					{
						{ "_source_flags", typeof(datalog_source_flag_t) },
						{ "_storeloc", typeof(datalog_store_t) },
					}
				},
				{ typeof(mmp_datalog_cmdresult_write_data_t),
					new Dictionary<String, Type>
					{
						{ "_status", typeof(mmp_datalog_cmdresult_write_data_status_t) },
					}
				},
				{ typeof(mmp_datalog_dump_t),
					new Dictionary<String, Type>
					{
						{ "_source", typeof(datalog_source_t) },
					}
				},
				{ typeof(mmp_datalog_remote_getdlogblk_t),
					new Dictionary<String, Type>
					{
						{ "_source", typeof(datalog_source_t) },
					}
				},
				{ typeof(mmp_datalog_srcinfo_t),
					new Dictionary<String, Type>
					{
						{ "_source_flags", typeof(datalog_source_flag_t) },
					}
				},
				{ typeof(mmp_gps_relay_t),
					new Dictionary<String, Type>
					{
						{ "_status", typeof(mmp_gps_relay_mode_t) },
					}
				},
				{ typeof(mmp_iface_stat_t),
					new Dictionary<String, Type>
					{
						{ "_stat", typeof(mmp_iface_stat_status_t) },
					}
				},
				{ typeof(mmp_pwrsense_t),
					new Dictionary<String, Type>
					{
						{ "_charge", typeof(mmp_deckbox_pwrsense_charge_t) },
						{ "_charging", typeof(mmp_bool_t) },
						{ "_device", typeof(mmp_deckbox_pwrsense_device_t) },
					}
				},
				{ typeof(mmp_remote_autobaud_result_t),
					new Dictionary<String, Type>
					{
						{ "_set_flags", typeof(autobaud_set_flags_t) },
					}
				},
				{ typeof(mmp_remote_autobaud_t),
					new Dictionary<String, Type>
					{
						{ "_max_modspec", typeof(modspec_t) },
						{ "_min_modspec", typeof(modspec_t) },
						{ "_set_flags", typeof(autobaud_set_flags_t) },
					}
				},
				{ typeof(mmp_remote_battcharge_t),
					new Dictionary<String, Type>
					{
						{ "_charge", typeof(mmp_remote_battcharge_charge_t) },
					}
				},
				{ typeof(mmp_remote_request_t),
					new Dictionary<String, Type>
					{
						{ "_flags", typeof(mmp_remote_request_flag_t) },
					}
				},
				{ typeof(mmp_remote_setacoubaud_t),
					new Dictionary<String, Type>
					{
						{ "_modspec", typeof(modspec_t) },
					}
				},
				{ typeof(mmp_remote_settxpower_t),
					new Dictionary<String, Type>
					{
						{ "_txpower", typeof(txpower_t) },
					}
				},
				{ typeof(mmp_remote_testmsgstats_t),
					new Dictionary<String, Type>
					{
						{ "_mod_spec", typeof(modspec_t) },
						{ "_remote_txpwr", typeof(mmp_remote_testmsgstats_txpwr_t) },
					}
				},
				{ typeof(mmp_rngrls_bearing_t),
					new Dictionary<String, Type>
					{
						{ "_tat", typeof(mmp_rngrls_bearing_tat_t) },
						{ "_type", typeof(mmp_rngrls_bearing_type_t) },
					}
				},
				{ typeof(mmp_rngrls_channel_probe_param_t),
					new Dictionary<String, Type>
					{
						{ "_log", typeof(mmp_rngrls_probe_log_t) },
					}
				},
				{ typeof(mmp_rngrls_cmdresult_navdata_t),
					new Dictionary<String, Type>
					{
						{ "_type", typeof(navdata_type_t) },
					}
				},
				{ typeof(mmp_rngrls_cmdresult_release_response_t),
					new Dictionary<String, Type>
					{
						{ "_status", typeof(ack_code_t) },
					}
				},
				{ typeof(mmp_rngrls_cmdresult_release_status_t),
					new Dictionary<String, Type>
					{
						{ "_battery", typeof(battery_status_t) },
						{ "_status", typeof(rls_status_code_t) },
						{ "_tilt", typeof(tilt_status_t) },
					}
				},
				{ typeof(mmp_rngrls_edgetech_param_t),
					new Dictionary<String, Type>
					{
						{ "_freq_spec", typeof(edgetech_freqspec_t) },
					}
				},
				{ typeof(mmp_rngrls_fsk_param_t),
					new Dictionary<String, Type>
					{
						{ "_code", typeof(mmp_rngrls_fsk_code_t) },
					}
				},
				{ typeof(mmp_rngrls_geopro_param_t),
					new Dictionary<String, Type>
					{
						{ "_cmdtype", typeof(geopro_cmd_t) },
					}
				},
				{ typeof(mmp_rngrls_navdata_t),
					new Dictionary<String, Type>
					{
						{ "_type", typeof(mmp_rngrls_bearing_type_t) },
					}
				},
				{ typeof(mmp_rngrls_transpond_t),
					new Dictionary<String, Type>
					{
						{ "_rcv_only", typeof(mmp_bool_t) },
						{ "_silent", typeof(mmp_bool_t) },
					}
				},
				{ typeof(mmp_sfl_err_t),
					new Dictionary<String, Type>
					{
						{ "_err", typeof(mmp_iface_err_t) },
					}
				},
				{ typeof(mmp_spectrum_stat_t),
					new Dictionary<String, Type>
					{
						{ "_stat", typeof(mmp_spectrum_stat_status_t) },
					}
				},
				{ typeof(mmp_spkr_phones_vol_t),
					new Dictionary<String, Type>
					{
						{ "_mute", typeof(mmp_bool_t) },
						{ "_volume", typeof(mmp_u8_bit_range_t) },
					}
				},
				{ typeof(mmp_sreg_fld_val_t),
					new Dictionary<String, Type>
					{
						{ "_val", typeof(mmp_sreg_band_t) },
					}
				},
				{ typeof(mmp_std_contxmit_enable_t),
					new Dictionary<String, Type>
					{
						{ "_enable", typeof(mmp_bool_t) },
					}
				},
				{ typeof(mmp_time_syncinfo_t),
					new Dictionary<String, Type>
					{
						{ "_ext_time", typeof(mmp_bool_t) },
						{ "_pps_state", typeof(pps_sync_state_t) },
						{ "_qualifying", typeof(mmp_bool_t) },
						{ "_time_sync", typeof(tss_state_t) },
					}
				},
				{ typeof(mmp_transpond_pingrcvd_t),
					new Dictionary<String, Type>
					{
						{ "_flags", typeof(mmp_transpond_pingrcvd_flag_t) },
					}
				},
				{ typeof(mmp_transpond_stat_t),
					new Dictionary<String, Type>
					{
						{ "_stat", typeof(mmp_transpond_stat_status_t) },
					}
				},
				{ typeof(mmp_udb_model_t),
					new Dictionary<String, Type>
					{
						{ "_model", typeof(mmp_deckbox_model_t) },
					}
				},
			};
		}
	}

    public class DbMetadata
    {
        public readonly String SectName;
        public readonly String ParamName;
        public readonly Type T;
        public readonly cfg_param_type_t CfgType;
        public readonly int SReg;
        public readonly int Places;
        public readonly object DefaultVal, MinVal, MaxVal;
        public readonly Dictionary<String, int> Enumerations;
        public readonly String Help;

        public DbMetadata(String a_SectName, String a_ParamName, Type a_T, cfg_param_type_t a_CfgType,
                          int a_SReg, int a_Places, object a_DefaultVal, object a_MinVal, object a_MaxVal,
                          Dictionary<String, int>a_Enumerations, String a_Help)
        {
            SectName = a_SectName;
            ParamName = a_ParamName;
            T = a_T;
            CfgType = a_CfgType;
            SReg = a_SReg;
            Places = a_Places;
            DefaultVal = a_DefaultVal;
            MinVal = a_MinVal;
            MaxVal = a_MaxVal;
            Enumerations = a_Enumerations;
            Help = a_Help;
        }
    }

    public static class ModemDbInfo
    {
        public static Dictionary<DbKeys, DbMetadata> dict;

        public static bool Get(DbKeys k, out DbMetadata d)
        {
            return dict.TryGetValue(k, out d);
        }

		static ModemDbInfo()
		{
			dict = new Dictionary<DbKeys, DbMetadata>()
			{
				{ DbKeys.AIN_1NMEAS,
					new DbMetadata("Ain", "Ain1NMeas", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 60,
						null,
						null)
				},
				{ DbKeys.AIN_1RPTDLY,
					new DbMetadata("Ain", "Ain1RptDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 1.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_1STRTDLY,
					new DbMetadata("Ain", "Ain1StrtDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_1TYPE,
					new DbMetadata("Ain", "Ain1Type", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 2,
						new Dictionary<String, int>() { { "4-20mA", 0 }, { "5V", 1 }, { "10V", 2 },  },
						"0 (4-20mA), 1 (5V), 2 (10V)")
				},
				{ DbKeys.AIN_2NMEAS,
					new DbMetadata("Ain", "Ain2NMeas", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 60,
						null,
						null)
				},
				{ DbKeys.AIN_2RPTDLY,
					new DbMetadata("Ain", "Ain2RptDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 1.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_2STRTDLY,
					new DbMetadata("Ain", "Ain2StrtDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_2TYPE,
					new DbMetadata("Ain", "Ain2Type", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 2,
						new Dictionary<String, int>() { { "4-20mA", 0 }, { "5V", 1 }, { "10V", 2 },  },
						"0 (4-20mA), 1 (5V), 2 (10V)")
				},
				{ DbKeys.AIN_3NMEAS,
					new DbMetadata("Ain", "Ain3NMeas", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 60,
						null,
						null)
				},
				{ DbKeys.AIN_3RPTDLY,
					new DbMetadata("Ain", "Ain3RptDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 1.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_3STRTDLY,
					new DbMetadata("Ain", "Ain3StrtDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_4NMEAS,
					new DbMetadata("Ain", "Ain4NMeas", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 60,
						null,
						null)
				},
				{ DbKeys.AIN_4RPTDLY,
					new DbMetadata("Ain", "Ain4RptDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 1.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_4STRTDLY,
					new DbMetadata("Ain", "Ain4StrtDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_5NMEAS,
					new DbMetadata("Ain", "Ain5NMeas", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 60,
						null,
						null)
				},
				{ DbKeys.AIN_5RPTDLY,
					new DbMetadata("Ain", "Ain5RptDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 1.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_5STRTDLY,
					new DbMetadata("Ain", "Ain5StrtDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_6NMEAS,
					new DbMetadata("Ain", "Ain6NMeas", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 60,
						null,
						null)
				},
				{ DbKeys.AIN_6RPTDLY,
					new DbMetadata("Ain", "Ain6RptDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 1.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_6STRTDLY,
					new DbMetadata("Ain", "Ain6StrtDly", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 10.0,
						null,
						null)
				},
				{ DbKeys.AIN_POLLRATE,
					new DbMetadata("Ain", "AinPollRate", typeof(string), cfg_param_type_t.CFG_CSTM, -1, 0, 0, 0, 2033056,
						null,
						"days(0- 31 )-hh(0-23):mm(0-59)")
				},
				{ DbKeys.COPROC_CPBOARD,
					new DbMetadata("Coproc", "CPBoard", typeof(int), cfg_param_type_t.CFG_ENUM, 9, 0, 0, 0, 3,
						new Dictionary<String, int>() { { "Off", 0 }, { "PwrSave", 1 }, { "AlwaysOn", 2 }, { "Program", 3 },  },
						"0 (Off), 1 (PwrSave), 2 (AlwaysOn), 3 (Program)")
				},
				{ DbKeys.COPROC_FDBCKTAPS,
					new DbMetadata("Coproc", "FdBckTaps", typeof(short), cfg_param_type_t.CFG_NUM16, 31, 0, 4, 1, 32,
						null,
						null)
				},
				{ DbKeys.COPROC_FDFWDTAPS,
					new DbMetadata("Coproc", "FdFwdTaps", typeof(short), cfg_param_type_t.CFG_NUM16, 30, 0, 20, 1, 32,
						null,
						null)
				},
				{ DbKeys.DAT_ARRIVAL,
					new DbMetadata("Dat", "Arrival", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 1, 0, 1,
						null,
						"1 (First), 0 (Peak)")
				},
				{ DbKeys.DAT_BEARINGRESP,
					new DbMetadata("Dat", "BearingResp", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 15, 0, 15,
						new Dictionary<String, int>() { { "Abs", 0 }, { "Rel", 1 }, { "CompRoll", 10 }, { "Depth", 11 }, { "RngOnly", 15 }, { "Comp", 2 }, { "Tilt", 3 }, { "AbBrg", 4 }, { "AbInc", 5 }, { "RlBrg", 6 }, { "RlElev", 7 }, { "CompHead", 8 }, { "CompPitch", 9 },  },
						"0 (Abs), 1 (Rel), 2 (Comp), 3 (Tilt), 4 (AbBrg), 5 (AbInc), 6 (RlBrg), 7 (RlElev), 8 (CompHead), 9 (CompPitch), 10 (CompRoll), 11 (Depth), 15 (RngOnly)")
				},
				{ DbKeys.DAT_VERBOSE,
					new DbMetadata("Dat", "DatVerbose", typeof(int), cfg_param_type_t.CFG_NUM32, -1, 0, 0, 0, 65535,
						null,
						null)
				},
				{ DbKeys.DAT_MAX_ELEV,
					new DbMetadata("Dat", "MaxElev", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 90.0, -90.0, 90.0,
						null,
						"degrees")
				},
				{ DbKeys.DAT_MIN_ELEV,
					new DbMetadata("Dat", "MinElev", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, -90.0, -90.0, 90.0,
						null,
						"degrees")
				},
				{ DbKeys.DAT_ORIENTATION,
					new DbMetadata("Dat", "Orientation", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 2,
						new Dictionary<String, int>() { { "up", 0 }, { "down", 1 }, { "fwd", 2 },  },
						"0 (up), 1 (down), 2 (fwd)")
				},
				{ DbKeys.DAT_PHASEA,
					new DbMetadata("Dat", "PhaseA", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 3, 0.000, -3.141, 3.141,
						null,
						"radians")
				},
				{ DbKeys.DAT_PHASEB,
					new DbMetadata("Dat", "PhaseB", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 3, 0.000, -3.141, 3.141,
						null,
						"radians")
				},
				{ DbKeys.DAT_PHASEC,
					new DbMetadata("Dat", "PhaseC", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 3, 0.000, -3.141, 3.141,
						null,
						"radians")
				},
				{ DbKeys.DAT_PHASED,
					new DbMetadata("Dat", "PhaseD", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 3, 0.000, -3.141, 3.141,
						null,
						"radians")
				},
				{ DbKeys.DAT_PHASEREF,
					new DbMetadata("Dat", "PhaseRef", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 1,
						new Dictionary<String, int>() { { "Active", 0 }, { "Passive", 1 },  },
						"0 (Active), 1 (Passive)")
				},
				{ DbKeys.DAT_PREGAIN,
					new DbMetadata("Dat", "PreGain", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, -89, 89,
						null,
						null)
				},
				{ DbKeys.DAT_RXONDAT,
					new DbMetadata("Dat", "RXonDAT", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.DAT_ROTATION,
					new DbMetadata("Dat", "Rotation", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 359.9,
						null,
						"0 to 359.9 degrees")
				},
				{ DbKeys.DAT_VTHRESH,
					new DbMetadata("Dat", "VThresh", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 3, 0.700, 0.000, 1.000,
						null,
						null)
				},
				{ DbKeys.DATALOG_ACDATA,
					new DbMetadata("Datalog", "AcData", typeof(int), cfg_param_type_t.CFG_ENUM, 22, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "UART", 0 }, { "Datalog", 1 }, { "UART+Datalog", 2 },  },
						"0 (UART), 1 (Datalog), 2 (UART+Datalog)")
				},
				{ DbKeys.DATALOG_ACSTATS,
					new DbMetadata("Datalog", "AcStats", typeof(int), cfg_param_type_t.CFG_BITMASK, 29, 0, 0, 0, 15,
						null,
						"0 (Off), 1 (Stats), 2 (TP-CSV), 4 (TimeStamp), 8 (APC)")
				},
				{ DbKeys.DATALOG_CHRCOUNT,
					new DbMetadata("Datalog", "ChrCount", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 1024, 0, 4095,
						null,
						null)
				},
				{ DbKeys.DATALOG_LOGMODE,
					new DbMetadata("Datalog", "LogMode", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "FwdDelay", 0 }, { "Sentinel", 1 }, { "ChrCount", 2 },  },
						"0 (FwdDelay), 1 (Sentinel), 2 (ChrCount)")
				},
				{ DbKeys.DATALOG_LOGSTORE,
					new DbMetadata("Datalog", "LogStore", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "Internal", 0 }, { "SDHC", 1 },  },
						"0 (Internal), 1 (SDHC)")
				},
				{ DbKeys.DATALOG_RINGBUF,
					new DbMetadata("Datalog", "RingBuf", typeof(bool), cfg_param_type_t.CFG_BOOL, 37, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.DATALOG_SENTINEL,
					new DbMetadata("Datalog", "Sentinel", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 255,
						null,
						null)
				},
				{ DbKeys.MODEM_APCALPHSM,
					new DbMetadata("Modem", "APCAlphaSm", typeof(short), cfg_param_type_t.CFG_NUM16, -2, 0, 95, 0, 100,
						null,
						null)
				},
				{ DbKeys.MODEM_APCMAXTXP,
					new DbMetadata("Modem", "APCMaxTxp", typeof(int), cfg_param_type_t.CFG_NUM32, -1, 0, 8, -5, 8,
						null,
						null)
				},
				{ DbKeys.MODEM_APCMINTXP,
					new DbMetadata("Modem", "APCMinTxp", typeof(int), cfg_param_type_t.CFG_NUM32, -1, 0, -5, -5, 8,
						null,
						null)
				},
				{ DbKeys.MODEM_APCNOISSEL,
					new DbMetadata("Modem", "APCNoiseSel", typeof(int), cfg_param_type_t.CFG_ENUM, -2, 0, 1, 0, 1,
						new Dictionary<String, int>() { { "Sample", 0 }, { "Smooth", 1 },  },
						"0 (Sample), 1 (Smooth),")
				},
				{ DbKeys.MODEM_ACRSPTMOUT,
					new DbMetadata("Modem", "AcRspTmOut", typeof(double), cfg_param_type_t.CFG_FIXED, 7, 3, 7.500, 2.000, 99.500,
						null,
						"2.0 - 99.5 sec (0.5 sec increments)")
				},
				{ DbKeys.MODEM_ADDRGROUP,
					new DbMetadata("Modem", "AddrGroup", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 4,
						null,
						null)
				},
				{ DbKeys.MODEM_AUTODETECTHDR,
					new DbMetadata("Modem", "AutoDetectHdr", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.MODEM_CHIRP_THRESHOLD,
					new DbMetadata("Modem", "ChirpThresh", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 27, 15, 27,
						null,
						null)
				},
				{ DbKeys.MODEM_DATARETRY,
					new DbMetadata("Modem", "DataRetry", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 6,
						null,
						null)
				},
				{ DbKeys.MODEM_DEVENABLE,
					new DbMetadata("Modem", "DevEnable", typeof(int), cfg_param_type_t.CFG_ENUM, 28, 0, 0, 0, 4,
						new Dictionary<String, int>() { { "Auto", 0 }, { "MBARI", 1 }, { "Manual-LP", 2 }, { "Manual", 3 }, { "AcouTrig", 4 },  },
						"0 (Auto), 1 (MBARI), 2 (Manual-LP), 3 (Manual), 4 (AcouTrig)")
				},
				{ DbKeys.MODEM_DOMAINKEY,
					new DbMetadata("Modem", "DomainKey", typeof(string), cfg_param_type_t.CFG_STR, -1, 0, 0, 0, 0,
						null,
						null)
				},
				{ DbKeys.MODEM_FWDDELAY,
					new DbMetadata("Modem", "FwdDelay", typeof(double), cfg_param_type_t.CFG_FIXED, 8, 3, 3.000, 0.050, 5.000,
						null,
						"0.05 to 5 sec (50ms increments)")
				},
				{ DbKeys.MODEM_HEADERRATE,
					new DbMetadata("Modem", "HeaderRate", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 2, 1, 2,
						new Dictionary<String, int>() { { "80", 1 }, { "140", 2 },  },
						"1 (80), 2 (140)")
				},
				{ DbKeys.MODEM_INPUTMODE,
					new DbMetadata("Modem", "InputMode", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 1, 2,
						new Dictionary<String, int>() { { "Single", 1 }, { "Dual", 2 },  },
						"1 (Single), 2 (Dual)")
				},
				{ DbKeys.MODEM_LOCALADDR,
					new DbMetadata("Modem", "LocalAddr", typeof(short), cfg_param_type_t.CFG_NUM16, 18, 0, 0, 0, 249,
						null,
						null)
				},
				{ DbKeys.MODEM_OPMODE,
					new DbMetadata("Modem", "OpMode", typeof(int), cfg_param_type_t.CFG_ENUM, 15, 0, 1, 0, 8,
						new Dictionary<String, int>() { { "Command", 0 }, { "Online", 1 }, { "Datalog", 2 }, { "ContXpnd", 6 }, { "Sink", 8 },  },
						"0 (Command), 1 (Online), 2 (Datalog), 6 (ContXpnd), 8 (Sink)")
				},
				{ DbKeys.MODEM_PRNTHEX,
					new DbMetadata("Modem", "PrintHex", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.MODEM_REMOTEADDR,
					new DbMetadata("Modem", "RemoteAddr", typeof(short), cfg_param_type_t.CFG_NUM16, 14, 0, 0, 0, 249,
						null,
						"0 - 249 , 255")
				},
				{ DbKeys.MODEM_RXPKTTYPE,
					new DbMetadata("Modem", "RxPktType", typeof(int), cfg_param_type_t.CFG_ENUM, 5, 0, 0, 0, 12,
						new Dictionary<String, int>() { { "MFSK", 0 }, { "FH_MA", 1 }, { "Xpnd", 2 }, { "Chirp", 3 },  },
						"0 (MFSK), 1 (FH_MA), 2 (Xpnd), 3 (Chirp)")
				},
				{ DbKeys.MODEM_SHOWBADDATA,
					new DbMetadata("Modem", "ShowBadData", typeof(bool), cfg_param_type_t.CFG_BOOL, 16, 0, true, false, true,
						null,
						null)
				},
				{ DbKeys.MODEM_SMARTRETRY,
					new DbMetadata("Modem", "SmartRetry", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.MODEM_STARTTONES,
					new DbMetadata("Modem", "StartTones", typeof(short), cfg_param_type_t.CFG_NUM16, 54, 0, 6, 0, 8,
						null,
						"Power Level, 0 = silent")
				},
				{ DbKeys.MODEM_TXATTEN,
					new DbMetadata("Modem", "TxAtten", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 1,
						new Dictionary<String, int>() { { "0dB", 0 }, { "-24dB", 1 },  },
						"0 (0dB), 1 (-24dB)")
				},
				{ DbKeys.MODEM_TXPOWER,
					new DbMetadata("Modem", "TxPower", typeof(int), cfg_param_type_t.CFG_ENUM, 6, 0, 8, 1, 8,
						new Dictionary<String, int>() { { "-21dB", 1 }, { "-18dB", 2 }, { "-15dB", 3 }, { "-12dB", 4 }, { "-9dB", 5 }, { "-6dB", 6 }, { "-3dB", 7 }, { "Max", 8 },  },
						"1 (-21dB), 2 (-18dB), 3 (-15dB), 4 (-12dB), 5 (-9dB), 6 (-6dB), 7 (-3dB), 8 (Max)")
				},
				{ DbKeys.MODEM_TXRATE,
					new DbMetadata("Modem", "TxRate", typeof(int), cfg_param_type_t.CFG_ENUM, 4, 0, 5, 1, 99,
						new Dictionary<String, int>() { { "80", 1 }, { "5120", 10 }, { "7680", 11 }, { "10240", 12 }, { "15360", 13 }, { "140", 2 }, { "140x2", 22 }, { "300x2", 23 }, { "600x2", 24 }, { "800x2", 25 }, { "1066x2", 26 }, { "1200x2", 27 }, { "2400x2", 28 }, { "300", 3 }, { "600", 4 }, { "800", 5 }, { "1066", 6 }, { "1200", 7 }, { "2400", 8 }, { "2560", 9 },  },
						"1 (80), 2 (140), 3 (300), 4 (600), 5 (800), 6 (1066), 7 (1200), 8 (2400), 9 (2560), 10 (5120), 11 (7680), 12 (10240), 13 (15360) , 22 (140x2), 23 (300x2), 24 (600x2), 25 (800x2) , 26 (1066x2), 27 (1200x2), 28 (2400x2)")
				},
				{ DbKeys.MODEM_WAKETONES,
					new DbMetadata("Modem", "WakeTones", typeof(bool), cfg_param_type_t.CFG_BOOL, 17, 0, true, false, true,
						null,
						null)
				},
				{ DbKeys.NAV_ALTITUDE,
					new DbMetadata("Nav", "Altitude", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 2, -1.00, -1.00, 12000.00,
						null,
						"meters above sea floor")
				},
				{ DbKeys.NAV_COMPASS,
					new DbMetadata("Nav", "Compass", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 359.9,
						null,
						"0 to 359.9 degrees")
				},
				{ DbKeys.NAV_DEPTH,
					new DbMetadata("Nav", "Depth", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, -1.0, -1.0, 12000.0,
						null,
						"meters below sea level")
				},
				{ DbKeys.NAV_GPSALT,
					new DbMetadata("Nav", "GpsAlt", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, -20000.0, 20000.0,
						null,
						"meters above mean sea level")
				},
				{ DbKeys.NAV_GPSSYNCMSG,
					new DbMetadata("Nav", "GpsSyncMsg", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 3,
						new Dictionary<String, int>() { { "None", 0 }, { "ZDA", 1 }, { "GGA", 2 }, { "RMC", 3 },  },
						"0 (None), 1 (ZDA), 2 (GGA), 3 (RMC)")
				},
				{ DbKeys.NAV_HEADOFFSET,
					new DbMetadata("Nav", "HeadOffset", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 359.9,
						null,
						"0 to 359.9 degrees")
				},
				{ DbKeys.NAV_LATITUDE,
					new DbMetadata("Nav", "Latitude", typeof(double), cfg_param_type_t.CFG_NUM32, -1, 6, 41.638246, -90.000000, 90.000000,
						null,
						"degrees")
				},
				{ DbKeys.NAV_LONGITUDE,
					new DbMetadata("Nav", "Longitude", typeof(double), cfg_param_type_t.CFG_NUM32, -1, 6, -70.609376, -180.000000, 180.000000,
						null,
						"degrees")
				},
				{ DbKeys.NAV_PITCH,
					new DbMetadata("Nav", "Pitch", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, -90.0, 90.0,
						null,
						"-90.0 to 90.0 degrees")
				},
				{ DbKeys.NAV_PITCHOFFSET,
					new DbMetadata("Nav", "PitchOffset", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, -10.0, 10.0,
						null,
						null)
				},
				{ DbKeys.NAV_REPLY_DATA,
					new DbMetadata("Nav", "ReplyData", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 4,
						new Dictionary<String, int>() { { "Off", 0 }, { "LatLong", 1 }, { "Depth", 2 }, { "SeaFloor", 3 }, { "GpsAlt", 4 },  },
						"0 (Off), 1 (LatLong), 2 (Depth), 3 (SeaFloor), 4 (GpsAlt)")
				},
				{ DbKeys.NAV_ROLL,
					new DbMetadata("Nav", "Roll", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, -180.0, 180.0,
						null,
						"-180.0 to 180.0 degrees")
				},
				{ DbKeys.NAV_ROLLOFFSET,
					new DbMetadata("Nav", "RollOffset", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, -10.0, 10.0,
						null,
						null)
				},
				{ DbKeys.NAV_CSOUND,
					new DbMetadata("Nav", "SpeedOfSound", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 1500.0, 300.0, 7000.0,
						null,
						"speed of sound in meters per second")
				},
				{ DbKeys.PRESSURE_ATMOFFSET,
					new DbMetadata("Pressure", "ATMOffset", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 14.7, 14.0, 15.5,
						null,
						null)
				},
				{ DbKeys.PRESSURE_METERSPERPSI,
					new DbMetadata("Pressure", "MetersPerPSI", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 3, 0.680, 0.000, 1.000,
						null,
						null)
				},
				{ DbKeys.PRESSURE_PSI,
					new DbMetadata("Pressure", "PSI", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, -1.0, 18000.0,
						null,
						null)
				},
				{ DbKeys.PRESSURE_AINCHNL,
					new DbMetadata("Pressure", "PressureChnl", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 6, 0, 6,
						null,
						"1.. 6 , 0 to disable")
				},
				{ DbKeys.RECORDER_NAMEFORMAT,
					new DbMetadata("Recorder", "NameFormat", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 1,
						new Dictionary<String, int>() { { "MMDDHHMM", 0 }, { "DDHHMMSS", 1 }, { "HH-MM-SS", 3 },  },
						"0 (MMDDHHMM), 1 (DDHHMMSS), 3 (HH-MM-SS)")
				},
				{ DbKeys.RECORDER_RECMODE,
					new DbMetadata("Recorder", "RecMode", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 1,
						new Dictionary<String, int>() { { "manual", 0 }, { "auto", 1 }, { "auto-LP", 2 },  },
						"0 (manual), 1 (auto), 2 (auto-LP)")
				},
				{ DbKeys.RELEASE_ACOUTRIGTERM,
					new DbMetadata("Release", "AcouTrigTerm", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 8,
						new Dictionary<String, int>() { { "None", 0 }, { "Bin1HiTerm", 1 }, { "Bin1HiAckOnly", 2 }, { "Bin1LoTerm", 3 }, { "Bin1LoAckOnly", 4 }, { "TiltTerm", 5 }, { "TiltAckOnly", 6 }, { "AccelTerm", 7 }, { "AccelAckOnly", 8 },  },
						"0 (None), 1 (Bin1HiTerm), 2 (Bin1HiAckOnly), 3 (Bin1LoTerm), 4 (Bin1LoAckOnly) , 5 (TiltTerm), 6 (TiltAckOnly), 7 (AccelTerm), 8 (AccelAckOnly)")
				},
				{ DbKeys.RELEASE_FSKRLSDUR,
					new DbMetadata("Release", "FSKRlsDur", typeof(short), cfg_param_type_t.CFG_NUM16, 51, 0, 8, 4, 12,
						null,
						null)
				},
				{ DbKeys.RELEASE_LSTCOMMSCNT,
					new DbMetadata("Release", "LstCommsCnt", typeof(short), cfg_param_type_t.CFG_NUM16, 39, 0, 0, 0, 999,
						null,
						null)
				},
				{ DbKeys.RELEASE_MOTORTYPE,
					new DbMetadata("Release", "MotorType", typeof(int), cfg_param_type_t.CFG_ENUM, -2, 0, 0, 0, 0,
						new Dictionary<String, int>() { { "Null", 0 }, { "Reversing", 1 }, { "Continuous", 2 },  },
						"0 (Null), 1 (Reversing), 2 (Continuous)")
				},
				{ DbKeys.RELEASE_RLSCODE,
					new DbMetadata("Release", "RlsCode", typeof(int), cfg_param_type_t.CFG_NUM32, 41, 0, 0, 0, 65535,
						null,
						null)
				},
				{ DbKeys.RELEASE_RLSMAXENATIME,
					new DbMetadata("Release", "RlsMaxEnaTime", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 40, 10, 120,
						null,
						null)
				},
				{ DbKeys.RELEASE_RLSMINENATIME,
					new DbMetadata("Release", "RlsMinEnaTime", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 10, 0, 10,
						null,
						null)
				},
				{ DbKeys.RELEASE_TIMEDRELEASE,
					new DbMetadata("Release", "TimedRelease", typeof(short), cfg_param_type_t.CFG_NUM16, 50, 0, 0, 0, 999,
						null,
						"Release in 0-999 hours")
				},
				{ DbKeys.SERIAL_LPFLOWCTL,
					new DbMetadata("Serial", "LPFlowCtl", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "Lowpower", 0 }, { "Always_on", 2 },  },
						"0 (Lowpower), 2 (Always_on)")
				},
				{ DbKeys.SERIAL_P1BAUD,
					new DbMetadata("Serial", "P1Baud", typeof(int), cfg_param_type_t.CFG_ENUM, 3, 0, 9600, 0, 0,
						new Dictionary<String, int>() { { "115200", 115200 }, { "1200", 1200 }, { "19200", 19200 }, { "2400", 2400 }, { "38400", 38400 }, { "4800", 4800 }, { "57600", 57600 }, { "9600", 9600 },  },
						"1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200")
				},
				{ DbKeys.SERIAL_P1ECHOCHAR,
					new DbMetadata("Serial", "P1EchoChar", typeof(bool), cfg_param_type_t.CFG_BOOL, 3, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SERIAL_P1FLOWCTL,
					new DbMetadata("Serial", "P1FlowCtl", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "None", 0 }, { "SW", 1 }, { "HW", 2 },  },
						"0 (None), 1 (SW), 2 (HW)")
				},
				{ DbKeys.SERIAL_P1MODE,
					new DbMetadata("Serial", "P1Mode", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 0,
						new Dictionary<String, int>() { { "Cooked", 0 }, { "Raw", 1 },  },
						"0 (Cooked), 1 (Raw)")
				},
				{ DbKeys.SERIAL_P1NOSLEEP,
					new DbMetadata("Serial", "P1NoSleep", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SERIAL_P1PROMPT,
					new DbMetadata("Serial", "P1Prompt", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 7, 0, 8,
						null,
						"0 (None), 1 (Arrow), 2 (Priv), 4 (CmdNum), 7 (All), 8 (NoErr)")
				},
				{ DbKeys.SERIAL_P1PROTOCOL,
					new DbMetadata("Serial", "P1Protocol", typeof(int), cfg_param_type_t.CFG_ENUM, 3, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "RS-232", 0 }, { "RS-422", 1 }, { "RS-485", 2 },  },
						"0 (RS-232), 1 (RS-422), 2 (RS-485)")
				},
				{ DbKeys.SERIAL_P1STRIPB7,
					new DbMetadata("Serial", "P1StripB7", typeof(bool), cfg_param_type_t.CFG_BOOL, 3, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SERIAL_P2BAUD,
					new DbMetadata("Serial", "P2Baud", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 9600, 0, 0,
						new Dictionary<String, int>() { { "115200", 115200 }, { "1200", 1200 }, { "19200", 19200 }, { "2400", 2400 }, { "38400", 38400 }, { "4800", 4800 }, { "57600", 57600 }, { "9600", 9600 },  },
						"1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200")
				},
				{ DbKeys.SERIAL_P2ECHOCHAR,
					new DbMetadata("Serial", "P2EchoChar", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SERIAL_P2FLOWCTL,
					new DbMetadata("Serial", "P2FlowCtl", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "None", 0 }, { "SW", 1 }, { "HW", 2 },  },
						"0 (None), 1 (SW), 2 (HW)")
				},
				{ DbKeys.SERIAL_P2MODE,
					new DbMetadata("Serial", "P2Mode", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 0,
						new Dictionary<String, int>() { { "Cooked", 0 }, { "Raw", 1 },  },
						"0 (Cooked), 1 (Raw)")
				},
				{ DbKeys.SERIAL_P2NOSLEEP,
					new DbMetadata("Serial", "P2NoSleep", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SERIAL_P2PROMPT,
					new DbMetadata("Serial", "P2Prompt", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 7, 0, 8,
						null,
						"0 (None), 1 (Arrow), 2 (Priv), 4 (CmdNum), 7 (All), 8 (NoErr)")
				},
				{ DbKeys.SERIAL_P2PROTOCOL,
					new DbMetadata("Serial", "P2Protocol", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "RS-232", 0 }, { "CMOS", 1 }, { "Emul232", 2 },  },
						"0 (RS-232), 1 (CMOS), 2 (Emul232)")
				},
				{ DbKeys.SERIAL_P2STRIPB7,
					new DbMetadata("Serial", "P2StripB7", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SYSTEM_ARWAKEHIB,
					new DbMetadata("System", "ARWakeHib", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 2, -1, 5,
						new Dictionary<String, int>() { { "Off", -1 }, { "48sec", 1 }, { "60sec", 2 }, { "72sec", 3 }, { "84sec", 4 }, { "96sec", 5 },  },
						"-1 (Off), 1 (48sec), 2 (60sec), 3 (72sec), 4 (84sec), 5 (96sec)")
				},
				{ DbKeys.SYSTEM_AUXINP,
					new DbMetadata("System", "AuxInp", typeof(bool), cfg_param_type_t.CFG_BOOL, 20, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SYSTEM_AUXOUT,
					new DbMetadata("System", "AuxOut", typeof(int), cfg_param_type_t.CFG_ENUM, 20, 0, 0, 0, 1,
						new Dictionary<String, int>() { { "Default", 0 }, { "Force", 1 },  },
						"0 (Default), 1 (Force)")
				},
				{ DbKeys.SYSTEM_AWAKEPOWER,
					new DbMetadata("System", "AwakePower", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "Off", 0 }, { "3.3V", 1 }, { "12V+3.3V", 2 },  },
						"0 (Off), 1 (3.3V), 2 (12V+3.3V)")
				},
				{ DbKeys.SYSTEM_AWAKETIMER,
					new DbMetadata("System", "AwakeTimer", typeof(string), cfg_param_type_t.CFG_CSTM, -2, 0, 30, 0, 720,
						null,
						"hh(0-6):mm(00 or 30),disabled=00:00")
				},
				{ DbKeys.SYSTEM_BATTERYCAPACITY,
					new DbMetadata("System", "BatteryCapacity", typeof(short), cfg_param_type_t.CFG_NUM16, -2, 0, 300, 0, 1000,
						null,
						null)
				},
				{ DbKeys.SYSTEM_BATTERYMFGDATE,
					new DbMetadata("System", "BatteryMfgDate", typeof(string), cfg_param_type_t.CFG_CSTM, -2, 0, 120, 0, 1199,
						null,
						"YYYY/MM (01=Jan..12=Dec)")
				},
				{ DbKeys.SYSTEM_BATTERYTYPE,
					new DbMetadata("System", "BatteryType", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 1,
						new Dictionary<String, int>() { { "Std", 0 }, { "LiPrimary", 3 }, { "ExtDC", 4 },  },
						"0 (Std) , 3 (LiPrimary), 4 (ExtDC)")
				},
				{ DbKeys.SYSTEM_CMFASTWAKE,
					new DbMetadata("System", "CMFastWake", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, true, false, true,
						null,
						null)
				},
				{ DbKeys.SYSTEM_CMWAKEHIB,
					new DbMetadata("System", "CMWakeHib", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 9, -1, 9,
						new Dictionary<String, int>() { { "Off", -1 }, { "2sec", 0 }, { "3sec", 1 }, { "96sec", 11 }, { "4sec", 2 }, { "6sec", 3 }, { "8sec", 4 }, { "12sec", 5 }, { "16sec", 6 }, { "24sec", 7 }, { "32sec", 8 }, { "48sec", 9 },  },
						"-1 (Off), 0 (2sec), 1 (3sec), 2 (4sec), 3 (6sec), 4 (8sec), 5 (12sec), 6 (16sec), 7 (24sec), 8 (32sec), 9 (48sec), 11 (96sec)")
				},
				{ DbKeys.SYSTEM_CARRFREQ,
					new DbMetadata("System", "CarrFreq", typeof(short), cfg_param_type_t.CFG_NUM16, 24, 0, 56, 0, 450,
						null,
						"56 = LF, 100 = MF, 141 = C, 156 = HF")
				},
				{ DbKeys.SYSTEM_COMPMDMRST,
					new DbMetadata("System", "CompMdmRst", typeof(bool), cfg_param_type_t.CFG_BOOL, -2, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SYSTEM_FHTHRESH,
					new DbMetadata("System", "FHThresh", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 100, 0, 200,
						null,
						null)
				},
				{ DbKeys.SYSTEM_HALFBW,
					new DbMetadata("System", "HalfBW", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SYSTEM_IDLETIMER,
					new DbMetadata("System", "IdleTimer", typeof(string), cfg_param_type_t.CFG_CSTM, 10, 0, 192, 1, 1511163,
						null,
						"hh(0-23):mm(0-59):ss(0-59) All zeros - timer disabled")
				},
				{ DbKeys.SYSTEM_MINOPVOLT,
					new DbMetadata("System", "MinOpVoltage", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 9.6, 0.0, 24.0,
						null,
						null)
				},
				{ DbKeys.SYSTEM_PWRONTIMER,
					new DbMetadata("System", "PowerOnTimer", typeof(short), cfg_param_type_t.CFG_NUM16, -2, 0, 6, 1, 12,
						null,
						null)
				},
				{ DbKeys.SYSTEM_PULLUP0,
					new DbMetadata("System", "Pullup0", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SYSTEM_PULLUP1,
					new DbMetadata("System", "Pullup1", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.SYSTEM_RLSTYPE,
					new DbMetadata("System", "RlsType", typeof(int), cfg_param_type_t.CFG_ENUM, 44, 0, 0, 0, 10,
						new Dictionary<String, int>() { { "None", 0 }, { "SmRel", 1 }, { "AcouTrig", 10 }, { "SmMdm", 2 }, { "OEMBurnWire", 3 }, { "SmOEM", 8 },  },
						"0 (None), 1 (SmRel), 2 (SmMdm), 3 (OEMBurnWire), 8 (SmOEM), 10 (AcouTrig)")
				},
				{ DbKeys.SYSTEM_RXSENS,
					new DbMetadata("System", "RxSensitivity", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 0, -175, -200, 0,
						null,
						"-200..0 dB (uPa)")
				},
				{ DbKeys.SYSTEM_SYNCOUT,
					new DbMetadata("System", "SyncOut", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 3,
						new Dictionary<String, int>() { { "Off", 0 }, { "Port1", 1 }, { "Port2", 2 }, { "PulseOnly", 3 },  },
						"0 (Off), 1 (Port1), 2 (Port2), 3 (PulseOnly)")
				},
				{ DbKeys.SYSTEM_SYNCPPS,
					new DbMetadata("System", "SyncPPS", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 2, 1, 4,
						new Dictionary<String, int>() { { "ExtRise", 1 }, { "RTC", 2 }, { "ExtFall", 4 },  },
						"2 (RTC), 1 (ExtRise), 4 (ExtFall)")
				},
				{ DbKeys.SYSTEM_TILTAXIS,
					new DbMetadata("System", "TiltAxis", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 1,
						new Dictionary<String, int>() { { "X+", 0 }, { "X-", 1 }, { "Y+", 2 }, { "Y-", 3 }, { "Z+", 4 }, { "Z-", 5 },  },
						"0 (X+), 1 (X-), 2 (Y+), 3 (Y-), 4 (Z+), 5 (Z-)")
				},
				{ DbKeys.SYSTEM_TXINTERP,
					new DbMetadata("System", "TxInterp", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 6, 1, 6,
						new Dictionary<String, int>() { { "327kHz", 2 }, { "983kHz", 6 },  },
						"2 (327kHz), 6 (983kHz)")
				},
				{ DbKeys.SYSTEM_TXSENS,
					new DbMetadata("System", "TxSensitivity", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 0, 135, 100, 200,
						null,
						null)
				},
				{ DbKeys.SYSTEM_VERBOSE,
					new DbMetadata("System", "Verbose", typeof(short), cfg_param_type_t.CFG_NUM16, 13, 0, 1, 0, 16,
						null,
						"0 (none), 1-3 (customer), > 3 (diag)")
				},
				{ DbKeys.SYSTEM_WAKETHRESH,
					new DbMetadata("System", "WakeThresh", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 524, 0, 1000,
						null,
						null)
				},
				{ DbKeys.TEST_DBGLVL,
					new DbMetadata("Test", "DbgLvl", typeof(int), cfg_param_type_t.CFG_NUM32, -1, 0, 0, 0, 2147483647,
						null,
						null)
				},
				{ DbKeys.TEST_PKTECHO,
					new DbMetadata("Test", "PktEcho", typeof(bool), cfg_param_type_t.CFG_BOOL, 12, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.TEST_PKTSIZE,
					new DbMetadata("Test", "PktSize", typeof(int), cfg_param_type_t.CFG_ENUM, 12, 0, 0, 0, 7,
						new Dictionary<String, int>() { { "8B", 0 }, { "32B", 1 }, { "128B", 2 }, { "256B", 3 }, { "512B", 4 }, { "1024B", 5 }, { "2048B", 6 }, { "4096B", 7 },  },
						"0 (8B), 1 (32B), 2 (128B), 3 (256B), 4 (512B), 5 (1024B), 6 (2048B), 7 (4096B)")
				},
				{ DbKeys.TEST_RCVALL,
					new DbMetadata("Test", "RcvAll", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.TEST_RSPDELAY,
					new DbMetadata("Test", "RspDelay", typeof(bool), cfg_param_type_t.CFG_BOOL, 42, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.TEST_SIMACDLY,
					new DbMetadata("Test", "SimAcDly", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 30000,
						null,
						"0..30000 ms")
				},
				{ DbKeys.TEST_TXSATURATE,
					new DbMetadata("Test", "TxSat", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.TRANSPORT_DST1,
					new DbMetadata("Transport", "Dst1", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 3,
						new Dictionary<String, int>() { { "P1", 1 }, { "P2", 2 },  },
						"1 (P1), 2 (P2)")
				},
				{ DbKeys.TRANSPORT_DST2,
					new DbMetadata("Transport", "Dst2", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 2, 0, 3,
						new Dictionary<String, int>() { { "P1", 1 }, { "P2", 2 },  },
						"1 (P1), 2 (P2)")
				},
				{ DbKeys.TRANSPORT_DST3,
					new DbMetadata("Transport", "Dst3", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 3,
						new Dictionary<String, int>() { { "P1", 1 }, { "P2", 2 },  },
						"1 (P1), 2 (P2)")
				},
				{ DbKeys.TRANSPORT_DST4,
					new DbMetadata("Transport", "Dst4", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 2, 0, 3,
						new Dictionary<String, int>() { { "P1", 1 }, { "P2", 2 },  },
						"1 (P1), 2 (P2)")
				},
				{ DbKeys.TRANSPORT_L4ENB,
					new DbMetadata("Transport", "L4Enable", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, true, false, true,
						null,
						null)
				},
				{ DbKeys.TRANSPORT_SRCP1,
					new DbMetadata("Transport", "SrcP1", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 1, 1, 4,
						null,
						null)
				},
				{ DbKeys.TRANSPORT_SRCP2,
					new DbMetadata("Transport", "SrcP2", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 2, 1, 4,
						null,
						null)
				},
				{ DbKeys.TRANSPORT_TPMODE,
					new DbMetadata("Transport", "TPortMode", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 3,
						new Dictionary<String, int>() { { "InpMode", 0 }, { "AlwaysOn", 1 },  },
						"0 (InpMode), 1 (AlwaysOn)")
				},
				{ DbKeys.USBL_AUTO_QUERY,
					new DbMetadata("Usbl", "USBLauto", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "Off", 0 }, { "Acoustic", 1 }, { "Electric", 2 },  },
						"0 (Off), 1 (Acoustic), 2 (Electric)")
				},
				{ DbKeys.USBL_AUTO_DELAY,
					new DbMetadata("Usbl", "USBLdelay", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 3000,
						null,
						"0..3000 seconds")
				},
				{ DbKeys.USBL_FORMAT,
					new DbMetadata("Usbl", "USBLformat", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 5,
						new Dictionary<String, int>() { { "Benthos", 0 }, { "ORE_STD", 1 }, { "ORE_WPR", 2 }, { "NMEA", 4 }, { "compact", 5 },  },
						"0 (Benthos), 1 (ORE_STD), 2 (ORE_WPR), 4 (NMEA), 5 (compact)")
				},
				{ DbKeys.USBL_DEPTH_QUERY,
					new DbMetadata("Usbl", "USBLgetDepth", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
				{ DbKeys.USBL_XDCER_DEPTH,
					new DbMetadata("Usbl", "USBLheadDepth", typeof(double), cfg_param_type_t.CFG_FIXED, -1, 1, 0.0, 0.0, 100.0,
						null,
						"0..100.0 meters")
				},
				{ DbKeys.USBL_REPEAT_QUERY,
					new DbMetadata("Usbl", "USBLrepeat", typeof(short), cfg_param_type_t.CFG_NUM16, -1, 0, 0, 0, 255,
						null,
						null)
				},
				{ DbKeys.VERSION_DBVERSION,
					new DbMetadata("Version", "DBVersion", typeof(string), cfg_param_type_t.CFG_STR, -1, 0, 0, 0, 0,
						null,
						null)
				},
				{ DbKeys.VERSION_SWAPPNAME,
					new DbMetadata("Version", "SWAppName", typeof(string), cfg_param_type_t.CFG_STR, -1, 0, 0, 0, 0,
						null,
						null)
				},
				{ DbKeys.VERSION_SWVERSION,
					new DbMetadata("Version", "SWVersion", typeof(string), cfg_param_type_t.CFG_STR, 0, 0, 0, 0, 0,
						null,
						null)
				},
				{ DbKeys.XPND_AGCREF,
					new DbMetadata("Xpnd", "AGCRef", typeof(short), cfg_param_type_t.CFG_NUM16, 58, 0, 60, 10, 80,
						null,
						null)
				},
				{ DbKeys.XPND_CHIRP_RESP,
					new DbMetadata("Xpnd", "ChirpResp", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 1, 0, 1,
						new Dictionary<String, int>() { { "Up", 0 }, { "Down", 1 },  },
						"0 (Up), 1 (Down)")
				},
				{ DbKeys.XPND_HPR400CHAN,
					new DbMetadata("Xpnd", "HPR400chan", typeof(int), cfg_param_type_t.CFG_ENUM, -2, 0, 0, 0, 7,
						new Dictionary<String, int>() { { "B46", 0 }, { "B47", 1 }, { "B56", 2 }, { "B57", 3 }, { "B67", 4 }, { "B76", 5 }, { "B86", 6 }, { "B87", 7 },  },
						"0 (B46), 1 (B47), 2 (B56), 3 (B57), 4 (B67), 5 (B76), 6 (B86), 7 (B87)")
				},
				{ DbKeys.XPND_LBLMODE,
					new DbMetadata("Xpnd", "LBLmode", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 3,
						new Dictionary<String, int>() { { "Off", 0 }, { "Tone", 1 }, { "Listen", 2 }, { "Chirp", 3 },  },
						"0 (Off), 1 (Tone), 2 (Listen), 3 (Chirp)")
				},
				{ DbKeys.XPND_RESPFREQ,
					new DbMetadata("Xpnd", "RespFreq", typeof(int), cfg_param_type_t.CFG_NUM32, -1, 0, 11000, 0, 35000,
						null,
						"250 Hz steps within frequency band")
				},
				{ DbKeys.XPND_RESPONDER,
					new DbMetadata("Xpnd", "Responder", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 0, 0, 2,
						new Dictionary<String, int>() { { "Off", 0 }, { "Rise", 1 }, { "Fall", 2 }, { "Send", 3 },  },
						"0 (Off), 1 (Rise), 2 (Fall), 3 (Send)")
				},
				{ DbKeys.XPND_RXFREQ,
					new DbMetadata("Xpnd", "RxFreq", typeof(int), cfg_param_type_t.CFG_NUM32, 53, 0, 10000, 0, 81920,
						null,
						"250 Hz steps within frequency band")
				},
				{ DbKeys.XPND_RXLOCKOUT,
					new DbMetadata("Xpnd", "RxLockout", typeof(short), cfg_param_type_t.CFG_NUM16, 55, 0, 30, 0, 1500,
						null,
						"10..1500 (ms)")
				},
				{ DbKeys.XPND_RXTHRESH,
					new DbMetadata("Xpnd", "RxThresh", typeof(short), cfg_param_type_t.CFG_NUM16, 21, 0, 100, 10, 999,
						null,
						null)
				},
				{ DbKeys.XPND_RXTONEDUR,
					new DbMetadata("Xpnd", "RxToneDur", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 10, 0, 15,
						new Dictionary<String, int>() { { "12.5ms", 0 }, { "6.25ms", 1 }, { "10ms", 10 }, { "11ms", 11 }, { "12ms", 12 }, { "13ms", 13 }, { "14ms", 14 }, { "15ms", 15 }, { "5ms", 5 }, { "6ms", 6 }, { "7ms", 7 }, { "8ms", 8 }, { "9ms", 9 },  },
						"0 (12.5ms), 1 (6.25ms), 5 (5ms), 6 (6ms), 7 (7ms), 8 (8ms), 9 (9ms), 10 (10ms), 11 (11ms), 12 (12ms), 13 (13ms), 14 (14ms), 15 (15ms)")
				},
				{ DbKeys.XPND_TAT,
					new DbMetadata("Xpnd", "TAT", typeof(short), cfg_param_type_t.CFG_NUM16, 40, 0, 300, 0, 2000,
						null,
						"0..2000, 0.1 ms steps")
				},
				{ DbKeys.XPND_TXTONEDUR,
					new DbMetadata("Xpnd", "TxToneDur", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 10, 0, 15,
						new Dictionary<String, int>() { { "12.5ms", 0 }, { "6.25ms", 1 }, { "10ms", 10 }, { "11ms", 11 }, { "12ms", 12 }, { "13ms", 13 }, { "14ms", 14 }, { "15ms", 15 }, { "5ms", 5 }, { "6ms", 6 }, { "7ms", 7 }, { "8ms", 8 }, { "9ms", 9 },  },
						"0 (12.5ms), 1 (6.25ms), 5 (5ms), 6 (6ms), 7 (7ms), 8 (8ms), 9 (9ms), 10 (10ms), 11 (11ms), 12 (12ms), 13 (13ms), 14 (14ms), 15 (15ms)")
				},
				{ DbKeys.XPND_BANDWIDTH,
					new DbMetadata("Xpnd", "XpndBW", typeof(int), cfg_param_type_t.CFG_ENUM, -1, 0, 9, 5, 9,
						new Dictionary<String, int>() { { "5kHz", 5 }, { "9kHz", 9 },  },
						"5 (5kHz), 9 (9kHz)")
				},
				{ DbKeys.XPND_XPNDEMUMODE,
					new DbMetadata("Xpnd", "XpndEmuMode", typeof(int), cfg_param_type_t.CFG_ENUM, -2, 0, 0, 0, 4,
						new Dictionary<String, int>() { { "Off", 0 }, { "Tone", 1 }, { "HPR400", 2 },  },
						"0 (Off), 1 (Tone), 2 (HPR400)")
				},
				{ DbKeys.XPND_XPNDEMUTAT,
					new DbMetadata("Xpnd", "XpndEmutat", typeof(short), cfg_param_type_t.CFG_NUM16, -2, 0, 300, 250, 1000,
						null,
						"250 ..1000, 0.1 ms steps")
				},
				{ DbKeys.XPND_LOGRESULTS,
					new DbMetadata("Xpnd", "XpndLog", typeof(bool), cfg_param_type_t.CFG_BOOL, -1, 0, false, false, true,
						null,
						null)
				},
			};
		}
	}

}   // End of namespace
