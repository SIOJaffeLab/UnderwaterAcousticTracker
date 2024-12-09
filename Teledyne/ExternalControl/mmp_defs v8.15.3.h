#ifndef _MMP_DEFS_H_
#define _MMP_DEFS_H_
/*****************************************************************************************
 * Modem Management Protocol (MMP) Definition Header File
 *
 * Copyright (C) 2022 Teledyne Marine Systems
 * All Rights Reserved
 *
 * Automatically generated on 03/11/2022 at 16:01:34
 *****************************************************************************************/


/*
' Acoustic trigger maximum assert time that can be specified in acoustic message
'  system=constant

*/
#define ACOUTRIG_MAX_ASSERT_SECS 2790

/*
' Sentinel for acoustic battery charge response
'  system=constant

*/
#define ACOU_BATT_CHG_UNAVAIL 0xFF

/*
'  system=constant

*/
#define ACOU_SAMPLE_CELL_SIZE 1024

/*
'  system=constant

*/
#define AES_MAX_KEY_SIZE 16

/*
'  system=constant

*/
#define BATTERY_STATUS_COUNTS_PER_VOLT 2

/*
'  system=constant

*/
#define BATTERY_STATUS_VOLT_RANGE 60

/*
'  system=constant

*/
#define BATTLIFE_NUM_VOLT_READINGS 2

/*
'  system=constant

*/
#define BATT_EXTDC 4

/*
'  system=constant

*/
#define BATT_IBPS 1

/*
'  system=constant

*/
#define BATT_LIPRIMARY 3

/*
'  system=constant

*/
#define BATT_SMART 2

/*
'  system=constant

*/
#define BATT_STD 0

/*
'  system=constant

*/
#define BOOTLOADER_BASE 0x00000L

/*
'  system=constant

*/
#define BOOTLOADER_SIZE 0x1ffffL

/*
'  system=constant

*/
#define BURN_WIRE_WAIT_TIME 36000

/*
'  system=constant

*/
#define CPBOARD_ALWAYS 2

/*
'  system=constant

*/
#define CPBOARD_OFF 0

/*
'  system=constant

*/
#define CPBOARD_PROGRAM 3

/*
'  system=constant

*/
#define CPBOARD_PWRSAVE 1

/*
'  system=constant

*/
#define DFLT_MAX_NUM_SMART_BATTS 4

/*
'  system=constant

*/
#define DIAG_BASE 0x60000L

/*
' Datalogger record store locations
'  system=constant

*/
#define DLOG_CFG_STORE_INTERNAL 0

/*
'  system=constant

*/
#define DLOG_CFG_STORE_SDHC 1

/*
'  system=constant

*/
#define DLOG_SRCFLAG_ALL 0xFFFF

/*
' system=constant

*/
#define FEAT_KEY_PREFIX_LEN 9

/*
'  system=constant

*/
#define GEOPRO_MAX_ADDR 120

/*
'  system=constant

*/
#define GEOPRO_MIN_ADDR 1

/*
'  system=constant

*/
#define GET_1CHIRP_RNG_RESPONSE_DOWN 1

/*
'  system=constant

*/
#define GET_1CHIRP_RNG_RESPONSE_UP 0

/*
'  system=constant

*/
#define GET_RANGE_TYPE_ABSOLUTE 0

/*
'  system=constant

*/
#define GET_RANGE_TYPE_COMPASS 2

/*
'  system=constant

*/
#define GET_RANGE_TYPE_DEPTH 11

/*
'  system=constant

*/
#define GET_RANGE_TYPE_HIGH_ABS 4

/*
'  system=constant

*/
#define GET_RANGE_TYPE_HIGH_COM 8

/*
'  system=constant

*/
#define GET_RANGE_TYPE_HIGH_ELV 7

/*
'  system=constant

*/
#define GET_RANGE_TYPE_HIGH_INC 5

/*
'  system=constant

*/
#define GET_RANGE_TYPE_HIGH_PCH 9

/*
'  system=constant

*/
#define GET_RANGE_TYPE_HIGH_REL 6

/*
'  system=constant

*/
#define GET_RANGE_TYPE_HIGH_RLL 10

/*
'  system=constant

*/
#define GET_RANGE_TYPE_HOMING 14

/*
'  system=constant

*/
#define GET_RANGE_TYPE_PROBE 13

/*
'  system=constant

*/
#define GET_RANGE_TYPE_RANGE_ONLY 15

/*
'  system=constant

*/
#define GET_RANGE_TYPE_RELATIVE 1

/*
'  system=constant

*/
#define GET_RANGE_TYPE_TILT 3

/*
'  system=constant

*/
#define GPSSYNC_GGA 2

/*
'  system=constant

*/
#define GPSSYNC_NONE 0

/*
'  system=constant

*/
#define GPSSYNC_RMC 3

/*
'  system=constant

*/
#define GPSSYNC_ZDA 1

/*
'  system=constant

*/
#define IMAGE_BASE 0x20000L

/*
'  system=constant

*/
#define IMAGE_SIZE 0x7ffffL

/*
'  system=constant

*/
#define INVALID_BEARING 0xFFFF

/*
' system=constant

*/
#define MAX_FEAT_KEYS 32

/*
'  system=constant

*/
#define MAX_TRANSPORT_ADDR 4

/*
'  system=constant

*/
#define MAX_TRANSPORT_DST 3

/*
' system=constant

*/
#define MD5_ASCII_KEY_LEN 32

/*
' system=constant

*/
#define MD5_KEY_LEN 16

/*
'  system=constant

*/
#define MIN_TRANSPORT_ADDR 1

/*
'  system=constant

*/
#define MIN_TRANSPORT_DST 0

/*
'  system=constant

*/
#define MMP_ACOU_FLAG_ACKONLY 0x0001

/*
' system=constant

*/
#define MMP_FEAT_KEY_LEN 42

/*
' 
' system=constant

*/
#define MMP_HDRERR_LOWSNRACQ 0x7FFF

/*
'  system=constant

*/
#define MMP_MAX_DEVICE_LEN_REQUEST 4096

/*
' Highest value of a notification counter before it wraps
'  system=constant

*/
#define MMP_NTFY_COUNT_MAX 0xFF

/*
'  system=constant

*/
#define MMP_SREG_ALL_SIZE 60

/*
'  system=constant

*/
#define MODEM_APP_VERSION_MAJOR 8

/*
'  system=constant

*/
#define MODEM_APP_VERSION_MINOR 15

/*
'  system=constant

*/
#define MODEM_APP_VERSION_REVISION 3

/*
'  system=constant

*/
#define MOD_FH_160_MA 66

/*
'  system=constant

*/
#define MOD_FH_80_JA 68

/*
'  system=constant

*/
#define MOD_FH_80_MA 67

/*
'  system=constant

*/
#define MOD_FH_80_MR 65

/*
'  system=constant

*/
#define MOD_FH_80_STD 1

/*
'  system=constant

*/
#define MOD_FH_80_WH 64

/*
'  system=constant

*/
#define MOD_MFSK_1066 6

/*
'  system=constant

*/
#define MOD_MFSK_1066x2 26

/*
'  system=constant

*/
#define MOD_MFSK_1200 7

/*
'  system=constant

*/
#define MOD_MFSK_1200x2 27

/*
'  system=constant

*/
#define MOD_MFSK_140 2

/*
'  system=constant

*/
#define MOD_MFSK_140x2 22

/*
'  system=constant

*/
#define MOD_MFSK_2400 8

/*
'  system=constant

*/
#define MOD_MFSK_2400x2 28

/*
'  system=constant

*/
#define MOD_MFSK_300 3

/*
'  system=constant

*/
#define MOD_MFSK_300x2 23

/*
'  system=constant

*/
#define MOD_MFSK_600 4

/*
'  system=constant

*/
#define MOD_MFSK_600x2 24

/*
'  system=constant

*/
#define MOD_MFSK_800 5

/*
'  system=constant

*/
#define MOD_MFSK_800x2 25

/*
'  system=constant

*/
#define MOD_PSK_10240 12

/*
'  system=constant

*/
#define MOD_PSK_15360 13

/*
'  system=constant

*/
#define MOD_PSK_2560 9

/*
'  system=constant

*/
#define MOD_PSK_5120 10

/*
'  system=constant

*/
#define MOD_PSK_7680 11

/*
'  system=constant

*/
#define NULL_BOOT_IMAGE 0xffffffffL

/*
'  system=constant

*/
#define NULL_TRANSPORT_ADDR 0

/*
'  system=constant

*/
#define NUM_TRANSPORT_ADDRS 5

/*
'  system=constant

*/
#define NUM_TRANSPORT_DSTS 4

/*
'  system=constant

*/
#define PM_PROC_RATE 20

/*
'  system=constant

*/
#define PPS_MODE_CSAC 3

/*
'  system=constant

*/
#define PPS_MODE_EXT_FALL 4

/*
'  system=constant

*/
#define PPS_MODE_EXT_RISE 1

/*
'  system=constant

*/
#define PPS_MODE_INT_RTC 2

/*
'  system=constant

*/
#define PPS_MODE_MAX_NUM 5

/*
'  system=constant

*/
#define PPS_MODE_OFF 0

/*
'  system=constant

*/
#define PROBE_DATA_SIZE 512

/*
'  system=constant

*/
#define RELEASE_WAIT_TIME 800

/*
'  system=constant

*/
#define REMOTE_AGC_HISTORY_SIZE 10

/*
'  system=constant

*/
#define REMOTE_REGISTERS_SIZE 21

/*
'  system=constant

*/
#define RESPONDER_MODE_FALL 2

/*
'  system=constant

*/
#define RESPONDER_MODE_OFF 0

/*
'  system=constant

*/
#define RESPONDER_MODE_RISE 1

/*
'  system=constant

*/
#define RESPONDER_MODE_SEND 3

/*
'  system=constant

*/
#define SEND_RANGE_TAT_FAST 1

/*
'  system=constant

*/
#define SEND_RANGE_TAT_SLOW 0

/*
'  system=constant

*/
#define SEND_RANGE_TAT_VFAST 2

/*
'  system=constant

*/
#define SERIAL_BOOT_IMAGE_U1 0xfffffffeL

/*
'  system=constant

*/
#define SERIAL_BOOT_IMAGE_U2 0xfffffffdL

/*
'  system=constant

*/
#define SREG_NORM 60

/*
'eliminated neighbor table
'  system=constant

*/
#define SREG_TOTAL 60

/*
'  system=constant

*/
#define SVN_REVNO 19863

/*
'  system=constant

*/
#define TRANSPOND_MAX_RX_WIDTH 15

/*
'  system=constant

*/
#define TRANSPOND_MIN_RX_WIDTH 5

/*
'  system=constant

*/
#define TRANSPORT_DST_P1 1

/*
'  system=constant

*/
#define TRANSPORT_DST_P2 2

/*
'  system=constant

*/
#define TR_TX_MAX_PWR 8

/*
'  system=constant

*/
#define TTS_MAX_DETECT_THRESH 999L

/*
'  system=constant

*/
#define TTS_MIN_DETECT_THRESH 10L

/*
'  system=constant

*/
#define TXPWR_UNAVAIL 0x7FFF

/*
'  system=constant

*/
#define URI_CLR_CODE 76

/*
'  system=constant

*/
#define URI_MAX_CMD_CODE 75

/*
'  system=constant

*/
#define URI_MAX_CODE 76

/*
'  system=constant

*/
#define URI_MAX_RLS_CODE 63

/*
'  system=constant

*/
#define URI_MIN_CMD_CODE 64

/*
'  system=constant

*/
#define URI_MIN_CODE 0

/*
'  system=constant

*/
#define URI_MIN_RLS_CODE 0

/*
'  system=constant

*/
#define USERIMAGE_BASE 0x10000L

/*
'  system=constant

*/
#define USERIMAGE_MASK 0x0FFFFL

/*
'  system=constant

*/
#define UTS_MAX_NUM_SMART_BATTS 2

/*
'  system=constant

*/
#define XPND_MAX_FREQ_LF 16000

/*
'  system=constant

*/
#define XPND_MAX_TX_FREQ 70000

/*
'  system=constant

*/
#define XPND_MIN_FREQ_LF 7000

/*
'  system=constant

*/
#define XPND_MIN_TX_FREQ 1000

/*
'  system=constant

*/
#define XPND_STEP 250

/*
'  system=constant

*/
#define XPND_TTS_FREQS 41

/*
'  system=constant

*/
#define _IO_TONE_MODE_HPR400 2

/*
' defines for USBLmode config prarameter
'  system=constant

*/
#define _IO_TONE_MODE_NONE 0

/*
'  system=constant

*/
#define _IO_TONE_MODE_TONE 1

/*
'  system=constant

*/
#define _NUM_TILT_AXES 3

/*
'  system=constant

*/
#define _TILT_AP_XNEG 1

/*
'  system=constant

*/
#define _TILT_AP_XPOS 0

/*
'  system=constant

*/
#define _TILT_AP_YNEG 3

/*
'  system=constant

*/
#define _TILT_AP_YPOS 2

/*
'  system=constant

*/
#define _TILT_AP_ZNEG 5

/*
'  system=constant

*/
#define _TILT_AP_ZPOS 4

/*
' Defines of the three tilt/acceleration axes
'  system=constant

*/
#define _TILT_AXIS_X 0

/*
'  system=constant

*/
#define _TILT_AXIS_Y 1

/*
'  system=constant

*/
#define _TILT_AXIS_Z 2

/*
'  system=constant

*/
#define _TILT_POLARITY_NEG 1

/*
'  system=constant

*/
#define _TILT_POLARITY_POS 0

/*
'  system=constant

*/
#define _UDB_VERSION_MAJOR 8

/*
'  system=constant

*/
#define _UDB_VERSION_MINOR 15

/*
'  system=constant

*/
#define _UDB_VERSION_REVISION 3

/*
 

*/
typedef enum
{
    MMP_VERSION_MAJOR                        = 2,
    MMP_VERSION_MINOR                        = 5
} mmp_version_num_t;


/*
 

*/
typedef enum
{
    MMP_BUFSIZE                              = 4224,    /* Maximum MMP buffer size in bytes */
    MMP_RESPONSE_TIMEOUT                     = 1500,    /* Time in msec for an MMP response to come back */
    MMP_NMEA_BUFSIZE                         = 103    /* Maximum NMEA sentence size + 21 (Hemisphere, for example, exceeds the 82 character spec) */
} mmp_misc_t;


/*
 

*/
typedef enum
{
    MMP_SENTINEL                             = '@',    /* Separator for serial MMP commands */
    NMEA_SENTINEL                            = '$'
} mmp_sentinel_t;


/*
 
 subfield=mmp_gsxn_t::type

*/
typedef enum
{
    MMP_GET                                  = 'g',    /* Indicates an MMP GET operation */
    MMP_SET                                  = 's',    /* Indicates an MMP SET operation */
    MMP_EXECUTE                              = 'x',    /* Indicates an MMP EXEC operation */
    MMP_NOTIFY                               = 'n'    /* Indicates an MMP NOTIFY operation */
} mmp_type_t;


/*
*************************
 MMP Command Sections
*************************
 
 system=cmdsect
 subfield=mmp_cmd_result_t::cmdsect

*/
typedef enum
{
    MMP_CMDSECT_NULL                         = 0x00,    /* Null command section (unused) */
    MMP_CMDSECT_STD                          = 0x01,    /* Standard commands and operations supported on most modem-based platforms */
    MMP_CMDSECT_RNGRLS                       = 0x02,    /* Ranging and releasing operations */
    MMP_CMDSECT_DATALOG                      = 0x04,    /* Commands for Data Logger */
    MMP_NUM_CMDSECT                          = 0x06
} mmp_cmdsect_t;


/*
*************************
 MMP Subsystems
*************************
 
 system=subsys

*/
typedef enum
{
    MMP_SUBSYS_IFACE                         = 0x00,    /* MMP interface configuration and control data/notifications */
    MMP_SUBSYS_SREG                          = 0x01,    /* S-Registers */
    MMP_SUBSYS_DECKBOX                       = 0x02,    /* Deck box-specific data/notifications */
    MMP_SUBSYS_DATA                          = 0x04,    /* Data packets and other general notifications */
    MMP_SUBSYS_TRANSPOND                     = 0x05,    /* Transponding and ranging data/notifications */
    MMP_SUBSYS_TIME                          = 0x06,    /* Time- and date-related data/notifications */
    MMP_SUBSYS_CFG_ALL                       = 0x3F,    /* Special subsystem for retrieving all values in a config section: set the field with the CFG section number to get or MMP_SUBSYS_CFG_ALL to get all sections.  If used with a SET operation and MMP_SUBSYS_CFG_ALL is used for both the the subsys and field, the configuration database will be written to flash. */
    CFG_SECT_COPROC                          = 0x40,    /* Co-processor board */
    CFG_SECT_DATALOG                         = 0x41,    /* On-board datalogger */
    CFG_SECT_MODEM                           = 0x42,    /* Modem functionality */
    CFG_SECT_RELEASE                         = 0x44,    /* Release functionality */
    CFG_SECT_SERIAL                          = 0x46,    /* UART paramters */
    CFG_SECT_SYSTEM                          = 0x47,    /* System parameters */
    CFG_SECT_TEST                            = 0x48,    /* Test functionality */
    CFG_SECT_VERSION                         = 0x49,    /* Version information */
    CFG_SECT_XPND                            = 0x4A,    /* Transpond control */
    CFG_SECT_DAT                             = 0x4B,    /* (DAT ONLY) Directional Acoustic Transponder configuration */
    CFG_SECT_NAV                             = 0x4C,    /* Navigation and Positioning */
    CFG_SECT_RECORDER                        = 0x4D,    /* In-band acoustic data recorder configuration */
    CFG_SECT_TRANSPORT                       = 0x50,    /* Transport layer routing/tagging information */
    CFG_SECT_AIN                             = 0x52,
    CFG_SECT_PRESSURE                        = 0x53,
    CFG_SECT_USBL                            = 0x54,    /* (DAT ONLY) USBL control section */
    CFG_SECT_JANUS                           = 0x56,    /* JANUS configuration parameters */
    MMP_NUM_SUBSYS                           = 0x57
} mmp_subsys_t;


/*
 
 subfield=mmp_gsxn_t::xid

*/
typedef enum
{
    MMP_XID_NULL                             = 0,
    MMP_XID_FIRST                            = 1,
    MMP_XID_LAST                             = 255
} mmp_xid_sentinel_t;


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
typedef enum
{
    MMP_FALSE                                = 0,    /* False/Off/Disabled */
    MMP_TRUE                                 = 1    /* True/On/Enabled */
} mmp_bool_t;


/*
 
 subfield=mmp_cfg_paramval_t::val_or_len

*/
typedef enum
{
    various_values                           = 0    /* Values here should be appropriate for the subsystem::field being set/gotten. */
} mmp_various_t;


/*
 
 subfield=mmp_spkr_phones_vol_t::volume

*/
typedef enum
{
    val_8_bit                                = 0    /* 0 to 255 */
} mmp_u8_bit_range_t;


/*
 

*/
typedef enum
{
    val_16_bit                               = 0    /* 0 to 65535 */
} mmp_u16_bit_range_t;


/*
 

*/
typedef enum
{
    signed_val_16_bit                        = 0    /* -32768 to 32767 */
} mmp_s16_bit_range_t;


/*
 

*/
typedef enum
{
    val_32_bit                               = 0    /* 0 to 4,294,967,295 */
} mmp_u32_bit_range_t;


/*
 

*/
typedef enum
{
    signed_val_32_bit                        = 0    /* -2,147,483,648 to 2,147,483,647 */
} mmp_s32_bit_range_t;


/*
 
 subfield=mmp_cfg_paramval_t::type

*/
typedef enum
{
    CFG_NUM16                                = 0,    /* A signed 16-bit integer */
    CFG_NUM32                                = 1,    /* A signed 32-bit integer */
    CFG_STR                                  = 2,    /* A variable length character string */
    CFG_BOOL                                 = 3,    /* A Boolean value (0 for false, 1 for true) */
    CFG_FIXED                                = 4,    /* A 32-bit integer representing a fractional number with 0.0001 precision.  Divide this integer value by 10000 to obtain the true fractional value it represents. */
    CFG_ENUM                                 = 5,    /* A 32-bit signed enumerated value.  This config parameter is restricted to a finite set of pre-defined values dependent on which configuration field it applies to. */
    CFG_CSTM                                 = 6,    /* A custom format with layout dependent on the configuration field it applies to. */
    CFG_BITMASK                              = 7    /* A format allowing the sum of valid values */
} cfg_param_type_t;


/*
 Sect COPROC
============
 
 subsys=CFG_SECT_COPROC

*/
typedef enum
{
    CFG_COPROC_CPBOARD                       = 0,    /* Indicate power mode of coprocessor board */
    CFG_COPROC_FDFWDTAPS                     = 1,    /* PSK number of forward taps */
    CFG_COPROC_FDBCKTAPS                     = 2,    /* PSK number of backward taps */
    CFG_NUM_COPROC_PARAMS                    = 3
} cfg_coproc_param_enum_t;


/*
 Sect DATALOG
=============
 
 subsys=CFG_SECT_DATALOG

*/
typedef enum
{
    CFG_DATALOG_ACDATA                       = 0,    /* Log acoustically received data to datalogger */
    CFG_DATALOG_ACSTATS                      = 1,    /* Log acoustic statistics to datalogger */
    CFG_DATALOG_RINGBUF                      = 2,    /* Configure datalogger as flat (stop when full) or circular (oldest records discarded for newer) */
    CFG_DATALOG_SUBBLKS                      = 3,
    CFG_DATALOG_LOGMODE                      = 4,    /* The record-partitioning mode for the data logger: time, character, or size based. */
    CFG_DATALOG_SENTINEL                     = 5,    /* The ASCII value of a sentinel character that will trigger closure of a discrete record in the data logger */
    CFG_DATALOG_CHRCOUNT                     = 6,    /* The number of characters that must be reached in order to trigger closure of a discrete record in the data logger */
    CFG_DATALOG_LOGSTORE                     = 7,    /* Indicates which storage medium the data logger points to (internal or external SDHC) */
    CFG_NUM_DATALOG_PARAMS                   = 8
} cfg_datalog_param_enum_t;


/*
 Sect MODEM
=============
 
 subsys=CFG_SECT_MODEM

*/
typedef enum
{
    CFG_MODEM_DATARETRY                      = 0,    /* Acoustic data retry mode */
    CFG_MODEM_ACRSPTMOUT                     = 1,    /* Acoustic response timeout */
    CFG_MODEM_OPMODE                         = 2,    /* Operation mode */
    CFG_MODEM_DEVENABLE                      = 3,    /* Device enable line behavior */
    CFG_MODEM_UNUSED1                        = 4,
    CFG_MODEM_FWDDELAY                       = 5,    /* Data packet forwarding delay */
    CFG_MODEM_UNUSED2                        = 6,
    CFG_MODEM_LOCALADDR                      = 7,    /* Modem local address */
    CFG_MODEM_PRNTHEX                        = 8,    /* Print modem data hexadecimal */
    CFG_MODEM_REMOTEADDR                     = 9,    /* Modem default remote address */
    CFG_MODEM_RXPKTTYPE                      = 10,    /* Receive packet type */
    CFG_MODEM_SHOWBADDATA                    = 11,    /* Determine whether to process or discard data with bit errors */
    CFG_MODEM_STARTTONES                     = 12,    /* Control playing of startup tones upon boot */
    CFG_MODEM_TXRATE                         = 13,    /* Acoustic transmit bitrate of data */
    CFG_MODEM_TXPOWER                        = 14,    /* Acoustic transmit power level */
    CFG_MODEM_WAKETONES                      = 15,    /* Control sending of wakeup preamble tones. */
    CFG_MODEM_RSVD1                          = 16,    /* Unused */
    CFG_MODEM_INPUTMODE                      = 17,    /* Select the UART input mode for data transfer and data logging (single, dual) */
    CFG_MODEM_SMARTRETRY                     = 18,    /* Control use of SmartRetry functionality for corrupted packet transmissions when data retries are enabled */
    CFG_MODEM_L2PROTOCOL                     = 19,    /* Layer 2 Protocol selector */
    CFG_MODEM_HEADERRATE                     = 20,    /* Acoustic transmit bitrate rate of header */
    CFG_MODEM_DOMAINKEY                      = 21,    /* Domain key that is used to create comms exclusivity groups */
    CFG_MODEM_AUTODETECTHDR                  = 22,    /* Determine whether to enable auto detect of header or use setting in HeaderRate parm */
    CFG_MODEM_CHIRP_THRESHOLD                = 23,    /* threshold adjustment for chirp detection */
    CFG_MODEM_TXATTEN                        = 24,    /* Sets the maximum acoustic SPL output; the @TxPower parameter range is scaled according to this parameter. */
    CFG_MODEM_ADDRGROUP                      = 25,    /* Moves LocalAddr to another group */
    CFG_MODEM_APCNOISSEL                     = 26,
    CFG_MODEM_APCALPHSM                      = 27,
    CFG_MODEM_APCALPHSM2                     = 28,
    CFG_MODEM_APCMAXTXP                      = 29,
    CFG_MODEM_APCMINTXP                      = 30,
    CFG_MODEM_ACKMODE_DONOTUSE               = 31,
    CFG_NUM_MODEM_PARAMS                     = 32
} cfg_modem_param_enum_t;


/*
 Sect NETWORK
=============
 
 subsys=CFG_SECT_NETWORK

*/
typedef enum
{
    CFG_NETWORK_RTSATTMPTS                   = 0,    /* Number or RTS Attempts */
    CFG_NETWORK_RESERVE1                     = 1,    /* Formerly Data Retries */
    CFG_NETWORK_NUMBCSTPING                  = 2,    /* Number of broadcast pings to try in a broadcast ping command.  1 - 255 (255 = ping indefinitely)  */
    CFG_NETWORK_PINGRETRY                    = 3,    /* Number of ping retries if no response */
    CFG_NETWORK_PKTBUFF                      = 4,    /* Packet buffering enable/disable */
    CFG_NETWORK_PKTDELAY                     = 5,    /* Inter-packet delay, in seconds */
    CFG_NETWORK_FXDRSPTIME                   = 6,    /* Fixed Acoustic response time for network packets */
    CFG_NETWORK_FXDRSPCTL                    = 7,    /* Fixed response timer control enable/disable */
    CFG_NETWORK_MAXPINGRSP                   = 8,    /* Maximum Ping Response (1-16) */
    CFG_NETWORK_UNUSED1                      = 9,
    CFG_NETWORK_BRIEFLOWRATE                 = 10,    /* Control use of 140 bps on handshakeless protocol retransmits  */
    CFG_NETWORK_BRIEFPKTSZ                   = 11,    /* Packet size threshold for using handshakeless protocol */
    CFG_NETWORK_NSMA                         = 12,    /* Neighbor Sense Multi-Access enable/disable */
    CFG_NETWORK_DATAACKS                     = 13,    /* Data Acknowledgements Boolean */
    CFG_NETWORK_BRIEFACKS                    = 14,    /* Acknowledgements Boolean for Brief Mode exchanges */
    CFG_NUM_NETWORK_PARAMS                   = 15
} cfg_network_param_enum_t;


/*
 Sect TRANSPORT
===============
 
 subsys=CFG_SECT_TRANSPORT

*/
typedef enum
{
    CFG_TRANSPORT_L4ENB                      = 0,    /* Global enable or disable for transport layer activity */
    CFG_TRANSPORT_TPMODE                     = 1,    /* Enable mode for transport layer addressing information (force always on or track with InputMode) */
    CFG_TRANSPORT_SRCP1                      = 2,    /* Transport address to be applied to transmitted packets originating on UART 0 */
    CFG_TRANSPORT_SRCP2                      = 3,    /* Transport address to be applied to transmitted packets originating on UART 1 */
    CFG_TRANSPORT_DST1                       = 16,    /* Delivery destination for received packets tagged with transport address 1 */
    CFG_TRANSPORT_DST2                       = 17,    /* Delivery destination for received packets tagged with transport address 2 */
    CFG_TRANSPORT_DST3                       = 18,    /* Delivery destination for received packets tagged with transport address 3 */
    CFG_TRANSPORT_DST4                       = 19    /* Delivery destination for received packets tagged with transport address 4 */
} cfg_transport_param_enum_t;


/*
 Sect RELEASE
=============
 
 subsys=CFG_SECT_RELEASE

*/
typedef enum
{
    CFG_RELEASE_FSKRLSDUR                    = 0,    /* Duration (seconds) to play Benthos FSK release tones */
    CFG_RELEASE_LSTCOMMSCNT                  = 1,    /* Lost communication count (15 second increments) */
    CFG_RELEASE_RLSCODE                      = 2,    /* Release code to trigger this release (valid on release models only) */
    CFG_RELEASE_UNUSED1                      = 3,
    CFG_RELEASE_TIMEDRELEASE                 = 4,    /* Timeout count for timed releases */
    CFG_RELEASE_MOTORTYPE                    = 5,    /* Type of motor used in this release; only valid for releases which can support differing motor type */
    CFG_RELEASE_RLSMINENATIME                = 6,    /* Minimum on time for Release Enable */
    CFG_RELEASE_RLSMAXENATIME                = 7,    /* Maximum on time for Release Enable */
    CFG_RELEASE_ACOUTRIGTERM                 = 8,    /* Terminating conditions for acoustic triggers */
    CFG_NUM_RELEASE_PARAMS                   = 9
} cfg_release_param_enum_t;


/*
 Sect SERIAL
=============
 
 subsys=CFG_SECT_SERIAL

*/
typedef enum
{
    CFG_SERIAL_P1BAUD                        = 0,    /* Port 1 baud rate */
    CFG_SERIAL_P1ECHOCHAR                    = 1,    /* Port 1 echo (full/half duplex) */
    CFG_SERIAL_P1FLOWCTL                     = 2,    /* Port 1 flow control */
    CFG_SERIAL_P1IDLEPOL                     = 3,    /* Port 1 idle polarity */
    CFG_SERIAL_P1PROTOCOL                    = 4,    /* Port 1 comms protocol */
    CFG_SERIAL_P1STRIPB7                     = 5,    /* Port 1 strip bit 7 */
    CFG_SERIAL_P1NOSLEEP                     = 6,    /* Port 1 not counted towards activity for sleep */
    CFG_SERIAL_P2BAUD                        = 7,    /* Port 2 baud rate */
    CFG_SERIAL_P2ECHOCHAR                    = 8,    /* Port 2 echo (full/half duplex) */
    CFG_SERIAL_P2FLOWCTL                     = 9,    /* Port 2 flow control */
    CFG_SERIAL_P2IDLEPOL                     = 10,    /* Port 2 idle polarity */
    CFG_SERIAL_P2STRIPB7                     = 11,    /* Port 2 strip bit 7 */
    CFG_SERIAL_P2NOSLEEP                     = 12,    /* Port 2 not counted towards activity for sleep */
    CFG_SERIAL_P1MODE                        = 13,    /* Port 1 cooking mode */
    CFG_SERIAL_P2MODE                        = 14,    /* Port 2 cooking mode */
    CFG_SERIAL_P2PROTOCOL                    = 15,    /* Port 2 on RS232 or CMOS */
    CFG_SERIAL_LPFLOWCTL                     = 16,    /* allow RTS lines to be off on lowpower, follow HW flow control or remain on */
    CFG_SERIAL_P1PROMPT                      = 17,    /* control prompt display level on Port 1 */
    CFG_SERIAL_P2PROMPT                      = 18,    /* control prompt display level on Port 2 */
    CFG_NUM_SERIAL_PARAMS                    = 19
} cfg_serial_param_enum_t;


/*
 Sect SYSTEM
=============
 
 subsys=CFG_SECT_SYSTEM

*/
typedef enum
{
    CFG_SYSTEM_AUXINP                        = 0,    /* Enable auxiliary acoustic input */
    CFG_SYSTEM_ASCIIBIN                      = 1,    /* Received data output in standard ASCII or as a hex byte dump */
    CFG_SYSTEM_BANDWIDTH                     = 2,
    CFG_SYSTEM_CARRFREQ                      = 3,    /* Center carrier frequency (sets acoustic band) */
    CFG_SYSTEM_COMPMDMRST                    = 4,    /* Compact modem reset:  */
    CFG_SYSTEM_CMWAKEHIB                     = 5,    /* Compact modem wakeup hibernate time (formerly last digit of S-10 when >300) */
    CFG_SYSTEM_CMWAKELISTEN                  = 6,    /* Compact modem wakeup active listen time (formerly middle digit of S-10 when >400) */
    CFG_SYSTEM_HALFBW                        = 7,    /* Half bandwidth modulation: 1 = Normal, 2 = half bandwidth */
    CFG_SYSTEM_FHTHRESH                      = 8,    /* Frequency Hop receive threshold */
    CFG_SYSTEM_RLSTYPE                       = 9,    /* Configuration of release type (factory-set) */
    CFG_SYSTEM_SYNCPPS                       = 10,    /* Mode for 1 PPS clock signal syncing */
    CFG_SYSTEM_VERBOSE                       = 11,    /* console status verbosity */
    CFG_SYSTEM_WAKETHRESH                    = 12,
    CFG_SYSTEM_AUXOUT                        = 13,    /* Control behavior of auxiliary acoustic output: either default behavior (speaker/phones for UDB, copies of samples for others), or force copies of outbound samples to aux port. */
    CFG_SYSTEM_UNUSED1                       = 14,
    CFG_SYSTEM_VOLCONT                       = 15,    /* Use an analog linear pot on EXT_SENSE1_ADC to control speaker and headphone volume */
    CFG_SYSTEM_CMFASTWAKE                    = 16,    /* Enables fast wake from hibernate ability on compact modem (receiving side) and UDB (sending side). */
    CFG_SYSTEM_NAMEFORMAT                    = 17,
    CFG_SYSTEM_IDLETIMER                     = 18,    /* Low-power idle timer */
    CFG_SYSTEM_PROMPT                        = 19,
    CFG_SYSTEM_SYNCOUT                       = 20,    /* copy RTC PPS out on BIN_OUT_0 */
    CFG_SYSTEM_PULLUP0                       = 21,    /* BIN_IN_0 pullup  */
    CFG_SYSTEM_PULLUP1                       = 22,    /* BIN_IN_1 pullup */
    CFG_SYSTEM_MINOPVOLT                     = 23,    /* The operating voltage threshold below which transmissions will be automatically reduced in power to prevent brown-out resets  */
    CFG_SYSTEM_BATTERYTYPE                   = 24,    /* The type of battery being used to power the modem (Standard alkaline, Smart Li+, Lithium primary, etc.) */
    CFG_SYSTEM_BATTERYCAPACITY               = 25,    /* The capacity of the installed battery pack in watt-hours.  Only for certain release products with battery monitoring capability. */
    CFG_SYSTEM_BATTERYMFGDATE                = 26,    /* Manufacture date of the battery specifying month and year. Only for certain release products with battery monitoring capability. */
    CFG_SYSTEM_TILTAXIS                      = 27,    /* The axis of the built-in accelerometer to be used as the tilt/pitch reference */
    CFG_SYSTEM_PWRONTIMER                    = 28,    /* The Power On Timer used for Releases */
    CFG_SYSTEM_AWAKETIMER                    = 29,    /* The Awake Timer used for Releases */
    CFG_SYSTEM_ARWAKEHIB                     = 30,    /* The Acoustic Release Hibernate Sleep period */
    CFG_SYSTEM_RXSENS                        = 31,    /* hydrophone sensitivity in dB (uPa) for reference only */
    CFG_SYSTEM_AWAKEPOWER                    = 32,    /* keep TR board 12V and 3.3V on when in active receive */
    CFG_SYSTEM_TXSENS                        = 33,    /* Transmt Voltage Response, SPL in dB(uPa) at 1m at full power */
    CFG_SYSTEM_TXINTERP                      = 34,    /* Used for the Tx interpolation */
    CFG_SYSTEM_IOMODE0                       = 35,    /* Set behavior of external IO expansion signal 0 (UCT only) */
    CFG_NUM_SYSTEM_PARAMS                    = 36
} cfg_system_param_enum_t;


/*
 Sect TEST
=============
 
 subsys=CFG_SECT_TEST

*/
typedef enum
{
    CFG_TEST_DBGLVL                          = 0,    /* Test debug level */
    CFG_TEST_RCVALL                          = 1,    /* Receive all packets (sniffer mode) */
    CFG_TEST_RSPDELAY                        = 2,    /* Test response delay */
    CFG_TEST_PKTECHO                         = 3,    /* Test packet echo */
    CFG_TEST_PKTSIZE                         = 4,    /* Test packet size */
    CFG_TEST_UNUSED1                         = 5,
    CFG_TEST_SIMACDLY                        = 6,    /* Simulated variable acoustic delay, in milliseconds */
    CFG_TEST_TXSATURATE                      = 7,    /* Special test mode for enabling saturation on transmit */
    CFG_TEST_UNUSED2                         = 8,
    CFG_NUM_TEST_PARAMS                      = 9
} cfg_test_param_enum_t;


/*
 Sect VERSION
=============
 
 subsys=CFG_SECT_VERSION

*/
typedef enum
{
    CFG_VERSION_SWAPPNAME                    = 0,    /* Software application name string */
    CFG_VERSION_SWVERSION                    = 1,    /* Software version string */
    CFG_VERSION_DBVERSION                    = 2,    /* Configuration database version string */
    CFG_NUM_VERSION_PARAMS                   = 3
} cfg_version_param_enum_t;


/*
 Sect XPND
=============
 
 subsys=CFG_SECT_XPND

*/
typedef enum
{
    CFG_XPND_RXFREQ                          = 0,    /* Frequency to listen for response pings (applicable only to platforms without Multi-Rx capability) */
    CFG_XPND_RXLOCKOUT                       = 1,    /* Ping response lockout, in milliseconds */
    CFG_XPND_RXTONEDUR                       = 2,    /* Receive pulse width (enumerated: 0 = 12.5 ms, 1 = 6.25 ms, 5 = 5 ms ... 15 = 15 ms) */
    CFG_XPND_TAT                             = 3,    /* Transpond turn-around time at remote node, in tenths of a millisecond */
    CFG_XPND_TXTONEDUR                       = 4,    /* Interrogation pulse width (enumerated: 0 = 12.5 ms, 1 = 6.25 ms, 5 = 5 ms ... 15 = 15 ms) */
    CFG_XPND_RXTHRESH                        = 5,    /* Receive detection threshold for transponder pings, in standard deviations above mean noise level */
    CFG_XPND_AGCREF                          = 6,    /* The AGC level that should be set when the avg. background noise energy in the center of the band is at 1.  Lower values lower the noise floor allowing for more signal head-room; higher values raise it allowing more resolution for detecting weak signals. */
    CFG_XPND_RESPFREQ                        = 7,    /* Response tone sent on reception of tone set by CFG_XPND_RXFREQ after delay of CFG_XPND_TAT. */
    CFG_XPND_LBLMODE                         = 8,    /* Defines the action taken on the reception of a downward HFM chirp */
    CFG_XPND_XPNDEMUTAT                      = 9,    /* Transponder emulator response turn-around time in tenths of a millisecond */
    CFG_XPND_XPNDEMUMODE                     = 10,    /* Transponder emulator mode */
    CFG_XPND_HPR400CHAN                      = 11,    /* Set the HPR400 channel */
    CFG_XPND_RESPONDER                       = 12,    /* Enable Pulse responder mode */
    CFG_XPND_CHIRP_RESP                      = 13,    /* Define response to be requested as a reply to at%rr command */
    CFG_XPND_BANDWIDTH                       = 14,    /* Set bandwidth for processing */
    CFG_XPND_LOGRESULTS                      = 15,    /* Enable logging to data logger */
    CFG_XPND_GAPSRX                          = 16,    /* Gaps family C code to recieve */
    CFG_XPND_GAPSTX                          = 17,    /* Gaps family C code to respond with */
    CFG_XPND_GAPSWAKE                        = 18,    /* Gaps family C code to respond with */
    CFG_NUM_XPND_PARAMS                      = 19
} cfg_xpnd_param_enum_t;


/*
 Sect DAT
=============

 subsys=CFG_SECT_DAT

*/
typedef enum
{
    CFG_DAT_PREGAIN                          = 0,    /* gain for DAT channels relative to main, in dB */
    CFG_DAT_ROTATION                         = 1,    /* offset of acoustic zero to vehicle center line */
    CFG_DAT_VERBOSE                          = 2,    /* bits defining DAT report fields  */
    CFG_DAT_RXONDAT                          = 3,    /* main receiver uses DAT hydrophone */
    CFG_DAT_WRAPRANGE                        = 4,    /* for one way flight times of multiple seconds  */
    CFG_DAT_ORIENTATION                      = 5,    /* transducer points up or down */
    CFG_DAT_PHASEA                           = 6,    /* phase offset for reciever module A */
    CFG_DAT_PHASEB                           = 7,    /* phase offset for reciever module B */
    CFG_DAT_PHASEC                           = 8,    /* phase offset for reciever module C */
    CFG_DAT_PHASED                           = 9,    /* phase offset for reciever module D */
    CFG_DAT_BEARINGRESP                      = 10,    /* bearing response type */
    CFG_DAT_VTHRESH                          = 11,    /* vector quality threshold */
    CFG_DAT_MIN_ELEV                         = 12,    /* minimum acceptable elevation */
    CFG_DAT_MAX_ELEV                         = 13,    /* maximum acceptable elevation */
    CFG_DAT_PHASEREF                         = 14,    /* replica to use as reference for phase offset detection */
    CFG_DAT_ARRIVAL                          = 15,    /* Special test mode DAT for first or peak arrival */
    CFG_NUM_DAT_PARAMS                       = 16
} cfg_dat_param_enum_t;


/*
 Sect USBL
=============

 subsys=CFG_SECT_USBL

*/
typedef enum
{
    CFG_USBL_FORMAT                          = 0,    /* USBL bearing reporting format */
    CFG_USBL_DEPTH_QUERY                     = 1,    /* enable to query depth on every USBL cycle */
    CFG_USBL_REPEAT_QUERY                    = 2,    /* number of rapid range in every USBL cycle */
    CFG_USBL_AUTO_QUERY                      = 3,    /* set to start acoustic of pulse cycles on boot */
    CFG_USBL_AUTO_DELAY                      = 4,    /* delay between cycles in seconds */
    CFG_USBL_XDCER_DEPTH                     = 5,    /* depth of USBL head below surface in tenths of a meter */
    CFG_NUM_USBL_PARAMS                      = 6
} cfg_usbl_param_enum_t;


/*
 Sect NAV
=============
 
 subsys=CFG_SECT_NAV

*/
typedef enum
{
    CFG_NAV_LATITUDE                         = 0,    /* Latitude  in millionths of a degree */
    CFG_NAV_LONGITUDE                        = 1,    /* Longitude in millionths of a degree */
    CFG_NAV_GPSALT                           = 2,    /* absolute altitude relative to WGS84 */
    CFG_NAV_ALTITUDE                         = 3,    /* altitude above sea floor in meters */
    CFG_NAV_DEPTH                            = 4,    /* depth below sea level in meters */
    CFG_NAV_COMPASS                          = 5,    /* compass bearing in degrees */
    CFG_NAV_PITCH                            = 6,    /* pitch in degrees */
    CFG_NAV_ROLL                             = 7,    /* roll in degrees */
    CFG_NAV_CSOUND                           = 8,    /* speed of sound in m/s */
    CFG_NAV_REPLY_DATA                       = 9,    /* additional data fields for position information */
    CFG_NAV_HEADOFFSET                       = 10,    /* offset of compass heading to vehicle center line */
    CFG_NAV_SYNCRANGING                      = 11,    /* Enable one-way ranging on data transmissions when sychronized to external 1PPS sources */
    CFG_NAV_PITCHOFFSET                      = 12,    /* offset of AHRS pitch to transducer plane */
    CFG_NAV_ROLLOFFSET                       = 13,    /* offset of AHRS roll to transducer plane */
    CFG_NAV_GPSSYNCMSG                       = 14,    /* The type of GPS sentence, if any, that may be used to adjust the modem's system clock */
    CFG_NUM_NAV_PARAMS                       = 15
} cfg_nav_param_enum_t;


/*
 Sect RECORDER
=============
 
 subsys=CFG_SECT_RECORDER

*/
typedef enum
{
    CFG_RECORDER_FRONTEND                    = 0,
    CFG_RECORDER_RECMODE                     = 1,    /* recording mode for automatic recording */
    CFG_RECORDER_RECFORMAT                   = 2,
    CFG_RECORDER_NAMEFORMAT                  = 3,    /* format of names for recorded audio files */
    CFG_RECORDER_RXSENS                      = 4,
    CFG_NUM_RECORDER_PARAMS                  = 5
} cfg_recorder_param_enum_t;


/*
 Sect AIN
=============
 
 subsys=CFG_SECT_AIN

*/
typedef enum
{
    CFG_AIN_POLLRATE                         = 0,    /* time interval for automated polling */
    CFG_AIN_1NMEAS                           = 1,    /* number of measurements on chan 1 */
    CFG_AIN_1STRTDLY                         = 2,    /* delay in 1st reading after turn-on (ch1) */
    CFG_AIN_1RPTDLY                          = 3,    /* delay in each additional reading (ch1) */
    CFG_AIN_1TYPE                            = 4,    /* type of sensor on chan 1 */
    CFG_AIN_2NMEAS                           = 5,    /* number of measurements on chan 2 */
    CFG_AIN_2STRTDLY                         = 6,    /* delay in 1st reading after turn-on (ch2) */
    CFG_AIN_2RPTDLY                          = 7,    /* delay in each additional reading (ch2) */
    CFG_AIN_2TYPE                            = 8,    /* type of sensor on chan 2 */
    CFG_AIN_3NMEAS                           = 9,    /* number of measurements on chan 3 */
    CFG_AIN_3STRTDLY                         = 10,    /* delay in 1st reading after turn-on (ch3) */
    CFG_AIN_3RPTDLY                          = 11,    /* delay in each additional reading (ch3) */
    CFG_AIN_4NMEAS                           = 12,    /* number of measurements on chan 4 */
    CFG_AIN_4STRTDLY                         = 13,    /* delay in 1st reading after turn-on (ch4) */
    CFG_AIN_4RPTDLY                          = 14,    /* delay in each additional reading (ch4) */
    CFG_AIN_5NMEAS                           = 15,    /* number of measurements on chan 5 */
    CFG_AIN_5STRTDLY                         = 16,    /* delay in 1st reading after turn-on (ch5) */
    CFG_AIN_5RPTDLY                          = 17,    /* delay in each additional reading (ch5) */
    CFG_AIN_6NMEAS                           = 18,    /* number of measurements on chan 6 */
    CFG_AIN_6STRTDLY                         = 19,    /* delay in 1st reading after turn-on (ch6) */
    CFG_AIN_6RPTDLY                          = 20,    /* delay in each additional reading (ch6) */
    CFG_NUM_AIN_PARAMS                       = 21
} cfg_ain_param_enum_t;


/*
 Sect PRESSURE
=============
 
 subsys=CFG_SECT_PRESSURE

*/
typedef enum
{
    CFG_PRESSURE_AINCHNL                     = 0,    /* Analog input channel where the pressure transducer is connected, or 0 if none */
    CFG_PRESSURE_METERSPERPSI                = 1,    /* Conversion factor for pressure, number of meters per psi */
    CFG_PRESSURE_ATMOFFSET                   = 2,    /* Atmospheric pressure in PSI to be subtracted from pressure reading when converting to depth below sea level */
    CFG_PRESSURE_PSI                         = 3,    /* The pressure in pounds per square inch (psi) as set by user or updated from pressure gauge */
    CFG_NUM_PRESSURE_PARAMS                  = 4
} cfg_pressure_param_enum_t;


/*
 Sect JANUS
=============
 
 subsys=CFG_SECT_JANUS

*/
typedef enum
{
    CFG_JANUS_CLASSUSERID                    = 0,    /* DPSK board enable - control for the feature */
    CFG_JANUS_APPTYPE                        = 1,    /* Logging of DPSK Data */
    CFG_JANUS_MACTHRESH                      = 2,    /* DPSK Acoustic Ouput Format */
    CFG_NUM_JANUS_PARAMS                     = 3
} cfg_janus_param_enum_t;


/*
 Account privilege levels
  system=constant

*/
typedef enum
{
    CMD_PRIVLEV_SAFE                         = 0,
    CMD_PRIVLEV_USER                         = 1,
    CMD_PRIVLEV_UPDATE                       = 2,
    CMD_PRIVLEV_FACTORY                      = 3,
    CMD_PRIVLEV_DIAG                         = 4,
    CMD_PRIVLEV_SYS                          = 6,
    CMD_PRIVLEV_ROOT                         = 7,
    NUM_CMD_PRIVLEVS                         = 8
} cmd_privlev_t;


/*
 
 subfield=mmp_binio_t::value

*/
typedef enum
{
    DISABLE                                  = 0,    /* Disabled, off, low, etc. */
    ENABLE                                   = 1    /* Enabled, on, high, etc. */
} enable_t;


/*
 

*/
typedef enum
{
    FEAT_MODEM_DATA                          = 0,    /* Transmit and receive data packets with other modems */
    FEAT_MULTI_XPND_RX                       = 1,    /* Simultaneous receive of transpond pings on more than one frequency */
    FEAT_DAT_BEARING                         = 2,    /* Bearing calculations use Directional Acoustic Transponder */
    FEAT_WAVE_PLAY                           = 3,    /* User ability to use the 'play' and 'tone' commands for custom waveform transmission */
    FEAT_DUAL_UART                           = 4,    /* Enable dual serial port mode for transmitting acoustic packets and logging data */
    FEAT_INBAND_RECORD                       = 5,    /* Enable in band acoustic recording to SD card */
    FEAT_LOW_OUTPUT_PWR                      = 9,    /* enable a(n approximate) -24dB attenuation to be switched in that shifts the entire @TxPower range */
    FEAT_UTS_GNSS_SUPPORT                    = 10,    /* enable external GNSS functionality on UTS platforms that can support it */
    FEAT_GAPS_EMULATION                      = 11,    /* enable ability to act as a GAPS transponder */
    NUM_FEATS                                = 12
} modem_feature_t;


/*
 
 subfield=mmp_data_feat_key_status_t::available_features
 subfield=mmp_data_feat_key_status_t::expected_features
 subfield=mmp_data_feat_key_status_t::enabled_features
 subfield=mmp_data_feat_key_status_t::unauthorized_features

*/
typedef enum
{
    FEAT_FLAG_MODEM_DATA                     = 0x01,    /* Bit flag for Modem Data feature */
    FEAT_FLAG_MULTI_XPND_RX                  = 0x02,    /* Bit flag for multi ping transpond receive feature */
    FEAT_FLAG_DAT_BEARING                    = 0x04,    /* Bit flag for DAT Bearing feature */
    FEAT_FLAG_WAVE_PLAY                      = 0x08,    /* Bit flag for arbitrary waveform play feature */
    FEAT_FLAG_DUAL_UART                      = 0x10,    /* Bit flag for dual serial port input feature */
    FEAT_FLAG_INBAND_RECORD                  = 0x20,    /* Bit flag for inband recorder feature */
    FEAT_FLAG_LOW_OUTPUT_PWR                 = 0x200,    /* Bit flag for enabling -24 dB attenuation mode on transmit */
    FEAT_FLAG_UTS_GNSS_SUPPORT               = 0x400,    /* Bit flag for enabling external GNSS devices on the UTS platforms that can support it */
    FEAT_FLAG_GAPS_EMULATION                 = 0x800    /* Bit flag for enabling GAPS emulation */
} modem_feature_bitflag_t;


/*
 
 subfield=mmp_datalog_dump_t::source
 subfield=mmp_datalog_cmdresult_dump_t::source
 subfield=mmp_datalog_cmdresult_source_counts_t::source
 subfield=mmp_datalog_remote_getdlogblk_t::source

*/
typedef enum
{
    DLOG_SRC_P1                              = 0,    /* Serial port 1 */
    DLOG_SRC_P2                              = 1,    /* Serial port 2 */
    DLOG_SRC_RES1                            = 2,
    DLOG_SRC_RES2                            = 3,
    DLOG_SRC_AC                              = 4,    /* Acoustic transmission data */
    DLOG_SRC_XP                              = 5,    /* Transponder data */
    DLOG_SRC_DI                              = 6,    /* Diagnostic data */
    DLOG_SRC_MMP                             = 7,    /* Data inserted via MMP message */
    DLOG_SRC_DEV                             = 8,    /* Data inserted via /dev/logger system device */
    DLOG_SRC_AIN                             = 9,    /* Data from analog input */
    DLOG_NUM_SRCS                            = 10,
    DLOG_SRC_ALL                             = 0xFF    /* Sentinel for any/all sources */
} datalog_source_t;


/*
 Datalogger source flags, for use in some MMP messages and function calls.  Each flag corresponds to (1 << enum_equivalent)
 
 subfield=mmp_datalog_srcinfo_t::source_flags
 subfield=mmp_datalog_cmdresult_list_t::source_flags
 subfield=mmp_datalog_cmdresult_srcinfo_t::source_flags
 subfield=mmp_datalog_cmdresult_find_t::source_flags

*/
typedef enum
{
    DLOG_SRCFLAG_P1                          = 0x01,    /* Bit flag for Serial port 1 */
    DLOG_SRCFLAG_P2                          = 0x02,    /* Bit flag for Serial port 2 */
    DLOG_SRCFLAG_AC                          = 0x10,    /* Bit flag for Acoustic packets */
    DLOG_SRCFLAG_XP                          = 0x20,    /* Bit flag for Transponder activity */
    DLOG_SRCFLAG_DI                          = 0x40,    /* Bit flag for Diagnostic information (internally generated) */
    DLOG_SRCFLAG_MMP                         = 0x80,    /* Bit flag for Data inserted via MMP directive */
    DLOG_SRCFLAG_DEV                         = 0x100,    /* Bit flag for Data inserted via the /dev/logger interface */
    DLOG_SRCFLAG_AIN                         = 0x200,    /* Bit flag for Data from the analog input */
    DLOG_SRCFLAG_TRUNC                       = 0x2000,    /* Bit flag indicating this record was truncated */
    DLOG_SRCFLAG_RECOV                       = 0x4000    /* Bit flag indicating this record was recovered at boot */
} datalog_source_flag_t;


/*
 
 subfield=mmp_datalog_cmdresult_list_t::storeloc
 subfield=mmp_datalog_cmdresult_srcinfo_t::storeloc

*/
typedef enum
{
    DLOG_STORE_INTERNAL                      = 0,    /* On-board flash memory */
    DLOG_STORE_SDHC                          = 1    /* External SDHC card */
} datalog_store_t;


/*
 
 subfield=mmp_axis_tilt_response_t::axis_w_pol

*/
typedef enum
{
    TILT_AP_XPOS                             = 0,    /* X axis, positive polarity */
    TILT_AP_XNEG                             = 1,    /* X axis, negative polarity */
    TILT_AP_YPOS                             = 2,    /* Y axis, positive polarity */
    TILT_AP_YNEG                             = 3,    /* Y axis, negative polarity */
    TILT_AP_ZPOS                             = 4,    /* Z axis, positive polarity */
    TILT_AP_ZNEG                             = 5    /* Z axis, negative polarity */
} tilt_axis_and_polarity_t;


/*
 
 subfield=mmp_data_nav_status_t::location
 subfield=mmp_data_nav_status_t::heading
 subfield=mmp_data_nav_status_t::attitude

*/
typedef enum
{
    NAV_NOT_VALID                            = 0,    /* data from stored values */
    NAV_INT_VALID                            = 1,    /* data from internal source */
    NAV_EXT_VALID                            = 2    /* data from external source */
} nav_validity_t;


/*
 JANUS Class IDs
 
 subfield=mmp_data_janus_packet_t::class_userid

*/
typedef enum
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
} JANUS_classid_t;


/*
 
 subfield=mmp_data_lowpower_t::waketype

*/
typedef enum
{
    WAKE_TYPE_NULL                           = 0,    /* No wakeup */
    WAKE_TYPE_UART                           = 1,    /* Wake up from UART input */
    WAKE_TYPE_TIME                           = 2,    /* Wake up due to expiry of pre-set timer */
    WAKE_TYPE_ACOU                           = 3,    /* Wake up due to acoustic wake tones */
    WAKE_TYPE_ALARM                          = 4,    /* Wake up due RTC alarm */
    WAKE_TYPE_BATTLIFE                       = 5,    /* Wake up to update battery life monitoring */
    WAKE_TYPE_NO_SLEEP                       = 6    /* Sleep mode not defined - did not sleep */
} wake_type_t;


/*
*************************
 DATALOG Commands
*************************
 
 cmdsect=DATALOG

*/
typedef enum
{
    MMP_DATALOG_CMD_CLEAR                    = 0x00,    /* Clears the data logger buffer */
    MMP_DATALOG_CMD_SIZE                     = 0x01,    /* Report the number of bytes in the data logger */
    MMP_DATALOG_CMD_READ_DATA                = 0x02,    /* Read back the data logger buffer */
    MMP_DATALOG_CMD_READ_PAGE                = 0x03,    /* Read back a 4 kbyte page */
    MMP_DATALOG_CMD_READ_SECTOR              = 0x04,    /* Read back a 256 byte sector */
    MMP_DATALOG_CMD_WRITE_DATA               = 0x05,    /* Write data in to the data logger */
    MMP_DATALOG_CMD_SEEK                     = 0x06,    /* Set the read pointer to a specific location */
    MMP_DATALOG_CMD_TELL                     = 0x07,    /* Report the position of the read pointer */
    MMP_DATALOG_CMD_LIST                     = 0x08,    /* Retrieve general information about the local or remote data logger */
    MMP_DATALOG_CMD_FIND                     = 0x09,    /* Find records in the local or remote data logger using the command line query syntax */
    MMP_DATALOG_CMD_DUMP                     = 0x0A,    /* Dump the local or remote data logger based on byte offset and length (on all-source or per-source basis) */
    MMP_DATALOG_CMD_SRCINFO                  = 0x0B,    /* Get information pertaining to one or more data sources in the logger (total bytes and number of records) */
    MMP_DATALOG_CMD_REMOTE_GETDLOGBLK        = 0x0C,    /* Request a block of up to 4K from a remote modem's data logger with bit flags indicating which cells are valid/corrupted */
    MMP_NUM_DATALOG_CMD                      = 0x0D
} mmp_datalog_cmd_t;


/*
 
 subfield=mmp_datalog_cmdresult_write_data_t::status

*/
typedef enum
{
    MMP_DATALOG_WRITE_ERR_DISABLED           = -4,    /* Data logger writes disabled due to incompatible file schema in flash */
    MMP_DATALOG_WRITE_FILE_ERROR             = -3,    /* Error trying to open/delete/access a file */
    MMP_DATALOG_WRITE_ERR_DATALOG_FULL       = -2,    /* No more room left in data logger */
    MMP_DATALOG_WRITE_ERR_STORE_TO_FLASH     = -1,    /* Unable to store to flash	 */
    MMP_DATALOG_WRITE_SUCCESSFUL             = 0    /* A successful write */
} mmp_datalog_cmdresult_write_data_status_t;


/*
*************************
 RNGRLS Commands
*************************
 
 cmdsect=RNGRLS

*/
typedef enum
{
    MMP_RNGRLS_CMD_TRANSPOND                 = 0x00,    /* Issue interrogation or silent ping and enter transpond receive mode for the system default amount of time */
    MMP_RNGRLS_CMD_RANGE                     = 0x01,    /* Obtain the range to another modem */
    MMP_RNGRLS_CMD_RELEASE_STATUS            = 0x02,    /* Check the release mechanism status on a remote modem */
    MMP_RNGRLS_CMD_SMART_RELEASE             = 0x03,    /* Issue a release command to a remote Benthos SMART release (SR-50, SR-100, etc.) */
    MMP_RNGRLS_CMD_BURNWIRE                  = 0x04,    /* Issue a release command to a remote Benthos SMART modem (SM-75, OEM boardset w/ burn wire, etc.) */
    MMP_RNGRLS_CMD_FSK_RELEASE               = 0x05,    /* Issue a release command to a remote Benthos FSK release (Model 865, etc.) */
    MMP_RNGRLS_CMD_EDGETECH_RELEASE          = 0x06,    /* Issue a command to an EdgeTech/ORE/EG&G release */
    MMP_RNGRLS_CMD_URI_RELEASE               = 0x07,    /* Issue a command to a University of Rhode Island release/device  */
    MMP_RNGRLS_CMD_FLASH_XPNDADJ             = 0x08,    /* Save per-frequency transpond sensitivity threshold adjustments to flash */
    MMP_RNGRLS_CMD_BEARING                   = 0x09,    /* Obtain bearing from a DAT */
    MMP_RNGRLS_CMD_GEOPRO_RELEASE            = 0x0A,    /* Issue a command to a GeoPro (Germany) release unit */
    MMP_RNGRLS_CMD_NAVDATA                   = 0x0B,    /* Obtain position information from a remote modem */
    MMP_RNGRLS_CMD_CHANNEL_PROBE             = 0x0C,    /* probe channel for multipath */
    MMP_RNGRLS_CMD_RSERIES_RANGE             = 0x0D,    /* Ranging specific to a Teledyne Benthos next-gen release */
    MMP_RNGRLS_CMD_RSERIES_ACTIVATE          = 0x0E,    /* Activate an R Series release */
    MMP_RNGRLS_CMD_RSERIES_HIBERNATE         = 0x0F,    /* Hibernate an R Series release */
    MMP_RNGRLS_CMD_RSERIES_XPND_MODE         = 0x10,    /* Set the transpond reSponse mode in a remote R Series unit */
    MMP_RNGRLS_CMD_STD_XPND_MODE             = 0x11,    /* Set the transpond reSponse mode in a remote standard unit */
    MMP_RNGRLS_CMD_RSERIES_DB_UNLOCK         = 0x12,    /* Enable R Series transponding */
    MMP_RNGRLS_CMD_RSERIES_DB_LOCK           = 0x13,    /* Disable R Series transponding */
    MMP_RNGRLS_CMD_RSERIES_RELEASE           = 0x14,    /* Issue a release command to a remote Benthos R Series release */
    MMP_RNGRLS_CMD_RESPONDER_RANGE           = 0x15,    /* Issue pulse on binary out 1 to a responder */
    MMP_RNGRLS_CMD_TRANSPOND_W_TIMEOUT       = 0x16,    /* Issue interrogation or silent ping and enter transpond receive mode for a specified amount of time */
    MMP_RNGRLS_CMD_RANGE_W_TIMEOUT           = 0x17,    /* Issue a range request with a timeout specified (not system @AcRspTmOut default) */
    MMP_RNGRLS_CMD_SPECTRUM_MODE             = 0x18,    /* Enter or exit spectrum analysis mode, with update rate in 0.5 second increments (or 0 to disable) */
    MMP_RNGRLS_CMD_RANGE_USBL_REPEAT         = 0x19,    /* (DAT ONLY) Issue a range request for a define number of responses */
    MMP_RNGRLS_CMD_ABSREL                    = 0x1A,    /* Request the high precision absolute and relative bearing */
    MMP_RNGRLS_CMD_ACOU_SAMPLE               = 0x1D,    /* Record a 1 second basebanded in-band acoustic sample */
    MMP_RNGRLS_CMD_ABSCMPDEP                 = 0x1E,    /* Request the high precision compass and depth */
    MMP_RNGRLS_CMD_ACOUSTIC_TRIGGER          = 0x1F,    /* Send a trigger code to a remote device to activate the acoustic trigger signal */
    MMP_RNGRLS_CMD_BEARING_W_TIMEOUT         = 0x20,    /* Obtain bearing from a DAT with a timeout specified (not system @AcRspTmOut default) */
    MMP_NUM_RNGRLS_CMD                       = 0x21
} mmp_rngrls_cmd_t;


/*
 
 subfield=mmp_rngrls_bearing_t::type
 subfield=mmp_rngrls_navdata_t::type

*/
typedef enum
{
    MMP_RNGRLS_BEARING_ABS                   = 0,    /* relative to North */
    MMP_RNGRLS_BEARING_REL                   = 1,    /* relative to DAT body */
    MMP_RNGRLS_BEARING_COM                   = 2,    /* compass heading */
    MMP_RNGRLS_BEARING_TLT                   = 3,    /* tilt sensors */
    MMP_RNGRLS_BEARING_HIGH_ABS              = 4,    /* absolute bearing */
    MMP_RNGRLS_BEARING_HIGH_INC              = 5,    /* absolute inclination */
    MMP_RNGRLS_BEARING_HIGH_REL              = 6,    /* relative bearing */
    MMP_RNGRLS_BEARING_HIGH_ELV              = 7,    /* relative elevation */
    MMP_RNGRLS_BEARING_HIGH_COM              = 8,    /* compass heading */
    MMP_RNGRLS_BEARING_HIGH_PCH              = 9,    /* compass pitch */
    MMP_RNGRLS_BEARING_HIGH_RLL              = 10,    /* compass roll */
    MMP_RNGRLS_BEARING_DEPTH                 = 11,    /* depth from pressure transducer */
    MMP_RNGRLS_BEARING_PROBE                 = 13,    /* remote channel probe request */
    MMP_RNGRLS_BEARING_HOMING                = 14,    /* start of terminal homing mode */
    MMP_RNGRLS_BEARING_RANGE_ONLY            = 15,    /* Range only response */
    MMP_RNGRLS_BEARING_W_REPLYDATA           = 32    /* Add to bearing types to request reply data */
} mmp_rngrls_bearing_type_t;


/*
 
 subfield=mmp_rngrls_bearing_t::tat

*/
typedef enum
{
    MMP_RNGRLS_TAT_SLOW                      = 0,    /* legacy (slow) 2.4 second turn around */
    MMP_RNGRLS_TAT_FAST                      = 1,    /* standard (fast) 1.6 second turn around */
    MMP_RNGRLS_TAT_VFAST                     = 2    /* very fast 1.1 second turn around */
} mmp_rngrls_bearing_tat_t;


/*
 
 subfield=mmp_rngrls_fsk_param_t::code

*/
typedef enum
{
    MMP_RNGRLS_FSK_CODE_A                    = 'A',    /* ASCII A - 0x65 */
    MMP_RNGRLS_FSK_CODE_B                    = 'B',    /* ASCII B - 0x66 */
    MMP_RNGRLS_FSK_CODE_C                    = 'C',    /* ASCII C - 0x67 */
    MMP_RNGRLS_FSK_CODE_D                    = 'D',    /* ASCII D - 0x68 */
    MMP_RNGRLS_FSK_CODE_E                    = 'E',    /* ASCII E - 0x69 */
    MMP_RNGRLS_FSK_CODE_F                    = 'F',    /* ASCII F - 0x6A */
    MMP_RNGRLS_FSK_CODE_G                    = 'G',    /* ASCII G - 0x6B */
    MMP_RNGRLS_FSK_CODE_H                    = 'H',    /* ASCII H - 0x6C */
    MMP_RNGRLS_FSK_CODE_I                    = 'I',    /* ASCII I - 0x6D */
    MMP_RNGRLS_FSK_CODE_J                    = 'J',    /* ASCII J - 0x6E */
    MMP_RNGRLS_FSK_CODE_K                    = 'K',    /* ASCII K - 0x6F */
    MMP_RNGRLS_FSK_CODE_L                    = 'L',    /* ASCII L - 0x70 */
    MMP_RNGRLS_FSK_CODE_M                    = 'M'    /* ASCII M - 0x71 */
} mmp_rngrls_fsk_code_t;


/*
 
 subfield=mmp_rngrls_channel_probe_param_t::log

*/
typedef enum
{
    MMP_RNGRLS_PROBE_LOG_NONE                = 0,    /* no logging */
    MMP_RNGRLS_PROBE_LOG_STAT                = 1,    /* log only statistics */
    MMP_RNGRLS_PROBE_LOG_STAT_IMPULSE        = 2    /* log statistics and impulse */
} mmp_rngrls_probe_log_t;


/*
 
 subfield=mmp_rngrls_cmdresult_navdata_t::type
*************************

*/
typedef enum
{
    MMP_REPLY_DATA_NONE                      = 0,    /* no data replied */
    MMP_REPLY_DATA_LATLONG                   = 1,    /* latitude and longitude  */
    MMP_REPLY_DATA_LL_DEPTH                  = 2,    /* lat, long and depth */
    MMP_REPLY_DATA_LL_SEAFLOOR               = 3,    /* lat, long, depth and altitude above sea floor */
    MMP_REPLY_DATA_LL_GPSALT                 = 4,    /* lat, long, depth and altitude above sea level */
    NUM_NAVDATA_TYPES                        = 5
} navdata_type_t;


/*
 
 subfield=mmp_rngrls_edgetech_param_t::freq_spec
*************************

*/
typedef enum
{
    EDGETECH_9500_9900                       = 1,    /* 9500 Hz off, 9900 Hz on */
    EDGETECH_9500_10300                      = 2,    /* 9500 Hz off, 10300 Hz on */
    EDGETECH_9500_10700                      = 3,    /* 9500 Hz off, 10700 Hz on */
    EDGETECH_9900_10300                      = 4,    /* 9900 Hz off, 10300 Hz on */
    EDGETECH_9900_10700                      = 5,    /* 9900 Hz off, 10700 Hz on */
    EDGETECH_10300_10700                     = 6,    /* 10300 Hz off, 10700 Hz on */
    NUM_EDGETECH_FREQSPECS                   = 7
} edgetech_freqspec_t;


/*
*************************
 STD Commands
*************************
 Do not remove MMP_STD_CMD_RESET or updates from deck box displays may stop working
 
 cmdsect=STD

*/
typedef enum
{
    MMP_STD_CMD_INFO                         = 0x00,    /* Obtain modem build info (similar to ATI shell command) */
    MMP_STD_CMD_REMOTE_MMPREQ                = 0x01,    /* Initiate an acoustic MMP request to another modem.  Remote MMP request should be embedded in the data field (no @ sentinel needed). Not implemented on networking builds. */
    MMP_STD_CMD_FLASH_SREGS                  = 0x02,    /* Save S-registers to flash (soon to be deprecated) */
    MMP_STD_CMD_RESET_SREGS                  = 0x03,    /* Reset S-registers to factory defaults (soon to be deprecated) */
    MMP_STD_CMD_REMOTE_SETACOUBAUD           = 0x04,    /* Set acoustic baud rate on remote modem */
    MMP_STD_CMD_REMOTE_SETTXPOWER            = 0x05,    /* Set transmit power on remote modem */
    MMP_STD_CMD_REMOTE_GETSREGS              = 0x06,    /* Get S-registers from remote modem (soon to be deprecated) */
    MMP_STD_CMD_REMOTE_SENDDATA              = 0x07,    /* Send data packet to remote modem */
    MMP_STD_CMD_REMOTE_TESTLINK              = 0x08,    /* Test acoustic link with remote modem */
    MMP_STD_CMD_UPDATE_FIRMWARE              = 0x09,    /* Begin firmware update cycle */
    MMP_STD_CMD_RESET                        = 0x0A,    /* Reboot the modem */
    MMP_STD_CMD_REMOTE_GETBATT               = 0x0B,    /* Get battery levels on remote modem */
    MMP_STD_CMD_REMOTE_CMWAKEUP              = 0x0C,    /* Issue a compact modem wakeup sequence to a remote compact modem */
    MMP_STD_CMD_REMOTE_GETAGCHIST            = 0x0D,    /* Obtain the AGC history for the last 10 seconds from a remote modem */
    MMP_STD_CMD_REMOTE_AUTOBAUD              = 0x0E,    /* Initiate an auto-baud sequence to a remote modem to set an optimal acoustic baud rate between them */
    MMP_STD_CMD_REMOTE_GETBATTCHG            = 0x0F,    /* Obtain battery charge from remote units with IBPS smart batteries */
    MMP_STD_CMD_REMOTE_SENDCMD               = 0x10,    /* Send command packet to remote modem */
    MMP_STD_CMD_TILT_ACCEL                   = 0x11,    /* Obtain acceleration and tilt values for X/Y/Z axis if function supported on board.  HW_NOT_PRESENT error results if board has no accelerometer.  */
    MMP_STD_CMD_AXIS_TILT                    = 0x12,    /* Obtain overall unit tilt value based upon @TiltAxis configuration parameter.  HW_NOT_PRESENT error results if board has no accelerometer.  */
    MMP_STD_CMD_RESET_BATT_METERING          = 0x13,    /* Reset the battery metering information on this platform, if applicable. */
    MMP_STD_CMD_BATT_METER                   = 0x14,    /* Obtain metering information for the local battery, if supported */
    MMP_STD_CMD_REMOTE_GETMETER              = 0x15,    /* Get battery metering information from a remote unit, if supported */
    MMP_STD_CMD_GETBATT                      = 0x16,    /* Get battery levels from the local modem */
    MMP_STD_CMD_GETBATTCHG                   = 0x17,    /* Obtain battery charge from a local modem with IBPS smart batteries */
    MMP_STD_CMD_GETAGCHIST                   = 0x18,    /* Get the local AGC history buffer */
    MMP_STD_CMD_REMOTE_GETONESREG            = 0x19,    /* Gets the value of a single S-register on a remote modem */
    MMP_STD_CMD_REMOTE_SETONESREG            = 0x1A,    /* Sets and stores a single S-register on a remote modem; response is ACK or ERROR */
    MMP_STD_CMD_REMOTE_RESET                 = 0x1B,    /* Reset a remote modem with a low-level reset instruction (no acknowledgement from remote) */
    MMP_STD_CMD_BOARD_TEMP                   = 0x1C,    /* Obtain the board temperature from one of the built-in thermistors (one on ATM board sets, two on UDB board sets) */
    MMP_STD_CMD_REMOTE_SENDBREAK             = 0x1D,    /* Send a serial break to remote modem */
    MMP_STD_CMD_CONT_XMIT_TEST               = 0x1E,
    MMP_STD_CMD_SET_REMOTE_GROUP             = 0x1F,    /* move a remote modem's address into a new address group */
    MMP_STD_CMD_GETSMARTBATTDATA             = 0x20,    /* If smart batteries are supported, get selected parameters from the specified battery. */
    MMP_STD_CMD_ADDFEATUREKEY                = 0x21,    /* Add a feature key to the platform.  CMDRESULT ACK on success, CMDRESULT ERROR if flash store full, BAD_CMDARGS error otherwsise. */
    MMP_STD_CMD_DELFEATUREKEY                = 0x22,    /* Delete a feature key from the platform.  CMDRESULT ACK on success, BAD_CMDARGS error otherwise. */
    MMP_STD_CMD_REMOTE_HANGUP                = 0x23,    /* Send an acoustic "hangup" to a remote node that takes it out of online mode and puts it to sleep/hibernate.  ACK/timeout when sending to individual node, or immediate ACK if sending to a multi-cast address with no acoustic ACK expected. */
    MMP_STD_CMD_SENDJANUSPACKET              = 0x24,    /* Transmit a JANUS packet with pre-encoded ADB and cargo.  CMDRESULT ACK on success, CMDRESULT ERR on failure to validate, or general MMP error otherwise. */
    MMP_STD_CMD_WRITE_DEVICE                 = 0x25,    /* Write to the device */
    MMP_STD_CMD_READ_DEVICE                  = 0x26,    /* Read and clear the device */
    MMP_STD_CMD_LEN_DEVICE                   = 0x27,    /* Length of data in the device */
    MMP_STD_CMD_FIND_DEVICE                  = 0x28,    /* Find the device number from the name */
    MMP_NUM_STD_CMD                          = 0x29
} mmp_std_cmd_t;


/*
 
 subfield=mmp_remote_request_t::flags

*/
typedef enum
{
    REMOTE_MMP_FLAG_ACKONLY                  = 0x01    /* REMOTE_MMPREQ ONLY: requests a simple ACK/NACK from the remote instead of a fully-formed MMP response */
} mmp_remote_request_flag_t;


/*
 This enumeration supplements the txpower_t enumeration for the remote_txpwr parameter in mmp_remote_testmsgstats_t
 
 subfield=mmp_remote_testmsgstats_t::remote_txpwr

*/
typedef enum
{
    TXPOWER_UNAVAIL                          = 0x7FFF,    /* No power level available */
    TXPOWER_REDUCED_0DB                      = 0,    /* Reduced output 0 dB (non-standard) */
    TXPOWER_REDUCED_3DB                      = -1,    /* Reduced output -3 dB (non-standard) */
    TXPOWER_REDUCED_6DB                      = -2,    /* Reduced output -6 dB (non-standard) */
    TXPOWER_REDUCED_9DB                      = -3,    /* Reduced output -9 dB (non-standard) */
    TXPOWER_REDUCED_12DB                     = -4,    /* Reduced output -12 dB (non-standard) */
    TXPOWER_REDUCED_15dB                     = -5,    /* Reduced output -15 dB (non-standard) */
    TXPOWER_REDUCED_18dB                     = -6    /* Reduced output -18 dB (non-standard) */
} mmp_remote_testmsgstats_txpwr_t;


/*
 
 subfield=mmp_remote_battcharge_t::charge
 subfield=mmp_battcharge_t::charge

*/
typedef enum
{
    MMP_REMOTE_BATTCHG_UNAVAIL               = 0xFF    /* No battery charge information available */
} mmp_remote_battcharge_charge_t;


/*
**************************
 DATA Fields
**************************
 
 subsys=DATA

*/
typedef enum
{
    MMP_DATA_FLD_ACK                         = 0x00,    /* Data ACK from remote modem received */
    MMP_DATA_FLD_REMOTE_DATA                 = 0x01,    /* Data packet from remote modem received */
    MMP_DATA_FLD_XMIT_OVERTEMP               = 0x02,    /* Overtemp condition on transmit */
    MMP_DATA_FLD_BURN_COMPLETE               = 0x03,    /* Release burn-wire burn cycle active, tilt detected (unit release) */
    MMP_DATA_FLD_TRRC_STATUS                 = 0x04,    /* Information on T/R board and RCV module */
    MMP_DATA_FLD_FEAT_KEY_STATUS             = 0x05,    /* Information on feature authorization keys */
    MMP_DATA_FLD_REMOTE_HEADER               = 0x06,    /* Header information on packets received */
    MMP_DATA_FLD_TIMESTAMP                   = 0x07,    /* Timestamp notification for a rx or tx event */
    MMP_DATA_FLD_DOPPLER                     = 0x08,    /* Doppler speed information from tones */
    MMP_DATA_FLD_BURN_TIMEOUT                = 0x09,    /* Release burn-wire cycle timed out with no tilt */
    MMP_DATA_FLD_DIRECTIONAL                 = 0x0A,    /* (DAT ONLY) Information locally from a DAT */
    MMP_DATA_FLD_FPM_VERSION                 = 0x0B,    /* Floating point co-processor module version */
    MMP_DATA_FLD_PSK_PKT_NO_COPROC           = 0x0C,    /* Notification that a PSK packet was received but FPM coprocessor is not present/enabled. */
    MMP_DATA_FLD_LOW_POWER                   = 0x0D,    /* Notification of the modem entering or exiting low power mode */
    MMP_DATA_FLD_ACSTATS                     = 0x0E,    /* Acoustic statistics for the packet being received */
    MMP_DATA_FLD_REMOTE_DLOGBLK              = 0x0F,    /* Data packet from remote modem containing data logger data, with CRC flags */
    MMP_DATA_FLD_HEADER_ERROR                = 0x10,    /* Header received from remote modem with errors; contains acoustic statistics if header decoded, or sentinel value to indicate low SNR acquisition detected */
    MMP_DATA_FLD_NAV_STATUS                  = 0x11,    /* Status of navigation sources (location, heading, attitude) */
    MMP_DATA_FLD_RANGE_UPDATE                = 0x12,    /* Updated range to a remote node determined via acoustic communication   */
    MMP_DATA_FLD_FPM_BOOT_FAIL               = 0x13,    /* Indication of whether a floating point coprocessor that was configured to be present at boot time failed to initialize.  Will always return 0 on platforms that don't support FPM coprocessors. */
    MMP_DATA_FLD_RCV_GAIN                    = 0x14,    /* Gives the RCV module attenuator steps and total gain */
    MMP_DATA_FLD_SPECTRUM_STATUS             = 0x15,    /* Indicates activation or deactivation of the spectrum mode, along with some parameters */
    MMP_DATA_FLD_SPECTRUM_DATA               = 0x16,    /* Energy levels for frequency bins calculated during spectrum mode */
    MMP_DATA_FLD_DIRECTIONAL_DEBUG           = 0x17,    /* (DAT ONLY) Additional debug information locally from a DAT */
    MMP_DATA_FLD_TONAL_LOCATOR               = 0x18,    /* (DAT ONLY) information pertaining to ELP locator */
    MMP_DATA_FLD_DIRECTIONAL_LOCDEBUG        = 0x1A,    /* (DAT ONLY) Additional debug information locally from a DAT pertaining to ELP locator */
    MMP_DATA_FLD_JANUS_PACKET                = 0x1B,    /* JANUS data packet received */
    MMP_DATA_FLD_ACOUTRIG_COMPLETE           = 0x1C,    /* Acoustic trigger cycle completion with confirmation */
    MMP_DATA_FLD_ACOUTRIG_TIMEOUT            = 0x1D,    /* Acoustic trigger cycle complete with no confirmation (timeout) */
    MMP_DATA_FLD_RESPBUFFER_XMIT             = 0x1E,
    MMP_DATA_FLD_RNGBRG_UPDATE               = 0x1F,    /* Updated range and bearing to a remote node */
    MMP_NUM_DATA_FLD                         = 0x20
} mmp_data_fld_t;


/*
 
 subfield=mmp_data_timestamp_t::event

*/
typedef enum
{
    MMP_TIMESTAMP_EVENT_TX                   = 0,    /* TX */
    MMP_TIMESTAMP_EVENT_RX                   = 1,    /* RX */
    MMP_TIMESTAMP_EVENT_TX_SYNC              = 2    /* Captured timestamp of external Tx Sync signal */
} mmp_timestamp_event_t;


/*
 
 subfield=mmp_data_lowpower_t::lpstat

*/
typedef enum
{
    MMP_LOWPOWER_LPSTAT_EXIT                 = 0,    /* Signifies exiting low power mode */
    MMP_LOWPOWER_LPSTAT_ENTER                = 1    /* Signifies entering low power mode */
} mmp_lowpower_lpstat_t;


/*
 
 subfield=mmp_data_rangeupdate_t::range_type

*/
typedef enum
{
    MMP_RANGEUPDATE_TYPE_NULL                = 0,    /* Null/Unknown range update type */
    MMP_RANGEUPDATE_TYPE_ONEWAY              = 1,    /* One-way range, calculated via scheduled transmission from time-synchronized remote modem  */
    MMP_RANGEUPDATE_TYPE_TWOWAY              = 2    /* Two-way range, calculated via round-trip packet exchange between two modems  */
} mmp_rangeupdate_range_type_t;


/*
 
 subfield=mmp_spectrum_stat_t::stat

*/
typedef enum
{
    MMP_SPECTRUM_STAT_OFF                    = 0,    /* MMP interface exited */
    MMP_SPECTRUM_STAT_ON                     = 1,    /* MMP interface started */
    MMP_NUM_SPECTRUM_STAT                    = 2
} mmp_spectrum_stat_status_t;


/*
 
 subfield=mmp_data_janus_packet_t::schedule_type

*/
typedef enum
{
    MMP_JANUS_SCHEDULE_NONE                  = 0,    /* No scheduling present, all 34 bits may be used in the ADB. */
    MMP_JANUS_SCHEDULE_RESERVE               = 1,    /* A reserve interval is being specified according to Annex B of ANEP-87.  Up to 26 bits of ADB data are present. */
    MMP_JANUS_SCHEDULE_REPEAT                = 2    /* A repeat interval is being specified according to Annec C of ANEP-87.  Up to 26 bits of ADB data are present. */
} mmp_janus_schedule_type_t;


/*
**************************
 DECKBOX Fields
**************************
 
 subsys=DECKBOX

*/
typedef enum
{
    MMP_DECKBOX_FLD_SPKRVOL                  = 0x00,    /* Speaker volume */
    MMP_DECKBOX_FLD_PHONESVOL                = 0x01,    /* Headphones volume */
    MMP_DECKBOX_FLD_PWRSENSE                 = 0x02,    /* Power source information */
    MMP_DECKBOX_FLD_BATTLEV                  = 0x03,    /* Internal battery level (rough percentage); a "critical" battery level will trigger a spontaneous MMP notification */
    MMP_DECKBOX_FLD_BATTVOLT                 = 0x04,    /* Internal battery voltage */
    MMP_DECKBOX_FLD_MODEL                    = 0x05,    /* Deck box model */
    MMP_DECKBOX_FLD_GPS_RELAY                = 0x06,    /* GPS pass-through mode on display module (for tunneling external GPS time sync data through to modem - disables most display functions, only supported on some hardware configurations) */
    MMP_NUM_DECKBOX_FLD                      = 0x07
} mmp_deckbox_fld_t;


/*
 For use with device sub-field
 
 subfield=mmp_pwrsense_t::device

*/
typedef enum
{
    MMP_DECKBOX_PWRSENSE_DEVICE_BATT         = 0,    /* Using internal batteries */
    MMP_DECKBOX_PWRSENSE_DEVICE_AC           = 1,    /* Using external AC power */
    MMP_DECKBOX_PWRSENSE_DEVICE_AUXDC        = 2,    /* Using external DC power */
    NUM_MMP_DECKBOX_PWRSENSE_DEVICE          = 3
} mmp_deckbox_pwrsense_device_t;


/*
 For use with charge sub-field, indicates battery level while charging via external AC or DC.
 These are matched up with the _40, _80, and _100 enums in the BATTLEV_CHARGE subfield.
 
 subfield=mmp_pwrsense_t::charge

*/
typedef enum
{
    MMP_DECKBOX_PWRSENSE_CHARGE_LT80         = 2,    /* Battery less than 80% charge  */
    MMP_DECKBOX_PWRSENSE_CHARGE_GE80         = 4,    /* Battery at least 80% charged */
    MMP_DECKBOX_PWRSENSE_CHARGE_FULL         = 5,    /* Battery fully charged */
    MMP_DECKBOX_PWRSENSE_CHARGE_OFFSET       = 20    /* For use with smart batteries that can report to 1% accuracy: if the charge percentage is equal to or above this value, then subtract the offset and use the number directly. */
} mmp_deckbox_pwrsense_charge_t;


/*
 For use with charge sub-field, indicates battery level while rinning on battery.
 
 subfield=mmp_battlev_t::charge

*/
typedef enum
{
    MMP_DECKBOX_BATTLEV_CHARGE_0             = 0,    /* Battery completely drained */
    MMP_DECKBOX_BATTLEV_CHARGE_20            = 1,    /* Battery 20% charge remaining */
    MMP_DECKBOX_BATTLEV_CHARGE_40            = 2,    /* Battery 40% charge remaining */
    MMP_DECKBOX_BATTLEV_CHARGE_60            = 3,    /* Battery 60% charge remaining */
    MMP_DECKBOX_BATTLEV_CHARGE_80            = 4,    /* Battery 80% charge remaining */
    MMP_DECKBOX_BATTLEV_CHARGE_100           = 5,    /* Battery fully charged */
    MMP_DECKBOX_BATTLEV_CHARGE_CRITICAL      = 6,    /* Battery critically low, auto-shut-down impending (triggers spontaneous MMP notification) */
    NUM_MMP_DECKBOX_BATTLEV_CHARGE           = 7,
    MMP_DECKBOX_BATTLEV_CHARGE_OFFSET        = 20    /* For use with smart batteries that can report to 1% accuracy: if the charge percentage is equal to or above this value, then subtract the offset and use the number directly. */
} mmp_deckbox_battlev_charge_t;


/*
 For use with model sub-field
 
 subfield=mmp_udb_model_t::model

*/
typedef enum
{
    MMP_DECKBOX_MODEL_UNKNOWN                = 0,    /* Unknown deck box model */
    MMP_DECKBOX_MODEL_MODEM                  = 1,    /* UTS/UDB M variant, fully featured */
    MMP_DECKBOX_MODEL_RELEASE                = 2,    /* UTS/UDB A variant, acoustic releases only */
    MMP_DECKBOX_MODEL_MODEM_L3               = 3,    /* UDB-9000L3 special */
    MMP_DECKBOX_MODEL_MODEM_SW               = 4,    /* UDB-9000SW special */
    MMP_DECKBOX_MODEL_MODEM_EXPORT           = 5,    /* UTS/UDB E variant export model (no multi-frequency transpond receive) */
    MMP_DECKBOX_MODEL_MODEM_BONITO           = 6,    /* UTS/UDB-9400BN modem-enabled with BONITO Open Network Interface to Off-board systems (BONITO) */
    MMP_DECKBOX_MODEL_MODEM_DR               = 7,    /* UDB-9000DR modem-enabled with Data Recorder (OBSOLETE) */
    MMP_DECKBOX_MODEL_MODEM_NR               = 8,    /* UDB-9000NR modem-enabled with NUWC Ranging */
    MMP_DECKBOX_MODEL_MODEM_BN               = 9,    /* UDB-9400BN modem enabled with Benthonet networking */
    MMP_DECKBOX_MODEL_MODEM_LITE             = 10,    /* UTS ML variant, fully featured with "lite" UI */
    MMP_DECKBOX_MODEL_MODEM_EXPORT_LITE      = 11,    /* UTS EL variant, export model with "lite" UI (no multi-frequency transpond receive) */
    MMP_DECKBOX_MODEL_RELEASE_LITE           = 12,    /* UTS AL variant, acoustic release only with "lite" UI */
    MMP_DECKBOX_MODEL_ROPELESS_FISHING       = 13,    /* UTS RF variant, for ropeless fishing applications */
    NUM_MMP_DECKBOX_MODEL                    = 14
} mmp_deckbox_model_t;


/*
 
 subfield=mmp_gps_relay_t::status

*/
typedef enum
{
    MMP_DECKBOX_GPS_RELAY_DISABLED           = 0,
    MMP_DECKBOX_GPS_RELAY_ENABLED            = 1
} mmp_gps_relay_mode_t;


/*
**************************
 HWCTL Fields
**************************
 events in this subsystem are interface-specific (only go to inducing interface)
 
 subsys=HWCTL

*/
typedef enum
{
    MMP_HWCTL_FLD_BINOUT0                    = 0x00,    /* Set or read the level of binary output 0 */
    MMP_HWCTL_FLD_BINOUT1                    = 0x01,    /* Set or read the level of binary output 1 */
    MMP_HWCTL_FLD_BININ0                     = 0x10,    /* Read the level of binary input 0 */
    MMP_HWCTL_FLD_BININ1                     = 0x11    /* Read the level of binary input 1 */
} mmp_hwctl_fld_t;


/*
 
 subfield=mmp_xdcr_switch_t::which

*/
typedef enum
{
    XDCR_UPPER                               = 0,    /* Upper (top) transducer */
    XDCR_LOWER                               = 1    /* Lower (bottom) transducer */
} mmp_xdcr_swtich_value_t;


/*
**************************
 IFACE Fields
**************************
 events in this subsystem are interface-specific (only go to inducing interface)
 
 subsys=IFACE

*/
typedef enum
{
    MMP_IFACE_FLD_MMPSTAT                    = 0x00,    /* Status of MMP subsystem */
    MMP_IFACE_FLD_ERR                        = 0x01,    /* MMP error notification */
    MMP_IFACE_FLD_VERSION                    = 0x02,    /* Version of MMP protocol running */
    MMP_IFACE_FLD_CMDRESULT                  = 0x03,    /* MMP command (EXECUTE) result notification */
    MMP_IFACE_FLD_BLOCKNOTIFY                = 0x04,    /* Block spontaneous notifications from one or more subsystems.  Used with SET, provide a variable length list of subsystems to block.  Returns a variable-length list of blocked subsystems.  Note that responses will always be received when induced by a direct SET/CMD on an interface even if the subsystem is blocked; this only filters spontaneous notifies.  */
    MMP_IFACE_FLD_UNBLOCKNOTIFY              = 0x05,    /* Allow spontaneous notifications from one or more subsystems.  Used with SET, provide a variable-length list of subsystems to unblock.  Returns a variable-length list of unblocked subsystems.  */
    MMP_IFACE_FLD_DSP_SW_VERSION             = 0x06,    /* DSP firmware version currently running */
    MMP_IFACE_FLD_PRIVLEV                    = 0x07,    /* Privilege level on this MMP interface (requires password only if elevating from current privlev) */
    MMP_IFACE_FLD_REMOTE_MMPRESP             = 0x08,
    MMP_IFACE_FLD_FEATURE_KEY                = 0x09,    /* temporarily enable a feature key */
    MMP_IFACE_FLD_UNIT_SERNO                 = 0x0A,    /* Obtain the assembly serial number */
    MMP_IFACE_FLD_NTFY_COUNT                 = 0x0B,    /* Enable, disable, or query the status of appended notification counter (unique on a per-interface basis) */
    MMP_IFACE_FLD_NTFY_CKSUM                 = 0x0C,    /* Enable, disable, or query the status of appended notification XOR checksum */
    MMP_IFACE_FLD_AES_USER_KEY               = 0x0D,    /* Set an AES user key for use with encrypted code images, along with an optional timeout.  If 0xFFFF is provided for the timeout value, the AES key and auto-clear timeouts are cleared.  An INVALID_STATE error will result if an attempt is made to install a new key over an existing one without first clearing it. */
    MMP_IFACE_FLD_COMPATIBILITY              = 0x0E,    /* A compatibility number used for syncing external controllers (such as ReleaseIT display) with a given range of software version.  This number may vary by platform and is intended primarily for Teledyne use. */
    MMP_IFACE_FLD_FEATURE_KEY_INVENTORY      = 0x0F,    /* Get the inventory of installed feature keys */
    MMP_IFACE_FLD_GATE_DATA_DIRECTIONAL      = 0x10,    /* (DAT ONLY) Suppress output of DATA::DIRECTIONAL notify when vector is below vthesh. */
    MMP_NUM_IFACE_FLD                        = 0x11
} mmp_iface_fld_t;


/*
 
 subfield=mmp_iface_stat_t::stat

*/
typedef enum
{
    MMP_IFACE_STAT_EXITED                    = 0,    /* MMP interface exited */
    MMP_IFACE_STAT_STARTED                   = 1,    /* MMP interface started */
    MMP_NUM_IFACE_STAT                       = 2
} mmp_iface_stat_status_t;


/*
 
 subfield=mmp_sfl_err_t::err

*/
typedef enum
{
    MMP_IFACE_ERR_NULL                       = 0x00,    /* Null error code */
    MMP_IFACE_ERR_TIMEOUT                    = 0x01,    /* Operation has timed out */
    MMP_IFACE_ERR_BAD_SUBSYS                 = 0x02,    /* Bad subsystem in GET/SET request */
    MMP_IFACE_ERR_BAD_FIELD                  = 0x03,    /* Bad field in GET/SET request */
    MMP_IFACE_ERR_BAD_VALUE                  = 0x04,    /* Bad value in GET/SET request */
    MMP_IFACE_ERR_PARSE                      = 0x05,    /* Error parsing serial stream */
    MMP_IFACE_ERR_BAD_CMDSECT                = 0x06,    /* Bad command section in EXEC request */
    MMP_IFACE_ERR_BAD_CMD                    = 0x07,    /* Bad command in EXEC request */
    MMP_IFACE_ERR_BAD_CMDARGS                = 0x08,    /* Bad arguments to command in EXEC request */
    MMP_IFACE_ERR_MULTICMD                   = 0x09,    /* More than one EXEC operation in single transaction */
    MMP_IFACE_ERR_DEVICE_BUSY                = 0x0A,    /* Modem too busy to process request */
    MMP_IFACE_ERR_NOTIFY_ONLY                = 0x0B,    /* Field not accessible with GET/SET, spontaneous NOTIFY only */
    MMP_IFACE_ERR_NO_RESOURCE                = 0x0C,    /* Resources not available to process request */
    MMP_IFACE_ERR_UNMODIFIABLE               = 0x0D,    /* Value may not be modified with a SET */
    MMP_IFACE_ERR_PERMISSION                 = 0x0E,    /* Insufficient permission level to carry out operation */
    MMP_IFACE_ERR_INVALID_STATE              = 0x0F,    /* The modem is not in a state that can validly process the request */
    MMP_IFACE_ERR_FEAT_NOT_ENABLED           = 0x10,    /* The requested operation requires feature key activation, but the key is not installed */
    MMP_IFACE_ERR_NOT_IMPLEMENTED            = 0x11,    /* The requested operation is recognized but is not yet implemented in the MMP engine */
    MMP_IFACE_ERR_HW_NOT_PRESENT             = 0x12,    /* The requested operation relies on hardware that is either not present on the board or did not initialize properly */
    MMP_IFACE_ERR_DB_LOCKED                  = 0x13,    /* An attempt to modify a database (like the configuration) was disallowed because it is in a locked state */
    MMP_IFACE_ERR_ACOU_DISALLOWED            = 0x14,    /* The modification attempt cannot be performed acoustically */
    MMP_IFACE_ERR_SET_ONLY                   = 0x15,    /* The field may only be SET, and not queried with a GET operation */
    MMP_NUM_IFACE_ERR                        = 0x16
} mmp_iface_err_t;


/*
 CMDRESULT message types.  Note that all errors and mmp_exec_notify() calls will clear the current MMP
 exec information with the exception of the CMD_STARTED and PROGRESS command result message types.
 
 subfield=mmp_cmd_result_t::message

*/
typedef enum
{
    MMP_CMDRESULT_ERROR                      = 0,    /* An error occurred - clears current execution data */
    MMP_CMDRESULT_CMD_ACK                    = 1,    /* Action completed successfully - clears current execution data */
    MMP_CMDRESULT_CMD_STARTED                = 2,    /* Action/mode has started - should be followed by CMD_ENDED and does not automatically clear the current execution data */
    MMP_CMDRESULT_CMD_ENDED                  = 3,    /* Action/mode has ended - clears current execution data */
    MMP_CMDRESULT_DATA                       = 4,    /* Data is being returned from the command.  The standard CMDRESULT header will be followed by a command-specific set of result data.  Clears current execution data. */
    MMP_CMDRESULT_TIMEOUT                    = 5,    /* Command ended with a timeout condition - clears current execution data */
    MMP_CMDRESULT_PROGRESS                   = 6,    /* Command is progressing with more messages forthcoming.  Like CMDRESULT_DATA, it may be followed by more information.  Does not automatically clear the current execution data. */
    MMP_CMDRESULT_REMOTE_ERROR               = 7,    /* Remotely executed MMP operation contains one or more error conditions */
    MMP_CMDRESULT_REMOTE_TIMEOUT             = 8,    /* Remotely executed MMP operation timed out */
    MMP_CMDRESULT_REMOTE_DENIED              = 9,    /* Remotely executed MMP operation disallowed due to locking, permissions, etc. */
    MMP_NUM_CMDRESULT                        = 10
} mmp_cmdresult_msg_t;


/*
**************************
 SREG Fields
**************************
 
 subsys=SREG

*/
typedef enum
{
    MMP_SREG_FLD_VERSION                     = 0,    /* DSP SW version */
    MMP_SREG_FLD_POSACK                      = 2,    /* Positive acknowledgements */
    MMP_SREG_FLD_SERBAUD                     = 3,    /* Serial port baud & configuration */
    MMP_SREG_FLD_ACOUBAUD                    = 4,    /* Acoustic baud rate */
    MMP_SREG_FLD_TXPOWER                     = 6,    /* Transmit power */
    MMP_SREG_FLD_RESPTIMEOUT                 = 7,    /* Acoustic response timeout */
    MMP_SREG_FLD_FWDDELAY                    = 8,    /* Packet forwarding delay */
    MMP_SREG_FLD_COPROC                      = 9,    /* PSK coprocessor enable/status */
    MMP_SREG_FLD_LPTIMEOUT                   = 10,    /* Low-power idle timeout */
    MMP_SREG_FLD_FLOWCTRL                    = 11,    /* Serial port flow control */
    MMP_SREG_FLD_TESTMSGLEN                  = 12,    /* Acoustic test message length */
    MMP_SREG_FLD_VERBOSITY                   = 13,    /* Console message verbosity */
    MMP_SREG_FLD_REMADDR                     = 14,    /* Default remote modem address */
    MMP_SREG_FLD_LOCADDR                     = 18,    /* Local modem address */
    MMP_SREG_FLD_RXTHRESHOLD                 = 21,    /* Receive sensitivity threshold for transpond pings */
    MMP_SREG_FLD_BAND                        = 24,    /* Acoustic band */
    MMP_SREG_FLD_TXPULSEWIDTH                = 32,    /* Transpond interrogation ping pulse width */
    MMP_SREG_FLD_RXPULSEWIDTH                = 33,    /* Transpond received ping pulse width */
    MMP_SREG_FLD_TAT                         = 40,    /* Transponder/ranging turn-around time */
    MMP_SREG_FLD_PPSSYNC                     = 49,    /* Internal/external 1 PPS time sync mode */
    MMP_SREG_FLD_RXFREQ                      = 53,    /* Transpond ping receive frequency (only for units that can't receive multiple frequencies) */
    MMP_SREG_FLD_XPNDLOCKOUT                 = 55,    /* Transpond ping lockout time */
    MMP_SREG_FLD_ALL                         = 255    /* Use to SET/GET all S-registers at once */
} mmp_sreg_fld_t;


/*
 SREG subsys - field BAND
 
 subfield=mmp_sreg_fld_val_t::val

*/
typedef enum
{
    MMP_SREG_BAND_LF                         = 56,    /* LF band */
    MMP_SREG_BAND_MF                         = 100,    /* MF band */
    MMP_SREG_BAND_C                          = 141,    /* C band */
    MMP_SREG_BAND_HF                         = 156    /* HF band */
} mmp_sreg_band_t;


/*
 SREG subsys - field TESTMSGLEN
 
 subfield=mmp_sreg_fld_val_t::val

*/
typedef enum
{
    MMP_SREG_TESTMSGLEN_8                    = 0,    /* 8 byte test message */
    MMP_SREG_TESTMSGLEN_32                   = 1,    /* 32 byte test message */
    MMP_SREG_TESTMSGLEN_128                  = 2,    /* 128 byte test message */
    MMP_SREG_TESTMSGLEN_256                  = 3,    /* 256 byte test message */
    MMP_SREG_TESTMSGLEN_512                  = 4,    /* 512 byte test message */
    MMP_SREG_TESTMSGLEN_1024                 = 5,    /* 1024 byte test message */
    MMP_SREG_TESTMSGLEN_2048                 = 6,    /* 2048 byte test message */
    MMP_SREG_TESTMSGLEN_4096                 = 7    /* 4096 byte test message */
} mmp_sreg_testmsglen_t;


/*
**************************
 TIME Fields
**************************
 events in this subsystem are interface-specific (only go to inducing interface)
 
 subsys=TIME

*/
typedef enum
{
    MMP_TIME_FLD_1PPS_PULSE                  = 0x00,    /* (currently unsupported) Arrival of 1 PPS synchronization pulse */
    MMP_TIME_FLD_TIMEDATE                    = 0x01,    /* The time and date on the modem's clock */
    MMP_TIME_FLD_DSTPARMS                    = 0x02,    /* (currently unsupported) Parameters governing Daylight Savings Time adjustments of local time */
    MMP_TIME_FLD_RTCBATT                     = 0x03,    /* Battery level on modem's clock */
    MMP_TIME_FLD_SYNCINFO                    = 0x04,    /* Synchronization status of the modem to an accurate 1PPS reference (internal or external) and timestamping information (e.g., $GPZDA messages) */
    MMP_NUM_TIME_FLD                         = 0x05
} mmp_time_fld_t;


/*
**************************
 TRANSPOND Fields
**************************
 
 subsys=TRANSPOND

*/
typedef enum
{
    MMP_TRANSPOND_FLD_STAT                   = 0x00,    /* Transpond mode status */
    MMP_TRANSPOND_FLD_PINGRCVD               = 0x01,    /* Transpond ping received */
    MMP_TRANSPOND_FLD_CHNLRXADJ_0            = 0x02,    /* Receive sensitivity adjustment for channel 0 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_1            = 0x03,    /* Receive sensitivity adjustment for channel 1 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_2            = 0x04,    /* Receive sensitivity adjustment for channel 2 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_3            = 0x05,    /* Receive sensitivity adjustment for channel 3 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_4            = 0x06,    /* Receive sensitivity adjustment for channel 4 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_5            = 0x07,    /* Receive sensitivity adjustment for channel 5 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_6            = 0x08,    /* Receive sensitivity adjustment for channel 6 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_7            = 0x09,    /* Receive sensitivity adjustment for channel 7 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_8            = 0x0A,    /* Receive sensitivity adjustment for channel 8 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_9            = 0x0B,    /* Receive sensitivity adjustment for channel 9 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_10           = 0x0C,    /* Receive sensitivity adjustment for channel 10 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_11           = 0x0D,    /* Receive sensitivity adjustment for channel 11 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_12           = 0x0E,    /* Receive sensitivity adjustment for channel 12 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_13           = 0x0F,    /* Receive sensitivity adjustment for channel 13 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_14           = 0x10,    /* Receive sensitivity adjustment for channel 14 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_15           = 0x11,    /* Receive sensitivity adjustment for channel 15 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_16           = 0x12,    /* Receive sensitivity adjustment for channel 16 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_17           = 0x13,    /* Receive sensitivity adjustment for channel 17 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_18           = 0x14,    /* Receive sensitivity adjustment for channel 18 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_19           = 0x15,    /* Receive sensitivity adjustment for channel 19 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_20           = 0x16,    /* Receive sensitivity adjustment for channel 20 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_21           = 0x17,    /* Receive sensitivity adjustment for channel 21 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_22           = 0x18,    /* Receive sensitivity adjustment for channel 22 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_23           = 0x19,    /* Receive sensitivity adjustment for channel 23 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_24           = 0x1A,    /* Receive sensitivity adjustment for channel 24 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_25           = 0x1B,    /* Receive sensitivity adjustment for channel 25 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_26           = 0x1C,    /* Receive sensitivity adjustment for channel 26 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_27           = 0x1D,    /* Receive sensitivity adjustment for channel 27 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_28           = 0x1E,    /* Receive sensitivity adjustment for channel 28 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_29           = 0x1F,    /* Receive sensitivity adjustment for channel 29 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_30           = 0x20,    /* Receive sensitivity adjustment for channel 30 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_31           = 0x21,    /* Receive sensitivity adjustment for channel 31 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_32           = 0x22,    /* Receive sensitivity adjustment for channel 32 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_33           = 0x23,    /* Receive sensitivity adjustment for channel 33 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_34           = 0x24,    /* Receive sensitivity adjustment for channel 34 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_35           = 0x25,    /* Receive sensitivity adjustment for channel 35 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_36           = 0x26,    /* Receive sensitivity adjustment for channel 36 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_37           = 0x27,    /* Receive sensitivity adjustment for channel 37 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_38           = 0x28,    /* Receive sensitivity adjustment for channel 38 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_39           = 0x29,    /* Receive sensitivity adjustment for channel 39 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_40           = 0x2A,    /* Receive sensitivity adjustment for channel 40 */
    MMP_TRANSPOND_FLD_CHNLRXADJ_ALL          = 0x2B,    /* Set or get all receive channel sensitivity adjustments at once */
    MMP_NUM_TRANSPOND_FLD                    = 0x2C
} mmp_transpond_fld_t;


/*
 
 subfield=mmp_transpond_stat_t::stat

*/
typedef enum
{
    MMP_TRANSPOND_STAT_IDLE                  = 0,    /* Modem is not listening for transpond pings */
    MMP_TRANSPOND_STAT_ACTIVE                = 1,    /* Modem is listening for transpond receive pings for a finite period of time */
    MMP_TRANSPOND_STAT_CONTINUOUS            = 2,    /* Modem is continually listening for transpond receive pings */
    MMP_NUM_TRANSPOND_STAT                   = 3
} mmp_transpond_stat_status_t;


/*
 
 subfield=mmp_transpond_pingrcvd_t::flags  (each flag may be set independently)

*/
typedef enum
{
    MMP_TRANSPOND_PINGRCVD_FLAG_RESIDUAL     = 0x01    /* This ping is measured against an earlier interrogation and not a new one about to depart. */
} mmp_transpond_pingrcvd_flag_t;


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
typedef enum
{
    MODSPEC_NULL                             = 0,    /* Null modspec value */
    MODSPEC_80_STDFH                         = 1,    /* 80 bps FH */
    MODSPEC_140_MFSK                         = 2,    /* 140 bps MFSK */
    MODSPEC_300_MFSK                         = 3,    /* 300 bps MFSK */
    MODSPEC_600_MFSK                         = 4,    /* 600 bps MFSK */
    MODSPEC_800_MFSK                         = 5,    /* 800 bps MFSK */
    MODSPEC_1066_MFSK                        = 6,    /* 1066 bps MFSK */
    MODSPEC_1200_MFSK                        = 7,    /* 1200 bps MFSK */
    MODSPEC_2400_MFSK                        = 8,    /* 2400 bps MFSK */
    MODSPEC_2560_PSK                         = 9,    /* 2560 bps PSK */
    MODSPEC_5120_PSK                         = 10,    /* 5120 bps PSK */
    MODSPEC_7680_PSK                         = 11,    /* 7680 bps PSK */
    MODSPEC_10240_PSK                        = 12,    /* 10240 bps PSK */
    MODSPEC_15360_PSK                        = 13,    /* 15360 bps PSK */
    MODSPEC_80_WHFH                          = 64,
    MODSPEC_80_MRFH                          = 65,
    MODSPEC_160_MAFH                         = 66,
    MODSPEC_80_MAFH                          = 67,
    MODSPEC_80_JAFH                          = 68,
    NUM_MODSPEC                              = 19
} modspec_t;


/*
ACK codes
 
 subfield=mmp_data_ack_t::ack
 subfield=mmp_rngrls_cmdresult_release_response_t::status

*/
typedef enum
{
    OK                                       = 0,    /* Operation successful */
    BUFFER_EMPTY                             = 1,    /* Nothing in data logger */
    BLOCK_EMPTY                              = 2,    /* Nothing in requested block of data logger */
    INVALID_SETTING                          = 3,    /* Invalid setting */
    INVALID_RELEASE_CODE                     = 4,    /* Invalid release code */
    GOOD_RELEASE                             = 5,    /* Mechanical release successful */
    VALID_RELEASE_CODE                       = 6,    /* Received valid release code, activating motor */
    NOT_RELEASED                             = 7,    /* Unit not released */
    BUSY                                     = 8,    /* Unit busy */
    VALID_RELEASE_CODE_BURN                  = 9,    /* Received valid release code, beginning burn wire burn cycle */
    GOOD_BURN_RELEASE                        = 10,    /* Burn wire burn cycle completed successfully */
    BURN_RELEASE_TIMEOUT                     = 11,    /* Burn wire burn cycle stopped due to timeout, no tilt detected */
    SREG_SAVED                               = 12,    /* Remote S-register saved */
    DATALOG_NOT_SUPPORTED                    = 13,    /* Datalogger not supported on this unit */
    DATALOG_ERASE_STARTED                    = 14,    /* Datalogger erase started */
    INVALID_ACOUSTIC_TRIGGER_CODE            = 15,    /* Invalid trigger code */
    VALID_ACOUSTIC_TRIGGER_CODE              = 16,    /* Received valid acoustic trigger code, asserting signal */
    ACOUSTIC_TRIGGER_CONFIRMED               = 17,    /* Acoustic trigger confirmed (signal may or may not be de-asserted depending on configuration) */
    ACOUSTIC_TRIGGER_TIMEOUT                 = 18    /* Acoustic trigger timed out with no confirmation, signal de-asserted */
} ack_code_t;


/*
 
 subfield=mmp_rngrls_cmdresult_release_status_t::status

*/
typedef enum
{
    RLSSTAT_STD_MODEM                        = 0,    /* Standard modem, no release capability */
    RLSSTAT_CONFIRMED                        = 1,    /* Release triggered and confirmed */
    RLSSTAT_NOT_CONFIRMED                    = 2,    /* Release triggered and not confirmed */
    RLSSTAT_ARMED                            = 3,    /* Release armed and ready to accept release code */
    RLSSTAT_BURNWIRE_ACTIVATED               = 4,    /* Release burn wire burn cycle is active */
    RLSSTAT_BURNWIRE_CONFIRMED               = 5,    /* Release burn wire burn cycle triggered, tilt sensor triggered */
    RLSSTAT_BURNWIRE_TIMEOUT                 = 6,    /* release burn wire burn cycle timed out, no tilt detected */
    RLSSTAT_BURNWIRE_ARMED                   = 7,    /* New (4G) status to differentiate armed burn wire units from mech releases */
    RLSSTAT_RSERIES_ARMED                    = 16,    /* Next-Gen Release armed */
    RLSSTAT_RSERIES_CONFIRMED                = 17,    /* Next-Gen Release triggered and confirmed */
    RLSSTAT_RSERIES_NOT_CONFIRMED            = 18,    /* Next-Gen release triggered and not confirmed */
    RLSSTAT_ACOUTRIG_NOT_ASSERTED            = 19,    /* Acoustic trigger signal not asserted */
    RLSSTAT_ACOUTRIG_ASSERTED                = 20,    /* Acoustic trigger signal asserted */
    RLSSTAT_ACOUTRIG_CONFIRMED               = 21,    /* Acoustic trigger signal confirmed and de-asserted */
    RLSSTAT_ACOUTRIG_ASSERTED_CONFIRMED      = 22,    /* Acoustic trigger signal confirmed and still asserted */
    RLSSTAT_ACOUTRIG_TIMEOUT                 = 23,    /* Acoustic trigger signal not confirmed and de-asserted */
    NUM_RLSSTAT                              = 24
} rls_status_code_t;


/*
 
 subfield=mmp_rngrls_cmdresult_release_status_t::battery

*/
typedef enum
{
    BATTERY_GOOD                             = 0,    /* Battery voltage is good */
    BATTERY_LOW                              = 1,    /* Battery voltage is low */
    BATTERY_REDUCED                          = 2,    /* Battery voltage reduced */
    BATTERY_CHARGE_BASE                      = 20,    /* Values between 20 and 120 are the charge status in percent remaining, offset by 20 */
    BATTERY_VOLT_BASE                        = 125    /* Values between 125 and 245 are the battery voltage in 0.5 volt increments (0 - 60 V range) */
} battery_status_t;


/*
 
 subfield=mmp_rngrls_cmdresult_release_status_t::tilt

*/
typedef enum
{
    RLS_NOT_TILTED                           = 0,    /* The release unit is upright */
    RLS_TILTED                               = 1,    /* The release unit is tilted */
    RLS_TILT_EXCESS_MOTION                   = 2,    /* The tilt value could not be read because the sensor was moving too much */
    RLS_TILT_HW_NOT_READY                    = 3,    /* Error attempting to read tilt-sensing hardware */
    RLS_DEGREE_BASE                          = 20,    /* Values between 20 and 200 are the tilt measurement in degrees, offset by 20; subtract RLS_DEGREE_BASE to obtain the true measurement */
    RLS_TILT_COMPACT                         = 254,    /* The release unit is a Compact Release with no tilt sensor */
    RLS_TILT_OEMBOARDSET                     = 255
} tilt_status_t;


/*
 The positional state of continuous (one-way) relase motors such as Compact Release and ARM6K
 
 subfield=mmp_data_rls_cmotor_status_t::status

*/
typedef enum
{
    CMOTOR_TIMEOUT                           = -1,    /* The motor has timed out without reaching a known position and is stopped */
    CMOTOR_RUNNING                           = 0,    /* The motor is energized and turning */
    CMOTOR_LATCHED                           = 1,    /* The motor has reached its armed/latched position */
    CMOTOR_RELEASED                          = 2,    /* The motor has reached its release position */
    CMOTOR_INVALID                           = 3    /* Invalid state where both sense switches are active at the same time (should not happen!) */
} cmotor_release_stat_t;


/*
 Transmit power enums
 
 subfield=mmp_sreg_fld_val_t::val
 subfield=mmp_remote_settxpower_t::txpower
 subfield=mmp_network_ping_t::pwrlev
 subfield=mmp_swcmd_netcfgstart_t::txpower
 subfield=mmp_remote_testmsgstats_t::remote_txpwr

*/
typedef enum
{
    TXPOWER_MIN                              = 1,
    TXPOWER_21DB                             = 1,    /* -21 dB */
    TXPOWER_18DB                             = 2,    /* -18 dB */
    TXPOWER_15DB                             = 3,    /* -15 dB */
    TXPOWER_12DB                             = 4,    /* -12 dB */
    TXPOWER_9DB                              = 5,    /* -9 dB */
    TXPOWER_6DB                              = 6,    /* -6 dB */
    TXPOWER_3DB                              = 7,    /* -3 dB */
    TXPOWER_MAX                              = 8,    /* 0 dB (full transmit power) */
    LEVEL_SILENT_PING                        = 255
} txpower_t;


/*
 Maximum SPL enums
 
 subfield=mmp_sreg_fld_val_t::val

*/
typedef enum
{
    TXATTEN_0DB                              = 0,    /* Full transmit power */
    TXATTEN_24DB                             = 1    /* (approximately) 24 dB attenuation */
} txatten_t;


/*
 
 subfield=mmp_remote_autobaud_t::set_flags
 subfield=mmp_remote_autobaud_result_t::set_flags

*/
typedef enum
{
    AUTOBAUD_LOCAL_SET                       = 0x01,    /* When set, causes the the local modem to set its own transmission baud rate to the best one found */
    AUTOBAUD_REMOTE_SET                      = 0x02
} autobaud_set_flags_t;


/*
 Layer 2 commands
 
 subfield=mmp_data_remote_header_t::type
*************************

*/
typedef enum
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
} std_layer2_command_t;


/*
 
 subfield=mmp_time_syncinfo_t::pps_state

*/
typedef enum
{
    PPS_NO_SYNC                              = 0,    /* Not synchronized to a 1PPS source, awaiting qualification of a source */
    PPS_PULSE_SYNC                           = 1,    /* Locked to a 1PPS source following qualification */
    PPS_COAST_MODE                           = 2,    /* Coasting based on compiled statistics after having been locked to an erstwhile 1PPS source */
    PPS_DISABLED_SYNC                        = 3    /* Synchronization to a 1PPS source has been manually disabled */
} pps_sync_state_t;


/*
 
 subfield=mmp_time_syncinfo_t::time_sync

*/
typedef enum
{
    TSS_NO_CHANGE                            = -1,
    TSS_OUT_OF_SYNC                          = 0,    /* Time has not been set */
    TSS_NORM_IN_SYNC                         = 1,    /* Time is set */
    TSS_EXT_READY_TIME_UPDATE                = 2,    /* Waiting to receive an external timestamp (non-standard applications only) */
    TSS_EXT_TIME_RECEIVED                    = 3    /* External timetstamp received (non-standard applications only) */
} tss_state_t;


/*
 
 subfield=mmp_rngrls_geopro_param_t::cmdtype

*/
typedef enum
{
    GEOPRO_CMD_ENABLE                        = 0,
    GEOPRO_CMD_RELEASE                       = 1,
    GEOPRO_CMD_RESET                         = 2
} geopro_cmd_t;


/*
 
 subfield=mmp_rngrls_xpnd_param_t::xpnd_mode

*/
typedef enum
{
    IO_TONE_MODE_NONE                        = 0,
    IO_TONE_MODE_TONE                        = 1,
    IO_TONE_MODE_HPR400                      = 2
} io_tone_mode_type_t;


/*
 

*/
typedef enum
{
    UDB_VERSION_MAJOR                        = 8,
    UDB_VERSION_MINOR                        = 15,
    UDB_VERSION_REVISION                     = 3
} udb_version_num_t;


/*
 
 Common header for GET/SET/EXECUTE/NOTIFY packets

*/
typedef struct
{
	unsigned char xid:8;     /* MMP transaction ID:  0 is the null XID and used for all spontaneous notifies, while 1-255 are used to track requests and their corresponding responses. */
	unsigned char type:8;     /* MMP operation type: get, set, exec, or notify */
	unsigned char nparms:8;     /* The number of parameter groups contained in this MMP message */
} mmp_gsxn_t;


/*
 
 Specifier for system/field/len use with GET/SET/NOTIFY packets

*/
typedef struct
{
	unsigned char subsys:8;     /* The subsystem or command section of this parameter group */
	unsigned char field:8;     /* The field or command within the subsystem/command section of this parameter group */
	unsigned char len_msb:8;     /* The most significant byte of the body length of this parameter group */
	unsigned char len_lsb:8;     /* The least significant byte of the body length of this parameter group */
} mmp_sfl_t;


/*
 Used for any command that takes a single remote modem address as an argument
 commands REMOTE_GETSREGS, REMOTE_TESTLINK, etc. (request)
------------------------------
 
 cmd=STD::REMOTE_GETSREGS
 cmd=STD::REMOTE_TESTLINK
 cmd=STD::REMOTE_GETBATT
 cmd=STD::REMOTE_CMWAKEUP
 cmd=STD::REMOTE_GETAGCHIST
 cmd=STD::REMOTE_GETBATTCHG
 cmd=STD::REMOTE_GETMETER
 cmd=STD::REMOTE_RESET
 cmd=STD::REMOTE_HANGUP

*/
typedef struct
{
	uint16_t modem_ID;     /* Address of remote modem to query */
} mmp_remote_t;


/*
 Use for any command that takes a single remote modem address as an argument, where that address may be
 0xFFFF to indicate the local modem.  The only difference from mmp_remote_t is the comment for documentation
 purposes.
------------------------------
 
 cmd=DATALOG::CLEAR
 cmd=DATALOG::SIZE

*/
typedef struct
{
	uint16_t modem_ID;     /* Address of remote modem to query, or 0xFFFF to query the local modem */
} mmp_remote_or_local_t;


/*
 
 cmd=SWCMD::LOADROUTES
 cmd=SWCMD::SAVEROUTES

*/
typedef struct
{
	int16_t len;     /* Length of a file or device pathname in characters */
	char path[1];     /* File or device pathname, packed into len bytes [sizevar=len] */
} mmp_pathname_t;


/*
 This struct is computed from a battery_rec_t record using config params and other factors from the local
 environment
 
 cmdresult=STD::BATT_METER
 cmdresult=STD::REMOTE_GETMETER

*/
typedef struct
{
	uint32_t time;     /* Time of last update (2s granularity) */
	uint32_t rxactive_sec_x10;     /* Tenths of a second spent in active receive mode */
	uint32_t txactive_wattsec_x10;     /* Watt-tenths-of-a-second spend in active transmit mode */
	uint32_t lpactive_sec;     /* Seconds spent in low power sleep mode */
	uint32_t hibactive_sec;     /* Seconds spent in hibernate mode */
	uint32_t age_factor_x10K;     /* The multiplier to derate the battery for the effects of age, in 0.0001 units (10K) */
	uint32_t run_age_x10K;     /* Number of months the unit has been deployed, in 0.0001 units (10K) */
	uint32_t watt_hours_extracted_x1000;     /* Watt-hours extracted from the battery pack, in 0.001 units (1K) */
	uint16_t tot_age;     /* Number of months since battery manufacture */
	int16_t mfg_date;     /* Month of manufacture, offset from 01/2000 */
	int16_t capacity;     /* Total capacity of the battery, in watt-hours */
	int16_t pct_remaining_x10;     /* Percentage of camacity remaining, in tenths of % */
	int16_t voltage[2];     /* Array of most recent voltage samples */
	int16_t temp_C_x10;     /* Most recent temperature sample from T/R thermistor */
	int16_t addr;     /* Address of the node this metering data pertains to */
} battery_metering_info_t;


/*
*************************
 DATALOG Command Structs & Values
*************************
 command READ_DATA
------------------------------
 
 cmd=DATALOG::READ_DATA
 cmd=DATALOG::READ_SECTOR
 cmd=DATALOG::READ_PAGE

*/
typedef struct
{
	uint16_t modem_ID;     /* remote modem address or 0xFFFF for local */
	uint16_t number;     /* size in bytes, or page/sector number */
} mmp_datalog_read_t;


/*
 command WRITE_DATA
------------------------------
 
 cmd=DATALOG::WRITE_DATA

*/
typedef struct
{
	uint16_t modem_ID;     /* remote modem address or 0xFFFF for local */
	uint16_t bytes;     /* Number of bytes to be written */
	char data[1];     /* data to be written [sizevar=bytes] */
} mmp_datalog_write_t;


/*
 command SEEK
------------------------------
 
 cmd=DATALOG::SEEK

*/
typedef struct
{
	uint32_t pointer;     /* position in bytes from start of logger */
} mmp_datalog_seek_t;


/*
 command FIND
------------------------------
 
 cmd=DATALOG::FIND

*/
typedef struct
{
	uint16_t size;     /* Size of the query, in characters */
	char query[1];     /* Arbitrary-length record query, using same syntax as would be used with 'dlfind' command [sizevar=size] */
} mmp_datalog_find_t;


/*
 command DUMP
------------------------------
 
 cmd=DATALOG::DUMP

*/
typedef struct
{
	uint32_t byte_offset_l;     /* The 32 low-order bits of the byte offset (logged from the specified source) to begin output from */
	uint16_t byte_offset_h:8;     /* The 8 high-order bits of the byte offset (logged from the specified source) to begin output from */
	uint16_t source:8;     /* The source of the bytes to retrieve; use 0xFF to access bytes globally, ignoring source  */
	uint16_t byte_count;     /* The number of bytes to request, up to 64K */
} mmp_datalog_dump_t;


/*
 command SRCINFO
------------------------------
 
 cmd=DATALOG::SRCINFO

*/
typedef struct
{
	uint16_t source_flags;     /* Bit flags representing the sources to retrieve info about - the flags are defined as (1 << source_enum)  */
} mmp_datalog_srcinfo_t;


/*
 command REMOTE_GETDLOGBLK
------------------------------
 
 cmd=DATALOG::REMOTE_GETDLOGBLK

*/
typedef struct
{
	uint16_t addr;     /* Address of the remote modem from which the block is being requested */
	uint16_t byte_count;     /* The number of bytes to request, up to 4K */
	uint32_t byte_offset_l;     /* The 32 low-order bits of the byte offset (logged from the specified source) to begin output from */
	uint16_t byte_offset_h:8;     /* The 8 high-order bits of the byte offset (logged from the specified source) to begin output from  */
	uint16_t source:8;     /* The source of the bytes to retrieve; use 0xFF to access bytes globally, ignoring source  */
} mmp_datalog_remote_getdlogblk_t;


/*
*************************
 DATALOG Structs and Values for IFACE::CMDRESULT messages
*************************
 command SIZE
------------------------------
 
 cmdresult=DATALOG::SIZE

*/
typedef struct
{
	uint32_t size;     /* Number of bytes stores in the data logger */
	uint16_t use_mb;     /* If set to 1, the size is truncated to the nearest number of megabytes; if 0 the size is the actual number of bytes */
} mmp_datalog_cmdresult_size_t;


/*
 command READ
------------------------------
 
 cmdresult=DATALOG::READ_DATA
 cmdresult=DATALOG::READ_SECTOR
 cmdresult=DATALOG::READ_PAGE

*/
typedef struct
{
	uint32_t length;     /* number of bytes read */
	char data[1];     /* data read [sizevar=length] */
} mmp_datalog_cmdresult_read_t;


/*
 command TELL
------------------------------
 
 cmdresult=DATALOG::TELL

*/
typedef struct
{
	uint32_t position;     /* number of bytes read */
	uint32_t remaining;     /* data left to read */
} mmp_datalog_cmdresult_tell_t;


/*
 command WRITE
------------------------------
 
 cmdresult=DATALOG::WRITE_DATA

*/
typedef struct
{
	uint16_t bytes_writ;     /* number of bytes written */
	int16_t status;     /* data left to read */
} mmp_datalog_cmdresult_write_data_t;


/*
 command LIST
------------------------------
 
 cmdresult=DATALOG::LIST

*/
typedef struct
{
	uint32_t byte_count_l;     /* Low-order 32 bits of the number of bytes stored */
	uint16_t byte_count_h:8;     /* High-order 8 bits of the number of bytes stored */
	uint16_t storeloc:8;     /* Physical memory device being used to log data */
	uint16_t source_flags;     /* Bit flags representing which data sources have data in the logger - the flags are defined as (1 << source_enum) */
	uint32_t record_count;     /* Number of discrete records stored */
	uint32_t first_rec_time;     /* Time stamp of first record in logger (FAT32 format) */
	uint32_t last_rec_time;     /* Time stamp of the last record in logger (FAT32 format) */
} mmp_datalog_cmdresult_list_t;


/*
 command FIND
------------------------------
 
 cmdresult=DATALOG::FIND

*/
typedef struct
{
	uint32_t recno;     /* Record number */
	uint32_t time;     /* Timestamp of the record */
	uint16_t source_flags;     /* Bit flags representing the sources to retrieve info about - the flags are defined as (1 << source_enum) 	 */
	uint16_t size;     /* Size of the record */
	char data[1];     /* record data (length contained in size parameter) [sizevar=size] */
} mmp_datalog_cmdresult_find_t;


/*
 command DUMP
------------------------------
 
 cmdresult=DATALOG::DUMP

*/
typedef struct
{
	uint32_t byte_offset_l;     /* Low-order 32 bits of the byte offset within the logger (referenced globally or per-source, depending on the source field) */
	uint16_t byte_offset_h:8;     /* High-order 8 bits of the byte offset within the logger (referenced globally or per-source, depending on the source field) */
	uint16_t source:8;     /* The source of the dumped data (or 0xFF for ALL) */
	uint16_t length;     /* length of the data contained in the data field */
	char data[1];     /* Extracted data [sizevar=length] */
} mmp_datalog_cmdresult_dump_t;


/*
 Use to overlay the variable-length source_counts[] array in mmp_datalog_cmdresult_srcinfo_t, one for each raised bit flag
 The source and byte_count_h fields are 16-bit because multiple instances of this structure will be packed
 and the compiler fleshes the sizeof() the struct out to the next 32-bit interval anyway, so it is
 reflecting reality. 
 
 subfield=mmp_data_cmdresult_srcinfo_t::source_counts

*/
typedef struct
{
	uint32_t record_count;     /* Number of discrete records stored */
	uint32_t byte_count_l;     /* Low-order 32 bits of the number of bytes stored */
	uint16_t byte_count_h;     /* High-order 8 bits of the number of bytes stored (16-bit container) */
	uint16_t source;     /* Source of the data (16-bit container) */
} mmp_datalog_cmdresult_source_counts_t;


/*
 command SRCINFO
------------------------------
 
 cmdresult=DATALOG::SRCINFO

*/
typedef struct
{
	uint16_t source_flags;     /* Bit flags representing which data sources are being reported on - the flags are defined as (1 << source_enum) */
	uint16_t storeloc:8;     /* Physical memory device being used to log data */
	uint16_t size:8;     /* Size in bytes of the source_counts[] array */
	uint16_t source_counts[1];     /* Variable length array - there are 2 32-bit ints + 2 8-bit ints for each source with data in the logger: layout contained in mmp_datalog_cmdresult_source_counts_t [sizevar=size] */
} mmp_datalog_cmdresult_srcinfo_t;


/*
*************************
 RNGRLS Command Structs & Values
*************************
 command TRANSPOND
------------------------------
 
 cmd=RNGRLS::TRANSPOND

*/
typedef struct
{
	uint32_t freq;     /* Frequency of interrogation ping in Hz */
	uint16_t silent;     /* True for silent interrogation ping */
	uint16_t rcv_only;     /* True to enter transpond receive mode with no ping */
} mmp_rngrls_transpond_t;


/*
 command TRANSPOND_W_TIMEOUT
------------------------------
 
 cmd=RNGRLS::TRANSPOND_W_TIMEOUT

*/
typedef struct
{
	uint32_t freq;     /* Frequency of interrogation ping in Hz */
	uint16_t silent;     /* True for silent interrogation ping */
	uint16_t rcv_only;     /* True to enter transpond receive mode with no ping */
	uint16_t timeout_x10;     /* The listen period timeout, in 0.1 second increments */
} mmp_rngrls_transpond_w_timeout_t;


/*
 command RANGE, RANGE_W_TIMEOUT
------------------------------
 
 cmd=RNGRLS::RANGE
 cmd=RNGRLS::RANGE_W_TIMEOUT

*/
typedef struct
{
	uint16_t address;     /* Address of remote modem to ping for range */
	uint16_t timeout_x10;     /* When used with a RANGE_W_TIMEOUT message, specifies the timeout period for this range, in 0.1 second increments.  Ignored for regular RANGE messages. */
} mmp_rngrls_range_t;


/*
 command RANGE_USBL_REPEAT
------------------------------
 
 cmd=RNGRLS::RANGE_USBL_REPEAT

*/
typedef struct
{
	uint16_t address;     /* Address of remote modem to ping for range */
	uint16_t timeout_x10;     /* When used with a RANGE_W_TIMEOUT message, specifies the timeout period for this range, in 0.1 second increments.  Ignored for regular RANGE messages. */
	uint16_t repeats;
} mmp_rngrls_range_repeat_t;


/*
 command BEARING
------------------------------
 
 cmd=RNGRLS::BEARING
 cmd=RNGRLS::BEARING_W_TIMEOUT

*/
typedef struct
{
	uint16_t address;     /* Address of remote modem to range to */
	uint16_t type;     /* absolute/relative/compass/tilt */
	uint16_t tat;     /* turn around time */
	uint16_t timeout_x10;     /* When used with a BEARING_W_TIMEOUT message, specifies the timeout period for this range, in 0.1 second increments.  Ignored for regular BEARING messages. */
} mmp_rngrls_bearing_t;


/*
 command NAVDATA
------------------------------
 
 cmd=RNGRLS::NAVDATA

*/
typedef struct
{
	uint16_t address;     /* Address of remote modem to range to */
	uint16_t type;     /* Type of range requested: absolute/relative/compass/tilt. This field is irrelevant if the remote modem is not USBL capable. */
} mmp_rngrls_navdata_t;


/*
 command ABSREL
------------------------------
 
 cmd=RNGRLS::ABSREL
 cmd=RNGRLS::ABSCMPDEP

*/
typedef struct
{
	uint16_t address;     /* Address of remote modem to range to */
} mmp_rngrls_absrel_t;


/*
 command STATUS
------------------------------
 
 cmd=RNGRLS::RELEASE_STATUS

*/
typedef struct
{
	uint16_t address;     /* Address of remote release to get status of */
} mmp_rngrls_release_status_t;


/*
 command SMART_RELEASE / BURNWIRE
------------------------------
 
 cmd=RNGRLS::SMART_RELEASE
 cmd=RNGRLS::BURNWIRE

*/
typedef struct
{
	uint16_t address;     /* Address of remote release to trigger burnwire of */
	uint16_t code;     /* Release code */
} mmp_rngrls_smart_release_burnwire_t;


/*
 command FSK_RELEASE
------------------------------
 
 cmd=RNGRLS::FSK_RELEASE

*/
typedef struct
{
	uint16_t duration;     /* Duration to play Benthos FSK command tones for, in seconds */
	uint16_t code;     /* Benthos FSK command code */
	uint32_t freq;     /* Frequency of FSK command code */
} mmp_rngrls_fsk_param_t;


/*
 command EDGETECH_RELEASE
------------------------------
 
 cmd=RNGRLS::EDGETECH_RELEASE

*/
typedef struct
{
	uint16_t freq_spec;     /* Edgetech frequency specifier (first digit of octal code) */
	uint16_t code;     /* Edgetech command code (last 5 digits of octal code spread over 16-bits) */
} mmp_rngrls_edgetech_param_t;


/*
 command URI_RELEASE
------------------------------
 
 cmd=RNGRLS::URI_RELEASE

*/
typedef struct
{
	uint16_t code;     /* URI command/release code */
} mmp_rngrls_uri_param_t;


/*
 command GEOPRO_RELEASE
------------------------------
 
 cmd=RNGRLS::GEOPRO_RELEASE

*/
typedef struct
{
	uint16_t cmdtype;     /* Type of GeoPro operation (enable, release, reset) */
	uint16_t addr;     /* Address of unit command pertains to (0 - 126, don't care for reset) */
} mmp_rngrls_geopro_param_t;


/*
 command CHANNEL_PROBE
------------------------------
 
 cmd=RNGRLS::CHANNEL_PROBE

*/
typedef struct
{
	uint16_t addr;     /* Address of unit to probe (-1 for self probe, -2 for echo detection, -3 for acoustic sample) */
	uint16_t log;     /* flag for saving impulse response to data logger */
} mmp_rngrls_channel_probe_param_t;


/*
 command RESPONDER_RANGE
------------------------------
 
 cmd=RNGRLS::RESPONDER_RANGE

*/
typedef struct
{
	uint16_t timeout_x10;     /* Timeout of range request in 0.1 second increments */
} mmp_rngrls_responder_range_t;


/*
 command RSERIES_RANGE
------------------------------
 
 cmd=RNGRLS::RSERIES_RANGE

*/
typedef struct
{
	uint16_t address;     /* Address of remote release to request range from */
	uint16_t timeout_x10;     /* Timeout of range request in 0.1 second increments */
} mmp_rngrls_rseries_range_t;


/*
 command RSERIES_ACTIVATE
------------------------------
 
 cmd=RNGRLS::RSERIES_ACTIVATE

*/
typedef struct
{
	uint16_t address;     /* Address of remote modem to ping for range */
	uint16_t wake_up;     /* Boolean value indicating whether a wakeup signal should be sent first */
	uint16_t awake_mins;     /* Number of minutes to stay activated for */
} mmp_rngrls_rseries_activate_t;


/*
 command RSERIES_HIBERNATE /  DB lock
------------------------------
 
 cmd=RNGRLS::RSERIES_HIBERNATE

*/
typedef struct
{
	uint16_t address;     /* Address of remote release to get status of */
	uint16_t wake_up;     /* Boolean value indicating whether a wakeup signal should be sent first (ignored for HIBERNATE) */
} mmp_rngrls_rseries_hib_t;


/*
 command RSERIES_DB_LOCK/UNLOCK
------------------------------
 
 cmd=RNGRLS::RSERIES_DB_UNLOCK
 cmd=RNGRLS::RSERIES_DB_LOCK

*/
typedef struct
{
	uint16_t address;     /* Address of remote modem to ping for range */
	uint16_t wake_up;     /* Boolean value indicating whether a wakeup signal should be sent first */
	uint32_t serial_no;     /* Serial number of the remote unit to unlock */
} mmp_rngrls_rseries_dblock_t;


/*
 command RSERIES_RELEASE
------------------------------
 
 cmd=RNGRLS::RSERIES_RELEASE

*/
typedef struct
{
	uint16_t address;     /* Address of remote release to trigger burnwire of */
	uint16_t wake_up;     /* Boolean indicating whether to send an R Series wakeup in front of the release code */
	uint16_t code;     /* Release code */
} mmp_rngrls_rseries_release_t;


/*
 command RSERIES_XPND_MODE / STD_XPND_MODE
------------------------------
 
 cmd=RNGRLS::RSERIES_XPND_MODE
 cmd=RNGRLS::STD_XPND_MODE

*/
typedef struct
{
	uint16_t address;     /* Address of remote release to get status of */
	uint16_t wake_up;     /* Boolean value indicating whether a wakeup signal should be sent first (ignored for HIBERNATE) */
	uint16_t xpnd_mode;     /* Transpond Mode value to set in the remote */
} mmp_rngrls_xpnd_mode_t;


/*
 command VRSERIES_LOCALRLS
------------------------------
 
 cmd=RNGRLS::VRSERIES_LOCALRLS

*/
typedef struct
{
	uint16_t code;     /* Release code */
	uint16_t delay_s;     /* Delay in seconds after which the release will happen (max 3600, or 1 hour).  Use 0 for immediate release and -1 (0xFFFF) to cancel a pending delayed release. */
} mmp_rngrls_vrseries_localrls_t;


/*
 command ACOUSTIC_TRIGGER
------------------------------
 
 cmd=RNGRLS::ACOUSTIC_TRIGGER

*/
typedef struct
{
	uint16_t address;     /* Address of remote modem to assert acoustic trigger signal on */
	uint16_t code;     /* The acoustic trigger code, as set by @RlsCode on the remote modem. */
	uint16_t assert_time:8;     /* Encoded value representing number of seconds to assert trigger signal.  Use 0 to bypass and use RlsMinEnaTime/RlsMaxEnaTime values on remote unit.  0x01-0x3f = 1-63 seconds in 1 sec. increments; 0x40-0x7f = 60-375 seconds in 5 sec. increments; 0x80-0xBF = 300-930 seconds in 10 sec. increments; 0xC0-0xFF = 900-2790 seconds in 30 second increments. */
	uint16_t wake_up:8;     /* Boolean value indicating whether a Compact Modem wakeup signal should be sent first */
} mmp_rngrls_acoustic_trigger_t;


/*
*************************
 RNGRLS Structs and Values for IFACE::CMDRESULT messages
*************************
 command RANGE
------------------------------
 
 cmdresult=RNGRLS::RANGE
 cmdresult=RNGRLS::RANGE_W_TIMEOUT
 cmdresult=RNGRLS::RSERIES_RANGE

*/
typedef struct
{
	uint32_t range;     /* Range to remote node in tenths of a meter */
	uint32_t rt_time;     /* Round trip time to remote node in tenths of a millisecond */
} mmp_rngrls_cmdresult_range_t;


/*
 command BEARING
------------------------------
 This is a subset of mmp_rngrls_cmdresult_navdata_t and must match the start of that structure.  Changes made
 to one must be made to the other to keep them in sync.
 
 cmdresult=RNGRLS::BEARING
 cmdresult=RNGRLS::BEARING_W_TIMEOUT

*/
typedef struct
{
	uint32_t range;     /* Range to remote node in tenths of a meter */
	uint32_t rt_time;     /* Round trip time to remote node in tenths of a millisecond */
	int32_t doppler;     /* range rate 10*m/s */
	int16_t azimuth;     /* tenths of a degree, or other overloaded meanings (tilt, depth, etc.) */
	int16_t elevation;     /* tenths of a degree, or other overloaded meanings (tilt, depth, etc.) */
} mmp_rngrls_cmdresult_bearing_t;


/*
 command RANGE_USBL_REPEAT
------------------------------
 This is a subset of mmp_rngrls_cmdresult_navdata_t and must match the start of that structure.  Changes made
 to one must be made to the other to keep them in sync.
 
 cmdresult=RNGRLS::RANGE_USBL_REPEAT

*/
typedef struct
{
	uint32_t range;     /* Range to remote node in tenths of a meter */
	uint32_t trip_time;     /* One way trip time to remote node in tenths of a millisecond */
	int32_t doppler;     /* range rate 10*m/s */
	int16_t azimuth;     /* tenths of a degree, or other overloaded meanings (tilt, depth, etc.) */
	int16_t elevation;     /* tenths of a degree, or other overloaded meanings (tilt, depth, etc.) */
} mmp_rngrls_cmdresult_range_usbl_repeat_t;


/*
 command NAVDATA
------------------------------
 This is a superset of mmp_rngrls_cmdresult_bearing_t and the start of this structure must match the 
 entirety of that structure.  Changes made to one must be made to the other to keep them in sync.
 
 cmdresult=RNGRLS::NAVDATA

*/
typedef struct
{
	uint32_t range;     /* Range to remote node in tenths of a meter */
	uint32_t rt_time;     /* Round trip time to remote node in tenths of a millisecond */
	uint32_t type;     /* information type */
	int16_t azimuth;     /* tenths of a degree, or other overloaded meanings (tilt, depth, etc.) */
	int16_t elevation;     /* tenths of a degree, or other overloaded meanings (tilt, depth, etc.) */
	int32_t latitude;     /* latitude  (degrees x 10e6) */
	int32_t longitude;     /* longitude (degrees x 10e6) */
	int32_t depth;     /* depth below sea level (tenths of a meter) */
	int32_t altitude;     /* altitude (mm) above sea floor or sea level (see type) */
} mmp_rngrls_cmdresult_navdata_t;


/*
 command ABSREL
------------------------------
 
 cmdresult=RNGRLS::ABSREL

*/
typedef struct
{
	uint32_t range;     /* Range to remote node in tenths of a meter */
	uint32_t rt_time;     /* Round trip time to remote node in tenths of a millisecond */
	int32_t doppler;     /* range rate 10*m/s */
	uint16_t bearing;     /* bearing in degrees x 10 (or 0x7FFF if invalid) */
	int16_t inclination;     /* inclination in degrees x 10 (or 0x7FFF if invalid) */
	uint16_t azimuth;     /* azimuth in degrees x 10 (or 0x7FFF if invalid) */
	int16_t elevation;     /* elevation in degrees x 10 (or 0x7FFF if invalid) */
} mmp_rngrls_cmdresult_absrel_t;


/*
 command ABSCMPDEP
------------------------------
 
 cmdresult=RNGRLS::ABSCMPDEP

*/
typedef struct
{
	uint32_t range;     /* Range to remote node in tenths of a meter */
	uint32_t rt_time;     /* Round trip time to remote node in tenths of a millisecond */
	int32_t doppler;     /* range rate 10*m/s */
	uint16_t bearing;     /* bearing in degrees x 10 (or 0x7FFF if invalid) */
	int16_t inclination;     /* inclination in degrees x 10 (or 0x7FFF if invalid) */
	uint16_t compass;     /* compass heading in degrees x 10 (or 0x7FFF if invalid) */
	int16_t depth;     /* depth in meters x 10 (or 0x7FFF if invalid) */
} mmp_rngrls_cmdresult_abscmpdep_t;


/*
 command CHANNEL_PROBE
------------------------------
 
 cmdresult=RNGRLS::CHANNEL_PROBE

*/
typedef struct
{
	int32_t first;     /* time of first arrival in tenths of a millisecond */
	int32_t peak;     /* time of peak from start of buffer in tenths of a millisecond */
	int32_t EDT;     /* RT60 calculated by EDT method in tenths of a millisecond */
	int32_t T10;     /* RT60 calculated by T10 method in tenths of a millisecond */
	int16_t C25;     /* ELR for 25ms in 10th of dB */
	int16_t C50;     /* ELR for 50ms in 10th of dB */
	int32_t period;     /* minimum baud period for 10dB SNR in tenths of a millisecond */
	uint16_t data[512];     /* Binned and decimated raw probe data, integrated over 1 ms periods and presented in 0.5 dB increments, packed into upper/lower bytes in 16-bit containers */
} mmp_rngrls_cmdresult_channel_probe_t;


/*
 command ACOU_SAMPLE
------------------------------
 
 cmdresult=RNGRLS::ACOU_SAMPLE

*/
typedef struct
{
	uint32_t Fs;     /* Sample frequency of basebanded data */
	uint32_t Fc;     /* Center frequency of acoustic sample (prior to basebanding) */
	uint32_t Bw;     /* Bandwidth of T/R board */
	int16_t gain;
	uint16_t cell:8;
	uint16_t total_cells:8;
	uint16_t clip:8;
	uint16_t spare:8;
	int16_t data[1024];     /* I+Q interleaved basebanded data */
} mmp_rngrls_cmdresult_acou_sample_t;


/*
 command SPECTRUM_MODE
------------------------------
 
 cmd=RNGRLS::SPECTRUM_MODE

*/
typedef struct
{
	int16_t update_rate:8;     /* Period of MMP update messages, in 0.5 second increments, or 0 to disable spectrum mode */
	int16_t freq_bins:8;     /* Number of frequency bins to divide the band into, between 16 and 65 */
} mmp_rngrls_spectrum_mode_t;


/*
 response to all RELEASE / BURNWIRE commands
----------------------------------
 
 cmdresult=RNGRLS::SMART_RELEASE
 cmdresult=RNGRLS::BURNWIRE
 cmdresult=RNGRLS::RSERIES_RELEASE
 cmdresult=RNGRLS::ACOUSTIC_TRIGGER

*/
typedef struct
{
	uint16_t status;     /* Status code in response to release command sent to a remote release, sent with an MMP_CMDRESULT_PROGRESS or MMP_CMDRESULT_DATA type message	 */
} mmp_rngrls_cmdresult_release_response_t;


/*
 command STATUS
------------------------------
 
 cmdresult=RNGRLS::RELEASE_STATUS

*/
typedef struct
{
	uint16_t status;     /* Status of the release mechanism on the remote unit (or error indication) */
	uint16_t tilt;     /* Indicates tilt state of remote release; if value is between 20 and 200 then subtract 20 to get the true degree reading, otherwise interpret as status */
	uint16_t battery;     /* Condition of battery on the remote release; if value is between 20 and 120 then subtract 20 to get the percentage of full charge remaining, otherwise interpret as status */
} mmp_rngrls_cmdresult_release_status_t;


/*
*************************
 STD Command Structs & Values
*************************
 command REMOTE_MMPREQ
------------------------------
 
 cmd=STD::REMOTE_MMPREQ

*/
typedef struct
{
	uint16_t addr;     /* Address of modem to send remote request to */
	uint16_t flags;     /* Contains a number of flags controlling various aspects of the acoustic request */
	uint16_t len;     /* Length of data in bytes */
	char data[1];     /* Variable length data field, length should match len parameter [sizevar=len] */
} mmp_remote_request_t;


/*
 command REMOTE_SETACOUBAUD
------------------------------
 
 cmd=STD::REMOTE_SETACOUBAUD

*/
typedef struct
{
	uint16_t addr;     /* Address of remote modem to modify acoustic baud rate of */
	uint16_t modspec;     /* New acoustic baud rate (maps to Sreg-4) */
} mmp_remote_setacoubaud_t;


/*
 command REMOTE_SETTXPOWER
------------------------------
 
 cmd=STD::REMOTE_SETTXPOWER

*/
typedef struct
{
	uint16_t addr;     /* Address of remote modem to modify power level of */
	uint16_t txpower;     /* New acoustic transmit power level (maps to Sreg-6) */
} mmp_remote_settxpower_t;


/*
 command REMOTE_SETONESREG
------------------------------
 
 cmd=STD::REMOTE_SETONESREG

*/
typedef struct
{
	uint16_t addr;     /* Address of remote modem to modify s-register on */
	uint16_t sreg;     /* The s-register to modify */
	uint16_t value;     /* The new value of the s-register */
} mmp_remote_setonesreg_t;


/*
 command REMOTE_GETSREGS (response)
------------------------------
 
 cmdresult=STD::REMOTE_GETSREGS

*/
typedef struct
{
	uint16_t addr;     /* Address of remote node which the S-register data is from */
	uint16_t sregs[21];     /* Array of remote S-register data */
} mmp_remote_sregisters_t;


/*
 command REMOTE_GETONESREG
------------------------------
 
 cmd=STD::REMOTE_GETONESREG

*/
typedef struct
{
	uint16_t addr;     /* Address of remote modem to request an S-register value from */
	uint16_t sreg;     /* The s-register to obtain from the remote */
} mmp_remote_getonesreg_t;


/*
 command REMOTE_GETONESREG (response)
------------------------------
 
 cmdresult=STD::REMOTE_GETONESREG

*/
typedef struct
{
	uint16_t addr;     /* Address of remote node which the S-register data is from */
	uint16_t sreg;     /* The register number  */
	uint16_t value;     /* Value contained in the requested register */
} mmp_remote_getonesreg_resp_t;


/*
 command REMOTE_SENDDATA
------------------------------
 
 cmd=STD::REMOTE_SENDDATA
 cmd=STD::REMOTE_SENDCMD
 cmd=STD::REMOTE_SENDBREAK

*/
typedef struct
{
	uint16_t addr;     /* Address of modem to send data to */
	uint16_t transport;     /* The transport address to route data to on the far end (SENDDATA & SENDBREAK only) */
	uint16_t len;     /* Length of data in bytes (always 0 for SENDBREAK) */
	char data[1];     /* Variable length data field, length should match len parameter [sizevar=len] */
} mmp_remote_senddata_t;


/*
 command REMOTE_MMPREQ (response)
----------------------------
 
 cmdresult=STD::REMOTE_MMPREQ

*/
typedef struct
{
	uint16_t addr;     /* The address of the remote modem from which the MMP string was received */
	uint16_t len;     /* The length of the MMP response string from the remote modem */
	char data[1];     /* The MMP response string from the remote modem [sizevar=len] */
} mmp_remote_mmpresp_t;


/*
 command UPDATE_FIRMWARE
------------------------------
 
 cmd=STD::UPDATE_FIRMWARE

*/
typedef struct
{
	uint32_t addr;     /* Identifier specifying which firmware image to update: 0x200000 = boot, 0x220000 = modem, 0x260000 = diag */
} mmp_update_firmware_t;


/*
 command REMOTE_CMWAKEUP
------------------------------
 
 cmd=STD::REMOTE_CMWAKEUP

*/
typedef struct
{
	uint16_t addr;     /* Address of compact modem to awaken (may be broadcast or group) */
	uint16_t stay_awake_mins;     /* Number of minutes for remote compact modem to stay awake before being allowed to idle into hibernate. */
} mmp_remote_cmwakeup_t;


/*
 command TILT_ACCEL
------------------------------
 
 cmd=STD::TILT_ACCEL

*/
typedef struct
{
	uint16_t g_lpf;     /* Low pass filter for debouncing tilt readings, in percent of 1g.  Magnitude of the vector sum of all axes must be within +/- g_lpf percent of 1g in order for valid tilt reading to be obtained.  Use 0 if no LPF function is desired.  INVALID_STATE error returned if LPF is non-zero and no valid samples could be obtained. */
} mmp_tilt_accel_t;


/*
 command REMOTE_TESTLINK (response)
------------------------------
 
 cmdresult=STD::REMOTE_TESTLINK

*/
typedef struct
{
	uint16_t addr;     /* Address of remote link to test */
	uint16_t mod_spec;     /* Modulation specification */
	int16_t speedx10;     /* Estimated speed (doppler) in 1/10 knots units	 */
	int16_t acq_SNRx10;     /* Acquisition SNR x 10 (factory use only) */
	uint16_t acq_MPDx10;     /* Acquisition multipath delay in 1/10 ms units */
	uint16_t acq_RCT;     /* Received chirp threshold (factory use only) */
	int16_t acq_FSNR;     /* First SNR (factory use only) */
	int16_t hdr_SNRx10;     /* Header SNR x 10 */
	uint16_t hdr_CCERR;     /* Soft decision metric for convolutional decoder (factory use only) */
	uint16_t msg_ERR;     /* Bit errors in message body */
	int16_t msg_SNRx10;     /* Message body SNR x 10 (factory use only) */
	uint16_t msg_AGC;     /* AGC value at message receive */
	uint16_t msg_CCERR;     /* Soft decision metric for convolutional decoder in the message body (factory use only) */
	int16_t remote_txpwr;     /* Transmit power of remote unit (if available, 0x7FFF if unknown) */
} mmp_remote_testmsgstats_t;


/*
 command REMOTE_GETBATT (response)
 ---------------------------------
 
 cmdresult=STD::REMOTE_GETBATT

*/
typedef struct
{
	uint16_t addr;     /* Address of remote modem to get battery voltage from	 */
	uint16_t batt_voltage;     /* Remote modem battery voltage, in tenths of a volt */
	uint16_t aux_voltage;     /* Remote modem auxiliary voltage, in tenths of a volt */
} mmp_remote_battvoltage_t;


/*
 command REMOTE_GETAGCHIST (response)
------------------------------
 
 cmdresult=STD::REMOTE_GETAGCHIST

*/
typedef struct
{
	uint16_t addr;     /* Address of remote modem to get 10 second AGC history from */
	uint16_t rem_agc[10];     /* AGC history of remote modem; 8-bit packed so hi/lo values share each index */
} mmp_remote_agchist_t;


/*
 command REMOTE_AUTOBAUD
------------------------------
 
 cmd=STD::REMOTE_AUTOBAUD

*/
typedef struct
{
	uint16_t addr;     /* Address of the remote modem to conduct the auto baud handshake with */
	uint16_t max_modspec;     /* The maximum modspec/bitrate to begin testing at (max of MODSPEC_15360_PSK if coprocessor installed, or MODSPEC_2400_MFSK otherwise) */
	uint16_t min_modspec;     /* The minimum modspec/bitrate to end testing at (min of MODSPEC_300_MFSK) */
	uint16_t max_bit_errs;     /* Maximum allowable bit error count (0 to 999) in a 2048-bit packet */
	uint16_t set_flags;     /* Control flags to modify the autobaud behavior - may be ORed together to achieve desired effect */
} mmp_remote_autobaud_t;


/*
 command REMOTE_AUTOBAUD (response)
------------------------------
 
 cmdresult=STD::REMOTE_AUTOBAUD

*/
typedef struct
{
	uint16_t addr;     /* Address of the remote modem the autobaud sequence was conducted with */
	uint16_t modspec;     /* The highest modulation rate found with acceptable bit error count (MODSPEC_NULL if none qualified) */
	uint16_t bit_errs;     /* Measured bit error count of the best qualifying modulation rate (capped at 999) */
	uint16_t set_flags;     /* Flags indicating which, if any, baud rates were automatically changed as a result of the autobaud sequence */
} mmp_remote_autobaud_result_t;


/*
 command REMOTE_GETBATTCHG (response)
 ---------------------------------
 
 cmdresult=STD::REMOTE_GETBATTCHG

*/
typedef struct
{
	uint16_t addr;     /* Address of remote modem to get battery charge from	 */
	uint16_t charge;     /* Remote modem battery charge remaining in percent, or 0xFF if unavailable */
} mmp_remote_battcharge_t;


/*
 command TILT_ACCEL (response)
------------------------------
 
 cmdresult=STD::TILT_ACCEL

*/
typedef struct
{
	int16_t one_g;     /* The value that corresponds to +1g in the xyz_accel array */
	int16_t xyz_accel[3];     /* 16 bit acceleration values for X, Y, and Z axes */
	int16_t xyz_tilt[3];     /* Tilt off vertical for X, Y, and Z axes, in degrees */
	int16_t g;     /* Total amount of G force on device, in 1/1000 units (1000 = 1 G) */
} mmp_tilt_accel_response_t;


/*
 command AXIS_TILT (response)
------------------------------
 
 cmdresult=STD::AXIS_TILT

*/
typedef struct
{
	int16_t tilt:8;     /* The tilt value in degrees from upright as defined by the @TiltAxis configuration parameter */
	int16_t axis_w_pol:8;     /* The axis defined as the basis for the tilt measurement and its polarity */
} mmp_axis_tilt_response_t;


/*
*************************
 command GETBATT (response)
 ---------------------------------
 
 cmdresult=STD::GETBATT

*/
typedef struct
{
	uint16_t batt_voltage;     /* Local modem battery voltage, in tenths of a volt */
	uint16_t aux_voltage;     /* Local modem auxiliary voltage, in tenths of a volt */
} mmp_battvoltage_t;


/*
 command GETBATTCHG (response)
 ---------------------------------
 
 cmdresult=STD::GETBATTCHG

*/
typedef struct
{
	uint16_t charge;     /* Local modem battery charge remaining in percent, or 0xFF if unavailable */
} mmp_battcharge_t;


/*
 command GETAGCHIST (response)
------------------------------
 
 cmdresult=STD::GETAGCHIST

*/
typedef struct
{
	uint16_t agchist[10];     /* AGC history of remote modem; 8-bit packed so hi/lo values share each index */
} mmp_agchist_t;


/*
 command BOARD_TEMP
------------------------------
 
 cmd=STD::BOARD_TEMP

*/
typedef struct
{
	uint16_t thermistor;     /* 0-based number of the thermistor to read.  BAD_CMDARGS will be returned if thermistor is not valid for current hardware. */
} mmp_board_temp_t;


/*
 command BOARD_TEMP (response)
------------------------------
 
 cmdresult=STD::BOARD_TEMP

*/
typedef struct
{
	int16_t temp_C_x10;     /* 0-based number of the thermistor to read.  BAD_CMDARGS will be returned if thermistor is not valid for current hardware. */
} mmp_board_temp_resp_t;


/*
 cmd CONT_XMIT_TEST
------------------------------
 
 cmd=STD::CONT_XMIT_TEST

*/
typedef struct
{
	uint16_t enable;     /* Enable or disable continus xmit (burn-in) test mode */
} mmp_std_contxmit_enable_t;


/*
 cmd SET_REMOTE_GROUP
------------------------------
 
 cmd=STD::SET_REMOTE_GROUP

*/
typedef struct
{
	uint16_t address;     /* base address 0..49 or group ID 250..254 */
	uint16_t group;     /* new group ID 0..4 */
} mmp_std_set_remote_group_t;


/*
 cmd GETSMARTBATTDATA
------------------------------
 
 cmd=STD::GETSMARTBATTDATA

*/
typedef struct
{
	uint16_t battery;     /* Index of smart battery to obtain info from, between 0 and 3.  If only one battery installed, use 0. */
} mmp_std_getsmartbattdata_t;


/*
 response object in smart_batt.h
 cmd ADDFEATUREKEY, DELFEATUREKEY
------------------------------
 
 cmd=STD::ADDFEATUREKEY
 cmd=STD::DELFEATUREKEY

*/
typedef struct
{
	char key[42];     /* Feature key as an ASCII string, with room for an optional terminating null character */
} mmp_std_featkeystring_t;


/*
 command WRITE_DEVICE
------------------------------
 
 cmd=STD::WRITE_DEVICE

*/
typedef struct
{
	uint16_t device_num;     /* Device number */
	uint16_t len;     /* Length of data to write */
	char data[1];     /* Variable length data field, length should match len parameter [sizevar=len] */
} mmp_write_device_t;


/*
 command WRITE_DEVICE(response)
------------------------------
 
 cmdresult=STD::WRITE_DEVICE

*/
typedef struct
{
	uint16_t bytes_writ;     /* Number of bytes written */
	int16_t status;     /* Status of bytes written */
} mmp_write_device_result_t;


/*
 command READ_DEVICE
------------------------------
 
 cmd=STD::READ_DEVICE

*/
typedef struct
{
	uint16_t device_num;     /* Device number */
	uint16_t len;     /* Length of data to read */
} mmp_read_device_t;


/*
 command READ_DEVICE (response)
------------------------------
 
 cmdresult=STD::READ_DEVICE

*/
typedef struct
{
	int16_t status;     /* Status of bytes read */
	uint16_t len;     /* Number of bytes read */
	char data[1];     /* Variable length data field, length should match len parameter [sizevar=len] */
} mmp_read_device_result_t;


/*
 command LEN_DEVICE
------------------------------
 
 cmd=STD::LEN_DEVICE

*/
typedef struct
{
	uint16_t device_num;     /* Device number */
} mmp_len_device_t;


/*
 command LEN_DEVICE (response)
------------------------------
 
 cmdresult=STD::LEN_DEVICE

*/
typedef struct
{
	uint16_t device_num;     /* Device Number */
	uint16_t len;     /* Number of bytes in device */
} mmp_len_device_result_t;


/*
 command FIND_DEVICE
------------------------------
 
 cmd=STD::FIND_DEVICE

*/
typedef struct
{
	uint16_t len;     /* Length of device name */
	char name[1];     /* Variable length data field, length should match len parameter [sizevar=len] */
} mmp_find_device_t;


/*
 command FIND_DEVICE (response)
------------------------------
 
 cmdresult=STD::FIND_DEVICE

*/
typedef struct
{
	uint16_t device_num;     /* Device Number */
} mmp_find_device_result_t;


/*
 command REMOTE_MMPREQ
------------------------------
 
 cmd=SWCMD::REMOTE_MMPREQ

*/
typedef struct
{
	uint16_t addr;     /* Address of modem to send remote request to */
	uint16_t cellid;     /* The Cell ID by which to route the packet (last hop).  Set to 0 if no Cell ID used. */
	uint16_t flags;     /* Contains a number of flags controlling various aspects of the acoustic request */
	uint16_t len;     /* Length of data in bytes */
	char data[1];     /* Variable length data field, length should match len parameter [sizevar=len] */
} mmp_swb_remote_request_t;


/*
**************************
 CFG Fields
**************************
**************************
 CFG Structs & Field Values
**************************
 
 field=CFG_SECT_COPROC::*
 field=CFG_SECT_DATALOG::*
 field=CFG_SECT_MODEM::*
 field=CFG_SECT_RELEASE::*
 field=CFG_SECT_SEAWEB::*
 field=CFG_SECT_SERIAL::*
 field=CFG_SECT_SYSTEM::*
 field=CFG_SECT_TEST::*
 field=CFG_SECT_VERSION::*
 field=CFG_SECT_XPND::*
 field=CFG_SECT_NETWORK::*
 field=CFG_SECT_NAV::*
 field=CFG_SECT_DAT::*
 field=CFG_SECT_RECORDER::*
 field=CFG_SECT_SONAR::*
 field=CFG_SECT_TRANSPORT::*
 field=CFG_SECT_WHOI::*
 field=CFG_SECT_USBL::*

*/
typedef struct
{
	int32_t val_or_len;     /* Value for 32-bit types, or length of variable length types (CFG_STR, CFG_CSTM) */
	uint16_t places:8;     /* For GET operations, the number of places to format the number as.  If type is CFG_NUM32 and places is non-zero, then the val_or_len value must be divided appropriately to provide the correct number of decimal places. */
	uint16_t type:8;     /* Type of the config parameter (GET only, ignored on SET) */
	char buf[1];     /* Variable length buffer to contain value of config parameter if it is not a standard 32-bit type [sizevar=val_or_len] */
} mmp_cfg_paramval_t;


/*
**************************
 DATA Structs & Field Values
**************************
 field ACK -- uses ack codes from pmdef.h
------------------------------
 
 field=DATA::ACK

*/
typedef struct
{
	uint16_t ack;     /* Type of acknowledgement */
} mmp_data_ack_t;


/*
 field REMOTE_DATA, REMOTE_DLOGBLK
------------------------------
 Note the data[1] item is variable length, but declared as 1-element to allow array indexing
 
 field=DATA::REMOTE_DATA
 field=DATA::REMOTE_DLOGBLK

*/
typedef struct
{
	uint16_t addr;     /* Address of sending modem */
	uint16_t transport;     /* Transport address, if any */
	uint16_t invalid_blks;     /* Raised bits in this field correspond to corrupted 256-byte subblocks of the transfer */
	uint16_t len;     /* Length of data in bytes */
	char data[1];     /* Variable length data field containing received data [sizevar=len] */
} mmp_remote_data_t;


/*
 field XMIT_OVERTEMP
------------------------------
 
 field=DATA::XMIT_OVERTEMP

*/
typedef struct
{
	uint16_t sensor;     /* Which temperature sensor triggered the alert (only sensor 0 present on ATM and Compact board sets, while both 0 and 1 are available on UTS/UDB platforms) */
	uint16_t setpoint_x_100;     /* The setpoint in degrees C x 100 that was exceeded */
} mmp_data_xmit_overtemp_t;


/*
 field BURN_COMPLETE, BURN_TIMEOUT
------------------------------
 
 field=DATA::BURN_COMPLETE
 field=DATA::BURN_TIMEOUT

*/
typedef struct
{
	uint16_t addr;     /* Address of the modem that has completed the burn cycle */
} mmp_burn_complete_t;


/*
 field ACOUTRIG_COMPLETE, ACOUTRIG_TIMEOUT
------------------------------
 
 field=DATA::ACOUTRIG_COMPLETE
 field=DATA::ACOUTRIG_TIMEOUT

*/
typedef struct
{
	uint16_t addr;     /* Address of the modem that has completed the acoustic trigger assertion cycle */
	uint16_t assert_state;     /* 1 if signal still asserted, 0 if de-asserted */
} mmp_acoutrig_complete_t;


/*
 field TRRC_STATUS   
------------------------------
 
 field=DATA::TRRC_STATUS

*/
typedef struct
{
	uint16_t tr_read_fail;     /* Transmit/Receive EEPROM could not be read */
	uint16_t rc_read_fail;     /* Receive module EEPROM could not be read */
	uint16_t tr_band_fail;     /* Configured band does not match T/R's EEPROM data */
	uint16_t rc_band_fail;     /* Configured band does not match receive module EEPROM data */
} mmp_data_trrc_status_t;


/*
 field FEAT_KEY_STATUS
------------------------------------
 
 field=DATA::FEAT_KEY_STATUS

*/
typedef struct
{
	uint32_t available_features;     /* Bit flag of key-activatable features available on this platform */
	uint32_t expected_features;     /* Bit flag of feature keys expected on this platform */
	uint32_t enabled_features;     /* Bit flag of all features with valid authorization keys installed, irrespective of available_features */
	uint32_t unauthorized_features;     /* Bit flag of EXPECTED (not all) features with no authorization keys */
} mmp_data_feat_key_status_t;


/*
 field DATA::REMOTE_HEADER   
------------------------------
 
 field=DATA::REMOTE_HEADER

*/
typedef struct
{
	uint16_t type:8;     /* 1 0x0F for data  : 0x00 for command */
	uint16_t extension:8;     /* 2 MSB of modspec : command type */
	uint16_t parm1:8;     /* 3 LSB of modspec : p1 */
	uint16_t parm2:8;     /* 4 MSB of length  : p2 */
	uint16_t parm3:8;     /* 5 MSB of length  : p3 */
	uint16_t Rx_addr:8;     /* 6 destination address */
	uint16_t Tx_addr:8;     /* 7 source address */
	uint16_t CRC:8;     /* 8 cyclic redundacy check */
} mmp_data_remote_header_t;


/*
 field MMP_DATA_FLD_FPM_VERSION
------------------------------------
 
 field=DATA::FPM_VERSION

*/
typedef struct
{
	int16_t ver_major:8;     /* Major revision number */
	int16_t ver_minor:8;     /* Minor revision number */
} mmp_data_fpm_version_t;


/*
 field TIMESTAMP
------------------------------
 
 field=DATA::TIMESTAMP

*/
typedef struct
{
	uint16_t event;     /* event type */
	uint16_t hour;     /* hours */
	uint16_t min;     /* minutes */
	uint16_t sec;     /* seconds */
	uint16_t msec10;     /* 10ths of milliseconds */
} mmp_data_timestamp_t;


/*
 field DOPPLER
------------------------------
 
 field=DATA::DOPPLER

*/
typedef struct
{
	int16_t speed;     /* Doppler speed in 1/10 knots */
} mmp_data_doppler_t;


/*
 field DIRECTIONAL
------------------------------

 field=DATA::DIRECTIONAL

*/
typedef struct
{
	int16_t raw_bearing;     /* raw bearing from transducer in tenths of a degree */
	int16_t raw_elevation;     /* raw elevation from transducer in tenths of a degree */
	int16_t cal_bearing;     /* vehicle relative bearing in tenths of a degree */
	int16_t cal_elevation;     /* vehicle relative elevation in tenths of a degree */
	int16_t bearing;     /* fully corrected bearing in tenths of a degree */
	int16_t elevation;     /* fully corrected elevation in tenths of a degree */
	uint16_t range;     /* one way range in tenths of a meter */
	int16_t compass;     /* compass heading in tenths of a degree */
	int16_t pitch;     /* compass pitch in tenths of a degree */
	int16_t roll;     /* compass roll in tenths of a degree */
	int32_t latitude;     /* GPS latitude in millionths of a degree */
	int32_t longitude;     /* GPS latitude in millionths of a degree */
} mmp_data_directional_t;


/*
 field DIRECTIONAL_DEBUG
------------------------------

 field=DATA::DIRECTIONAL_DEBUG

*/
typedef struct
{
	int16_t cal_bearing;     /* calibration table bearing in tenths of a degree */
	int16_t cal_elevation;     /* calibration table elevation in tenths of a degree */
	int16_t AGC;     /* Gain setting at time of detection */
	int16_t vector;     /* vector quality indicator * 1000 */
	int16_t level_1;     /* detect level in phone 1 (ADC counts) */
	int16_t level_2;     /* detect level in phone 2 (ADC counts) */
	int16_t level_3;     /* detect level in phone 3 (ADC counts) */
	int16_t level_4;     /* detect level in phone 4 (ADC counts) */
} mmp_data_directional_debug_t;


/*
 field DIRECTIONAL_LOCDEBUG
------------------------------

 field=DATA::DIRECTIONAL_LOCDEBUG

*/
typedef struct
{
	int16_t compass;     /* compass heading in tenths of a degree */
	int16_t pitch;     /* compass pitch in tenths of a degree */
	int16_t roll;     /* compass roll in tenths of a degree */
	int16_t vector;     /* vector quality indicator * 1000 */
	int16_t level_1;     /* detect level in phone 1 (ADC counts) */
	int16_t level_2;     /* detect level in phone 2 (ADC counts) */
	int16_t level_3;     /* detect level in phone 3 (ADC counts) */
	int16_t level_4;     /* detect level in phone 4 (ADC counts) */
} mmp_data_directional_locdebug_t;


/*
**************************
 field TONAL_LOCATOR
------------------------------
 
 field=DATA::TONAL_LOCATOR

*/
typedef struct
{
	int16_t bearing;     /* vehicle relative bearing in tenths of a degree */
	int16_t elevation;     /* vehicle relative elevation in tenths of a degree */
	int16_t vector;     /* vector quality indicator * 1000 */
	int16_t AGC;     /* Gain setting at time of detection */
	uint16_t frequency;     /* frequency of detected tone in Hetrz */
	uint16_t hour;     /* hours */
	uint16_t min;     /* minutes */
	uint16_t sec;     /* seconds */
	uint16_t msec10;     /* 10ths of milliseconds */
} mmp_data_locator_t;


/*
**************************
 field LOW_POWER
------------------------------
 
 field=DATA::LOW_POWER

*/
typedef struct
{
	uint16_t lpstat;     /* Low power status (enter/exit) */
	uint16_t waketype;     /* Wake type that cause low power mode to end (only valid when exiting LP mode) */
	uint32_t sleep_secs;     /* Number of seconds modem was in low power mode (on exit) or the number of seconds the modem will sleep for (if entering low power mode with timed wakeup) */
} mmp_data_lowpower_t;


/*
 field ACSTATS
------------------------------
 
 field=DATA::ACSTATS

*/
typedef struct
{
	uint16_t addr;     /* Address of remote modem sending data */
	uint16_t mod_spec;     /* Modulation specification */
	int16_t speedx10;     /* Estimated speed (doppler) in 1/10 knots units     */
	int16_t acq_SNRx10;     /* Acquisition SNR x 10 (factory use only) */
	uint16_t acq_MPDx10;     /* Acquisition multipath delay in 1/10 ms units */
	uint16_t acq_RCT;     /* Received chirp threshold (factory use only) */
	int16_t acq_FSNR;     /* First SNR (factory use only) */
	int16_t hdr_SNRx10;     /* Header SNR x 10 */
	uint16_t hdr_CCERR;     /* Soft decision metric for convolutional decoder (factory use only) */
	uint16_t msg_ERR;     /* Bit errors in message body - Only applies to test messages from ATX or ATY */
	int16_t msg_SNRx10;     /* Message body SNR x 10 (factory use only) */
	uint16_t msg_AGC;     /* AGC value at message receive */
	uint16_t msg_CCERR;     /* Soft decision metric for convolutional decoder in the message body (factory use only) */
	uint16_t msg_CRC;     /* The CRC of the incoming message */
} mmp_data_acstats_t;


/*
 field HEADER ERROR
------------------------------
 
 field=DATA::HEADER_ERROR

*/
typedef struct
{
	int16_t speedx10;     /* Estimated speed (doppler) in 1/10 knots units     */
	int16_t acq_SNRx10;     /* Acquisition SNR x 10 (factory use only) */
	uint16_t acq_MPDx10;     /* Acquisition multipath delay in 1/10 ms units */
	uint16_t acq_RCT;     /* Received chirp threshold (factory use only) */
	int16_t acq_FSNR;     /* First SNR (factory use only) */
	int16_t hdr_SNRx10;     /* Header SNR x 10; 0x7FFF (MMP_HDRERR_LOWSNRACQ) signifies low SNR acquisition and no header decode (rest of fields zeroed) */
	uint16_t hdr_CCERR;     /* Soft decision metric for convolutional decoder (factory use only) */
} mmp_data_hdrerr_t;


/*
 field RANGE_UPDATE
------------------------------
 
 field=DATA::RANGE_UPDATE

*/
typedef struct
{
	uint16_t node;     /* Node address to which the range update applies */
	int16_t range_type;     /* Type of range update */
	uint32_t range_x10;     /* Range to remote node in 1/10 meter units */
	uint32_t propdly_x10;     /* Acoustic propagation delay to remote node in 1/10 ms units */
} mmp_data_rangeupdate_t;


/*
 field MMP_DATA_FLD_NAV_STATUS
------------------------------------
 
 field=DATA::NAV_STATUS

*/
typedef struct
{
	int16_t location;     /* status of location information */
	int16_t heading;     /* status of heading information */
	int16_t attitude;     /* status of attitude information */
} mmp_data_nav_status_t;


/*
 field FPM_BOOT_FAIL
------------------------------------
 
 field=DATA::FPM_BOOT_FAIL

*/
typedef struct
{
	int16_t failure;
} mmp_data_fpm_boot_failure_t;


/*
 field MMP_DATA_FLD_RCV_GAIN
------------------------------------
 
 field=DATA::RCV_GAIN

*/
typedef struct
{
	int16_t rc_atten_step1;
	int16_t rc_atten_step2;
	int16_t rc_total_gain;
} mmp_data_rcv_gain_t;


/*
 field SPECTRUM_STATUS
------------------------------
 
 field=DATA::SPECTRUM_STATUS

*/
typedef struct
{
	uint16_t stat:8;     /* Status of spectrum mode.  0 if disabled, 1 if enabled. */
	uint16_t bins:8;     /* The number of frequency bins the band will be divided into (may be different than requested) */
	uint16_t step;     /* Step size of the frequency bins, in Hz */
	uint32_t freq_low;     /* Frequency of the lowest bin */
	uint32_t freq_high;     /* Frequency of the highest bin */
} mmp_spectrum_stat_t;


/*
 field SPECTRUM_DATA
------------------------------
 Note the data[1] item is variable length, but declared as 1-element to allow array indexing
 
 field=DATA::SPECTRUM_DATA

*/
typedef struct
{
	int16_t AGC;     /* The current AGC value at the time the spectrum sample was collected */
	int16_t bins;     /* Number of bins of spectrum data (corresponding to size of the data[] array in bytes) */
	char data[1];     /* Variable length data field containing spectrum data [sizevar=bins] */
} mmp_spectrum_data_t;


/*
 field RLS_CMOTOR_STATUS
------------------------------
 
 field=DATA::RLS_CMOTOR_STATUS

*/
typedef struct
{
	int16_t status;     /* Continuous motor status */
} mmp_data_rls_cmotor_status_t;


/*
 field JANUS_PACKET
------------------------------
 
 field=DATA::JANUS_PACKET
 cmd=STD::SENDJANUSPACKET

*/
typedef struct
{
	uint16_t version:8;     /* JANUS format version of the packet.  Ignored on transmits, as modem inserts version into outbound packet automatically. */
	uint16_t mobility_flag:8;     /* Set high if packet originates from a mobile node. */
	uint16_t txrx_flag:8;     /* Set high if packet originates from a node capable of both transmitting and receiving.  If low, node can transmit only. */
	uint16_t forwarding_flag:8;     /* Set high if packet originates from a node capable of packet forwarding (for routing and delay-tolerant processing). */
	uint16_t class_userid:8;     /* The JANUS class user ID of the packet */
	uint16_t app_type:8;     /* The JANUS application type (within the specified class user ID) of the packet. */
	uint16_t schedule_type:8;     /* The type of scheduling in this JANUS packet: none, reserved, or repeat.  If reserved or repeat, schedule_index_adb_upper will contain the schedule lookup index. */
	uint16_t schedule_index_adb_upper:8;     /* If schedule_type is either reserved or repeat, this field contains the table lookup index for the appropriate scheduling scheme (with high order bit masked off, as it is represented in schedule_type).  If schedule_type is none, then the lowermost two bits of this field contains the uppermost two bits of the application data block (ADB). */
	uint32_t adb_lower;     /* If schedule_type is none, this field contains the lowermost 32 bits of the application data block (ADB).  Otherwise, this field contains the lowermost 26 bits of the ADB, with the upper 8 scheduling bits represented in schedule_type and schedule_index_adb_upper. */
	uint16_t cargo_len;     /* The length of the cargo in bytes. */
	char cargo[1];     /* The optional cargo bytes for the packet. [sizevar=cargo_len] */
} mmp_data_janus_packet_t;


/*
 field RNGBRG_UPDATE
------------------------------
 
 field=DATA::RNGBRG_UPDATE

*/
typedef struct
{
	uint32_t range;     /* Range to remote node in 1/10 meter units */
	uint32_t propdly_x10;     /* Acoustic propagation delay to remote node in 1/10 ms units */
	uint16_t node;     /* Node address to which the range update applies */
	int16_t azimuth;     /* tenths of a degree, or other overloaded meanings (tilt, depth, etc.) */
	int16_t elevation;     /* tenths of a degree, or other overloaded meanings (tilt, depth, etc.) */
} mmp_data_rngbrg_update_t;


/*
**************************
 DECKBOX Structs & Field Values
**************************
 field SPKRVOL/PHONESVOL
------------------------------
 
 field=DECKBOX::SPKRVOL
 field=DECKBOX::PHONESVOL

*/
typedef struct
{
	uint16_t volume:8;     /* Volume of audio device */
	uint16_t mute:8;     /* True if audio device muted */
} mmp_spkr_phones_vol_t;


/*
 field PWRSENSE
------------------------------
 
 field=DECKBOX::PWRSENSE

*/
typedef struct
{
	uint16_t device;     /* Power source currently in use on deck box */
	uint16_t charge:8;     /* Coarse internal battery charge level while charging */
	uint16_t charging:8;     /* True if internal batteries are charging */
} mmp_pwrsense_t;


/*
 field BATTLEV
------------------------------
 
 field=DECKBOX::BATTLEV

*/
typedef struct
{
	uint16_t charge;     /* Coarse internal battery charge level remaining */
} mmp_battlev_t;


/*
 field BATTVOLT
------------------------------
 
 field=DECKBOX::BATTVOLT

*/
typedef struct
{
	uint16_t volts_x_100;     /* Internal battery voltage in 1/100 volt units */
} mmp_battvolt_t;


/*
 field MODEL
------------------------------
 
 field=DECKBOX::MODEL

*/
typedef struct
{
	uint16_t model;     /* Identifies the deck box model variant */
} mmp_udb_model_t;


/*
 field GPS_RELAY
------------------------------
 
 field=DECKBOX::GPS_RELAY

*/
typedef struct
{
	uint16_t status;     /* Flag indicating GPS pass-through mode status */
} mmp_gps_relay_t;


/*
 field XDCR_SWITCH
------------------------------
 
 field=HWCTL::XDCR_SWITCH

*/
typedef struct
{
	int16_t which;     /* Select upper or lower transducer */
} mmp_xdcr_switch_t;


/*
**************************
 IFACE Structs & Field Values
**************************
 field MMPSTAT
------------------------------
 
 field=IFACE::MMPSTAT

*/
typedef struct
{
	uint16_t stat;     /* MMP interface status */
} mmp_iface_stat_t;


/*
 field ERR
----------------------------
 Structure used to return MMP error codes.  Contains error type and the subsystem/field of the 
 request that generated it
 
 field=IFACE::ERR

*/
typedef struct
{
	uint16_t subsys:8;     /* Subsystem or Command Section of the request that caused the error */
	uint16_t field:8;     /* Field or Command of the request that caused the error */
	uint16_t err;     /* Error code */
} mmp_sfl_err_t;


/*
 field VERSION
------------------------------
 
 field=IFACE::VERSION

*/
typedef struct
{
	uint16_t major;     /* MMP protocol major revision number */
	uint16_t minor;     /* MMP protocol minor revision number */
} mmp_version_t;


/*
 field CMDRESULT
-------------------------------
 
 field=IFACE::CMDRESULT

*/
typedef struct
{
	uint16_t cmdsect:8;     /* CMDSECT of the request this result pertains to */
	uint16_t cmd:8;     /* Command of the request this result pertains to */
	uint16_t seqno:8;     /* Sequence number of the response to the current command - increments for each CMDRESULT NOTIFY associated with a given EXEC request */
	uint16_t message:8;     /* Message/result of the command */
} mmp_cmd_result_t;


/*
 field BLOCKNOTIFY, UNBLOCKNOTIFY
----------------------------
 
 field=IFACE::BLOCKNOTIFY
 field=IFACE::UNBLOCKNOTIFY

*/
typedef struct
{
	uint16_t numsubsys;     /* The number of subsystems to block/unblock in the list */
	char subsys[1];     /* Variable length array of the subsystems to block/unblock [sizevar=numsubsys] */
} mmp_iface_blocknotify_t;


/*
 field PRIVLEV
----------------------------
 
 field=IFACE::PRIVLEV

*/
typedef struct
{
	uint16_t privlev:8;     /* The privilege level the MMP daemon is running at (affects ALL interfaces) */
	uint16_t pwlen:8;     /* Length of the password string (SET only) */
	char password[1];     /* The password to access the desired interface (SET only).  No password needed if lowering privlev from the current. [sizevar=pwlen] */
} mmp_iface_privlev_t;


/*
 field DSP_SW_VERSION
------------------------------
 
 field=IFACE::DSP_SW_VERSION

*/
typedef struct
{
	uint16_t major:8;     /* DSP firmware major version number */
	uint16_t minor:8;     /* DSP firmware minor version number */
	uint16_t revision;     /* DSP firmware revision number */
	uint32_t svnver;     /* Repository version of DSP software build, 32-bit field */
} mmp_iface_dsp_sw_version_t;


/*
 field FEATURE_KEY
------------------------------
 
 field=IFACE::FEATURE_KEY

*/
typedef struct
{
	char key[16];
} mmp_iface_featurekey_t;


/*
 field UNIT_SERNO
------------------------------
 
 field=IFACE::UNIT_SERNO

*/
typedef struct
{
	uint32_t serno;     /* Serial number of the assembly, 32-bit field */
} mmp_iface_unit_serno_t;


/*
**************************
 field NTFY_COUNT, NTFY_CKSUM
------------------------------
 
 field=IFACE::NTFY_COUNT
 field=IFACE::NTFY_CKSUM
 field=IFACE::GATE_DATA_DIRECTIONAL

*/
typedef struct
{
	uint16_t enable;     /* Status of MMP post-script notification (appended to each notification message, unique per interface) */
} mmp_iface_flag_enable_t;


/*
 field AES_USER_KEY
------------------------------
 
 field=IFACE::AES_USER_KEY

*/
typedef struct
{
	uint16_t timeout_hrs;     /* Set to 0 for no expiry of the AES user key, otherwise set to the number of hours (up to 8760) the key should be valid while running an application. If set to 0xFFFF, it acts as a "clear" indicator and causes the user key and auto-reset timer to be cleared.  Other parameters will be ignored when this field is set to 0xFFFF. */
	uint16_t key[16];     /* The AES user key to set, packed into big-endian 16-bit containers.  Set the first 128, 192, or 256 bits (8, 12, or 16 words) depending on the bit length of the encryption being used. */
} mmp_iface_aes_key_t;


/*
 field COMPATIBILITY
------------------------------
 
 field=IFACE::COMPATIBILITY

*/
typedef struct
{
	uint16_t compat_1:8;     /* Compatibility number 1 */
	uint16_t compat_2:8;     /* Compatibility number 2 */
} mmp_iface_compatibility_t;


/*
 field FEATURE_KEY_INVENTORY
------------------------------
 
 field=IFACE::FEATURE_KEY_INVENTORY

*/
typedef struct
{
	uint16_t numkeys;     /* The number of keys contained in this message */
	uint16_t totlen;     /* The total length of the keys[] field (should be numkeys * 42) */
	char keys[1];     /* Array containg all keys concatenated together, with each key occupying 41 bytes plus a null separator for a total of 42 bytes. [sizevar=totlen] */
} mmp_iface_featurekeyinventory_t;


/*
**************************
 SREG Structs & Field Values
**************************
 
 field=SREG::*

*/
typedef struct
{
	uint16_t val;     /* S-register value */
} mmp_sreg_fld_val_t;


/*
 
 field=SREG::ALL

*/
typedef struct
{
	uint16_t val[60];     /* S-register value */
} mmp_sreg_fld_val_all_t;


/*
**************************
 TIME Structs & Field Values
**************************
 field TIMEDATE
------------------------------
 
 field=TIME::TIMEDATE

*/
typedef struct
{
	uint16_t isdst:8;     /* True if local daylight savings time is in effect */
	uint16_t hh:8;     /* Hour */
	uint16_t mm:8;     /* Minute */
	uint16_t ss:8;     /* Second */
	uint16_t mo:8;     /* Month */
	uint16_t da:8;     /* Day of month */
	uint16_t yr;     /* Year */
	int16_t tz;     /* Time zone +/- UTC in minutes */
} mmp_time_t;


/*
 field DSTPARMS
-------------------------------
 
 field=TIME::DSTPARMS

*/
typedef struct
{
	uint16_t fwd_hr:8;     /* Hour of day when jump forward occurs */
	uint16_t fwd_mo:8;     /* Month when jump forward occurs */
	uint16_t fwd_wk:8;     /* Week of month when jump forward occurs */
	uint16_t fwd_dotw:8;     /* Day of the week when jump forward occurs */
	uint16_t back_hr:8;     /* Hour of day when fall backward occurs */
	uint16_t back_mo:8;     /* Month when fall backward occurs */
	uint16_t back_wk:8;     /* Week of month when fall backward occurs */
	uint16_t back_dotw:8;     /* Day of the week when fall backward occurs */
} mmp_dst_t;


/*
 field RTCBATT
-------------------------------
 
 field=TIME::RTCBATT

*/
typedef struct
{
	int16_t rtcbatt_x100;     /* Real Time Clock battery voltage in units of 1/100 volt */
} mmp_rtcbatt_t;


/*
**************************
 field SYNCINFO
-------------------------------
 
 field=TIME::SYNCINFO

*/
typedef struct
{
	uint16_t pps_state:8;     /* The current synchronization state of the modem with a high accuracy internal or external source */
	uint16_t qualifying:8;     /* When set, indicates the modem has detected a 1PPS source that falls within its pull-in range and is attempting to lock to it; this should only be the case when in COAST or NO_SYNC state */
	uint16_t time_sync:8;     /* When set, indicates the modem has been provisioned with a date and time (either internally or externally) */
	uint16_t ext_time:8;     /* True if an external timestamp has been received */
} mmp_time_syncinfo_t;


/*
**************************
 TRANSPOND Structs & Field Values
**************************
 field STAT
------------------------------
 
 field=TRANSPOND::STAT

*/
typedef struct
{
	uint16_t stat;     /* Status of transpond mode */
	uint16_t timeout;     /* Time of transpond mode, rounded up to next second */
} mmp_transpond_stat_t;


/*
 field PINGRCVD
-------------------------------
 
 field=TRANSPOND::PINGRCVD

*/
typedef struct
{
	uint32_t freq;     /* Frequency of received ping, in Hz */
	uint32_t rt_time;     /* Round trip time of received ping measured from interrogation */
	uint32_t detect_lev;     /* Detect level of received ping in std. deviations above mean noise level */
	uint16_t flags;     /* Flags denoting special attributes of the ping event */
} mmp_transpond_pingrcvd_t;


/*
 field CHNLRXADJ_<x> (except ALL)
-------------------------------
 
 field=TRANSPOND::CHNLRXADJ_0
 field=TRANSPOND::CHNLRXADJ_1
 field=TRANSPOND::CHNLRXADJ_2
 field=TRANSPOND::CHNLRXADJ_3
 field=TRANSPOND::CHNLRXADJ_4
 field=TRANSPOND::CHNLRXADJ_5
 field=TRANSPOND::CHNLRXADJ_6
 field=TRANSPOND::CHNLRXADJ_7
 field=TRANSPOND::CHNLRXADJ_8
 field=TRANSPOND::CHNLRXADJ_9
 field=TRANSPOND::CHNLRXADJ_10
 field=TRANSPOND::CHNLRXADJ_11
 field=TRANSPOND::CHNLRXADJ_12
 field=TRANSPOND::CHNLRXADJ_13
 field=TRANSPOND::CHNLRXADJ_14
 field=TRANSPOND::CHNLRXADJ_15
 field=TRANSPOND::CHNLRXADJ_16
 field=TRANSPOND::CHNLRXADJ_17
 field=TRANSPOND::CHNLRXADJ_18
 field=TRANSPOND::CHNLRXADJ_19
 field=TRANSPOND::CHNLRXADJ_20
 field=TRANSPOND::CHNLRXADJ_21
 field=TRANSPOND::CHNLRXADJ_22
 field=TRANSPOND::CHNLRXADJ_23
 field=TRANSPOND::CHNLRXADJ_24
 field=TRANSPOND::CHNLRXADJ_25
 field=TRANSPOND::CHNLRXADJ_26
 field=TRANSPOND::CHNLRXADJ_27
 field=TRANSPOND::CHNLRXADJ_28
 field=TRANSPOND::CHNLRXADJ_29
 field=TRANSPOND::CHNLRXADJ_30
 field=TRANSPOND::CHNLRXADJ_31
 field=TRANSPOND::CHNLRXADJ_32
 field=TRANSPOND::CHNLRXADJ_33
 field=TRANSPOND::CHNLRXADJ_34
 field=TRANSPOND::CHNLRXADJ_35
 field=TRANSPOND::CHNLRXADJ_36
 field=TRANSPOND::CHNLRXADJ_37
 field=TRANSPOND::CHNLRXADJ_38
 field=TRANSPOND::CHNLRXADJ_39
 field=TRANSPOND::CHNLRXADJ_40

*/
typedef struct
{
	int16_t adjustment;     /* Receive sensitivity adjustment of the channel, from -100 to +100 */
} mmp_transpond_rxadj_t;


/*
 field CHNLRXADJ_ALL
-------------------------------
 
 field=TRANSPOND::CHNLRXADJ_ALL

*/
typedef struct
{
	int16_t adjustment[41];     /* Receive sensitivity adjustment of all channels, from -100 to +100, laid out as 41 consecutive 16-bit values corresponding to the channels 0-40. */
} mmp_transpond_rxadjall_t;


/*
 Structures populated on demand by get_smartbatt_info() API call
 
 cmdresult=STD::GETSMARTBATTDATA

*/
typedef struct
{
	uint16_t batt_mode;     /* SBS register BatteryMode() (0x03) */
	int16_t temperature;     /* SBS register Temperature() (0x08) */
	uint16_t voltage;     /* SBS register Voltage() (0x09) */
	int16_t current;     /* SBS register Current() (0x0A) */
	int16_t avg_current;     /* SBS register AverageCurrent() (0x0B) */
	uint16_t max_error;     /* SBS register MaxError() (0x0C) */
	uint16_t batt_charge;     /* SBS register RelativeStateOfCharge() (0x0D) */
	uint16_t abs_charge;     /* SBS register AbsoluteStateOfCharge() (0x0E) */
	uint16_t rem_capacity;     /* SBS register RemainingCapacity() (0x0F) */
	uint16_t full_chg_capacity;     /* SBS register FullChargeCapacity() (0x10) */
	int16_t mins_to_empty;     /* SBS register AverageTimeToEmpty() (0x12) */
	int16_t mins_to_full;     /* SBS register AverageTimeToFull() (0x13) */
	uint16_t batt_status;     /* SBS register BatteryStatus() (0x16) */
	uint16_t cycle_count;     /* SBS register CycleCount() (0x17) */
	uint16_t design_capacity;     /* SBS register DesignCapacity() (0x18) */
	uint16_t mfg_date;     /* SBS register ManufactureDate() (0x1B) */
	uint16_t serno;     /* SBS register SerialNumber() (0x1C) */
} smartbatt_info_t;



#endif  /* _MMP_DEFS_H_ */
