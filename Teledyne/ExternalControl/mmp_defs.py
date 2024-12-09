
import struct

class MMPMessage(type):
    fmt = ""
    args = ()
    defaults = ()
    def __init__(self, data = None):
        if data:
            self.deserialize(data)
        self.struct = struct.Struct(self.fmt)

    def size(self):
        return self.struct.size
        
    def deserialize(self, data):
        values = self.struct.unpack(data)
        for a,v in zip(self.args,values):
            setattr(self, a,v)

    def serialize(self):
        vals = [getattr(self, v) for v in self.args]
        return self.struct.pack(vals)
    
    @classmethod
    def FromDict(cls, **kwargs):
        ret = cls()
        for a,d in zip(cls.args, cls.defaults):
            if a in kwargs:
                setattr(ret, a, kwargs[a])
            else:
                setattr(ret, a, d)
        
class mmp_const_t:
	#  Acoustic trigger maximum assert time that can be specified in acoustic message
	#   system=constant
	ACOUTRIG_MAX_ASSERT_SECS  = 2790

	#  Sentinel for acoustic battery charge response
	#   system=constant
	ACOU_BATT_CHG_UNAVAIL     = 0xFF

	#   system=constant
	ACOU_SAMPLE_CELL_SIZE     = 1024

	#   system=constant
	AES_MAX_KEY_SIZE          = 16

	#   system=constant
	BATTERY_STATUS_COUNTS_PER_VOLT = 2

	#   system=constant
	BATTERY_STATUS_VOLT_RANGE = 60

	#   system=constant
	BATTLIFE_NUM_VOLT_READINGS = 2

	#   system=constant
	BATT_EXTDC                = 4

	#   system=constant
	BATT_IBPS                 = 1

	#   system=constant
	BATT_LIPRIMARY            = 3

	#   system=constant
	BATT_SMART                = 2

	#   system=constant
	BATT_STD                  = 0

	#   system=constant
	BOOTLOADER_BASE           = 0x00000

	#   system=constant
	BOOTLOADER_SIZE           = 0x1ffff

	#   system=constant
	BURN_WIRE_WAIT_TIME       = 36000

	#   system=constant
	CPBOARD_ALWAYS            = 2

	#   system=constant
	CPBOARD_OFF               = 0

	#   system=constant
	CPBOARD_PROGRAM           = 3

	#   system=constant
	CPBOARD_PWRSAVE           = 1

	#   system=constant
	DFLT_MAX_NUM_SMART_BATTS  = 4

	#   system=constant
	DIAG_BASE                 = 0x60000

	#  Datalogger record store locations
	#   system=constant
	DLOG_CFG_STORE_INTERNAL   = 0

	#   system=constant
	DLOG_CFG_STORE_SDHC       = 1

	#   system=constant
	DLOG_SRCFLAG_ALL          = 0xFFFF

	#  system=constant
	FEAT_KEY_PREFIX_LEN       = 9

	#   system=constant
	GEOPRO_MAX_ADDR           = 120

	#   system=constant
	GEOPRO_MIN_ADDR           = 1

	#   system=constant
	GET_1CHIRP_RNG_RESPONSE_DOWN = 1

	#   system=constant
	GET_1CHIRP_RNG_RESPONSE_UP = 0

	#   system=constant
	GET_RANGE_TYPE_ABSOLUTE   = 0

	#   system=constant
	GET_RANGE_TYPE_COMPASS    = 2

	#   system=constant
	GET_RANGE_TYPE_DEPTH      = 11

	#   system=constant
	GET_RANGE_TYPE_HIGH_ABS   = 4

	#   system=constant
	GET_RANGE_TYPE_HIGH_COM   = 8

	#   system=constant
	GET_RANGE_TYPE_HIGH_ELV   = 7

	#   system=constant
	GET_RANGE_TYPE_HIGH_INC   = 5

	#   system=constant
	GET_RANGE_TYPE_HIGH_PCH   = 9

	#   system=constant
	GET_RANGE_TYPE_HIGH_REL   = 6

	#   system=constant
	GET_RANGE_TYPE_HIGH_RLL   = 10

	#   system=constant
	GET_RANGE_TYPE_HOMING     = 14

	#   system=constant
	GET_RANGE_TYPE_PROBE      = 13

	#   system=constant
	GET_RANGE_TYPE_RANGE_ONLY = 15

	#   system=constant
	GET_RANGE_TYPE_RELATIVE   = 1

	#   system=constant
	GET_RANGE_TYPE_TILT       = 3

	#   system=constant
	GPSSYNC_GGA               = 2

	#   system=constant
	GPSSYNC_NONE              = 0

	#   system=constant
	GPSSYNC_RMC               = 3

	#   system=constant
	GPSSYNC_ZDA               = 1

	#   system=constant
	IMAGE_BASE                = 0x20000

	#   system=constant
	IMAGE_SIZE                = 0x7ffff

	#   system=constant
	INVALID_BEARING           = 0xFFFF

	#  system=constant
	MAX_FEAT_KEYS             = 32

	#   system=constant
	MAX_TRANSPORT_ADDR        = 4

	#   system=constant
	MAX_TRANSPORT_DST         = 3

	#  system=constant
	MD5_ASCII_KEY_LEN         = 32

	#  system=constant
	MD5_KEY_LEN               = 16

	#   system=constant
	MIN_TRANSPORT_ADDR        = 1

	#   system=constant
	MIN_TRANSPORT_DST         = 0

	#   system=constant
	MMP_ACOU_FLAG_ACKONLY     = 0x0001

	#  system=constant
	MMP_FEAT_KEY_LEN          = 42

	#  
	#  system=constant
	MMP_HDRERR_LOWSNRACQ      = 0x7FFF

	#   system=constant
	MMP_MAX_DEVICE_LEN_REQUEST = 4096

	#  Highest value of a notification counter before it wraps
	#   system=constant
	MMP_NTFY_COUNT_MAX        = 0xFF

	#   system=constant
	MMP_SREG_ALL_SIZE         = 60

	#   system=constant
	MODEM_APP_VERSION_MAJOR   = 8

	#   system=constant
	MODEM_APP_VERSION_MINOR   = 15

	#   system=constant
	MODEM_APP_VERSION_REVISION = 3

	#   system=constant
	MOD_FH_160_MA             = 66

	#   system=constant
	MOD_FH_80_JA              = 68

	#   system=constant
	MOD_FH_80_MA              = 67

	#   system=constant
	MOD_FH_80_MR              = 65

	#   system=constant
	MOD_FH_80_STD             = 1

	#   system=constant
	MOD_FH_80_WH              = 64

	#   system=constant
	MOD_MFSK_1066             = 6

	#   system=constant
	MOD_MFSK_1066x2           = 26

	#   system=constant
	MOD_MFSK_1200             = 7

	#   system=constant
	MOD_MFSK_1200x2           = 27

	#   system=constant
	MOD_MFSK_140              = 2

	#   system=constant
	MOD_MFSK_140x2            = 22

	#   system=constant
	MOD_MFSK_2400             = 8

	#   system=constant
	MOD_MFSK_2400x2           = 28

	#   system=constant
	MOD_MFSK_300              = 3

	#   system=constant
	MOD_MFSK_300x2            = 23

	#   system=constant
	MOD_MFSK_600              = 4

	#   system=constant
	MOD_MFSK_600x2            = 24

	#   system=constant
	MOD_MFSK_800              = 5

	#   system=constant
	MOD_MFSK_800x2            = 25

	#   system=constant
	MOD_PSK_10240             = 12

	#   system=constant
	MOD_PSK_15360             = 13

	#   system=constant
	MOD_PSK_2560              = 9

	#   system=constant
	MOD_PSK_5120              = 10

	#   system=constant
	MOD_PSK_7680              = 11

	#   system=constant
	NULL_BOOT_IMAGE           = 0xffffffff

	#   system=constant
	NULL_TRANSPORT_ADDR       = 0

	#   system=constant
	NUM_TRANSPORT_ADDRS       = 5

	#   system=constant
	NUM_TRANSPORT_DSTS        = 4

	#   system=constant
	PM_PROC_RATE              = 20

	#   system=constant
	PPS_MODE_CSAC             = 3

	#   system=constant
	PPS_MODE_EXT_FALL         = 4

	#   system=constant
	PPS_MODE_EXT_RISE         = 1

	#   system=constant
	PPS_MODE_INT_RTC          = 2

	#   system=constant
	PPS_MODE_MAX_NUM          = 5

	#   system=constant
	PPS_MODE_OFF              = 0

	#   system=constant
	PROBE_DATA_SIZE           = 512

	#   system=constant
	RELEASE_WAIT_TIME         = 800

	#   system=constant
	REMOTE_AGC_HISTORY_SIZE   = 10

	#   system=constant
	REMOTE_REGISTERS_SIZE     = 21

	#   system=constant
	RESPONDER_MODE_FALL       = 2

	#   system=constant
	RESPONDER_MODE_OFF        = 0

	#   system=constant
	RESPONDER_MODE_RISE       = 1

	#   system=constant
	RESPONDER_MODE_SEND       = 3

	#   system=constant
	SEND_RANGE_TAT_FAST       = 1

	#   system=constant
	SEND_RANGE_TAT_SLOW       = 0

	#   system=constant
	SEND_RANGE_TAT_VFAST      = 2

	#   system=constant
	SERIAL_BOOT_IMAGE_U1      = 0xfffffffe

	#   system=constant
	SERIAL_BOOT_IMAGE_U2      = 0xfffffffd

	#   system=constant
	SREG_NORM                 = 60

	# eliminated neighbor table
	#   system=constant
	SREG_TOTAL                = 60

	#   system=constant
	SVN_REVNO                 = 19863

	#   system=constant
	TRANSPOND_MAX_RX_WIDTH    = 15

	#   system=constant
	TRANSPOND_MIN_RX_WIDTH    = 5

	#   system=constant
	TRANSPORT_DST_P1          = 1

	#   system=constant
	TRANSPORT_DST_P2          = 2

	#   system=constant
	TR_TX_MAX_PWR             = 8

	#   system=constant
	TTS_MAX_DETECT_THRESH     = 999

	#   system=constant
	TTS_MIN_DETECT_THRESH     = 10

	#   system=constant
	TXPWR_UNAVAIL             = 0x7FFF

	#   system=constant
	URI_CLR_CODE              = 76

	#   system=constant
	URI_MAX_CMD_CODE          = 75

	#   system=constant
	URI_MAX_CODE              = 76

	#   system=constant
	URI_MAX_RLS_CODE          = 63

	#   system=constant
	URI_MIN_CMD_CODE          = 64

	#   system=constant
	URI_MIN_CODE              = 0

	#   system=constant
	URI_MIN_RLS_CODE          = 0

	#   system=constant
	USERIMAGE_BASE            = 0x10000

	#   system=constant
	USERIMAGE_MASK            = 0x0FFFF

	#   system=constant
	UTS_MAX_NUM_SMART_BATTS   = 2

	#   system=constant
	XPND_MAX_FREQ_LF          = 16000

	#   system=constant
	XPND_MAX_TX_FREQ          = 70000

	#   system=constant
	XPND_MIN_FREQ_LF          = 7000

	#   system=constant
	XPND_MIN_TX_FREQ          = 1000

	#   system=constant
	XPND_STEP                 = 250

	#   system=constant
	XPND_TTS_FREQS            = 41

	#   system=constant
	_IO_TONE_MODE_HPR400      = 2

	#  defines for USBLmode config prarameter
	#   system=constant
	_IO_TONE_MODE_NONE        = 0

	#   system=constant
	_IO_TONE_MODE_TONE        = 1

	#   system=constant
	_NUM_TILT_AXES            = 3

	#   system=constant
	_TILT_AP_XNEG             = 1

	#   system=constant
	_TILT_AP_XPOS             = 0

	#   system=constant
	_TILT_AP_YNEG             = 3

	#   system=constant
	_TILT_AP_YPOS             = 2

	#   system=constant
	_TILT_AP_ZNEG             = 5

	#   system=constant
	_TILT_AP_ZPOS             = 4

	#  Defines of the three tilt/acceleration axes
	#   system=constant
	_TILT_AXIS_X              = 0

	#   system=constant
	_TILT_AXIS_Y              = 1

	#   system=constant
	_TILT_AXIS_Z              = 2

	#   system=constant
	_TILT_POLARITY_NEG        = 1

	#   system=constant
	_TILT_POLARITY_POS        = 0

	#   system=constant
	_UDB_VERSION_MAJOR        = 8

	#   system=constant
	_UDB_VERSION_MINOR        = 15

	#   system=constant
	_UDB_VERSION_REVISION     = 3


#  
class mmp_version_num_t:
	MMP_VERSION_MAJOR                        = 2
	MMP_VERSION_MINOR                        = 5



#  
class mmp_misc_t:
	MMP_BUFSIZE                              = 4224    # Maximum MMP buffer size in bytes
	MMP_RESPONSE_TIMEOUT                     = 1500    # Time in msec for an MMP response to come back
	MMP_NMEA_BUFSIZE                         = 103    # Maximum NMEA sentence size + 21 (Hemisphere, for example, exceeds the 82 character spec)



#  
class mmp_sentinel_t:
	MMP_SENTINEL                             = '@'    # Separator for serial MMP commands
	NMEA_SENTINEL                            = '$'



#  
#  subfield=mmp_gsxn_t::type
class mmp_type_t:
	MMP_GET                                  = 'g'    # Indicates an MMP GET operation
	MMP_SET                                  = 's'    # Indicates an MMP SET operation
	MMP_EXECUTE                              = 'x'    # Indicates an MMP EXEC operation
	MMP_NOTIFY                               = 'n'    # Indicates an MMP NOTIFY operation



# *************************
#  MMP Command Sections
# *************************
#  
#  system=cmdsect
#  subfield=mmp_cmd_result_t::cmdsect
class mmp_cmdsect_t:
	MMP_CMDSECT_NULL                         = 0x00    # Null command section (unused)
	MMP_CMDSECT_STD                          = 0x01    # Standard commands and operations supported on most modem-based platforms
	MMP_CMDSECT_RNGRLS                       = 0x02    # Ranging and releasing operations
	MMP_CMDSECT_DATALOG                      = 0x04    # Commands for Data Logger
	MMP_NUM_CMDSECT                          = 0x06



# *************************
#  MMP Subsystems
# *************************
#  
#  system=subsys
class mmp_subsys_t:
	MMP_SUBSYS_IFACE                         = 0x00    # MMP interface configuration and control data/notifications
	MMP_SUBSYS_SREG                          = 0x01    # S-Registers
	MMP_SUBSYS_DECKBOX                       = 0x02    # Deck box-specific data/notifications
	MMP_SUBSYS_DATA                          = 0x04    # Data packets and other general notifications
	MMP_SUBSYS_TRANSPOND                     = 0x05    # Transponding and ranging data/notifications
	MMP_SUBSYS_TIME                          = 0x06    # Time- and date-related data/notifications
	MMP_SUBSYS_CFG_ALL                       = 0x3F    # Special subsystem for retrieving all values in a config section: set the field with the CFG section number to get or MMP_SUBSYS_CFG_ALL to get all sections.  If used with a SET operation and MMP_SUBSYS_CFG_ALL is used for both the the subsys and field, the configuration database will be written to flash.
	CFG_SECT_COPROC                          = 0x40    # Co-processor board
	CFG_SECT_DATALOG                         = 0x41    # On-board datalogger
	CFG_SECT_MODEM                           = 0x42    # Modem functionality
	CFG_SECT_RELEASE                         = 0x44    # Release functionality
	CFG_SECT_SERIAL                          = 0x46    # UART paramters
	CFG_SECT_SYSTEM                          = 0x47    # System parameters
	CFG_SECT_TEST                            = 0x48    # Test functionality
	CFG_SECT_VERSION                         = 0x49    # Version information
	CFG_SECT_XPND                            = 0x4A    # Transpond control
	CFG_SECT_DAT                             = 0x4B    # (DAT ONLY) Directional Acoustic Transponder configuration
	CFG_SECT_NAV                             = 0x4C    # Navigation and Positioning
	CFG_SECT_RECORDER                        = 0x4D    # In-band acoustic data recorder configuration
	CFG_SECT_TRANSPORT                       = 0x50    # Transport layer routing/tagging information
	CFG_SECT_AIN                             = 0x52
	CFG_SECT_PRESSURE                        = 0x53
	CFG_SECT_USBL                            = 0x54    # (DAT ONLY) USBL control section
	CFG_SECT_JANUS                           = 0x56    # JANUS configuration parameters
	MMP_NUM_SUBSYS                           = 0x57



#  
#  subfield=mmp_gsxn_t::xid
class mmp_xid_sentinel_t:
	MMP_XID_NULL                             = 0
	MMP_XID_FIRST                            = 1
	MMP_XID_LAST                             = 255



# ==============================================================================
#  Generic values/ranges for MMP structure subfields
# ==============================================================================
#  
#  subfield=mmp_data_trrc_status_t::tr_band_fail
#  subfield=mmp_data_trrc_status_t::tr_read_fail
#  subfield=mmp_data_trrc_status_t::rc_band_fail
#  subfield=mmp_data_trrc_status_t::rc_read_fail
#  subfield=mmp_pwrsense_t::charging
#  subfield=mmp_spkr_phones_vol_t::mute
#  subfield=mmp_rngrls_transpond_t::rcv_only
#  subfield=mmp_rngrls_transpond_t::silent
#  subfield=mmp_network_onistate_t::enable
#  subfield=mmp_data_fpm_boot_failure_t::failure
#  subfield=mmp_iface_ntfy_count_t::enable
#  subfield=mmp_std_contxmit_enable_t::enable
#  subfield=mmp_time_syncinfo_t::qualifying
#  subfield=mmp_time_syncinfo_t::ext_time
class mmp_bool_t:
	MMP_FALSE                                = 0    # False/Off/Disabled
	MMP_TRUE                                 = 1    # True/On/Enabled



#  
#  subfield=mmp_cfg_paramval_t::val_or_len
class mmp_various_t:
	various_values                           = 0    # Values here should be appropriate for the subsystem::field being set/gotten.



#  
#  subfield=mmp_spkr_phones_vol_t::volume
class mmp_u8_bit_range_t:
	val_8_bit                                = 0    # 0 to 255



#  
class mmp_u16_bit_range_t:
	val_16_bit                               = 0    # 0 to 65535



#  
class mmp_s16_bit_range_t:
	signed_val_16_bit                        = 0    # -32768 to 32767



#  
class mmp_u32_bit_range_t:
	val_32_bit                               = 0    # 0 to 4,294,967,295



#  
class mmp_s32_bit_range_t:
	signed_val_32_bit                        = 0    # -2,147,483,648 to 2,147,483,647



#  
#  subfield=mmp_cfg_paramval_t::type
class cfg_param_type_t:
	CFG_NUM16                                = 0    # A signed 16-bit integer
	CFG_NUM32                                = 1    # A signed 32-bit integer
	CFG_STR                                  = 2    # A variable length character string
	CFG_BOOL                                 = 3    # A Boolean value (0 for false, 1 for true)
	CFG_FIXED                                = 4    # A 32-bit integer representing a fractional number with 0.0001 precision.  Divide this integer value by 10000 to obtain the true fractional value it represents.
	CFG_ENUM                                 = 5    # A 32-bit signed enumerated value.  This config parameter is restricted to a finite set of pre-defined values dependent on which configuration field it applies to.
	CFG_CSTM                                 = 6    # A custom format with layout dependent on the configuration field it applies to.
	CFG_BITMASK                              = 7    # A format allowing the sum of valid values



#  Sect COPROC
# ============
#  
#  subsys=CFG_SECT_COPROC
class cfg_coproc_param_enum_t:
	CFG_COPROC_CPBOARD                       = 0    # Indicate power mode of coprocessor board
	CFG_COPROC_FDFWDTAPS                     = 1    # PSK number of forward taps
	CFG_COPROC_FDBCKTAPS                     = 2    # PSK number of backward taps
	CFG_NUM_COPROC_PARAMS                    = 3



#  Sect DATALOG
# =============
#  
#  subsys=CFG_SECT_DATALOG
class cfg_datalog_param_enum_t:
	CFG_DATALOG_ACDATA                       = 0    # Log acoustically received data to datalogger
	CFG_DATALOG_ACSTATS                      = 1    # Log acoustic statistics to datalogger
	CFG_DATALOG_RINGBUF                      = 2    # Configure datalogger as flat (stop when full) or circular (oldest records discarded for newer)
	CFG_DATALOG_SUBBLKS                      = 3
	CFG_DATALOG_LOGMODE                      = 4    # The record-partitioning mode for the data logger: time, character, or size based.
	CFG_DATALOG_SENTINEL                     = 5    # The ASCII value of a sentinel character that will trigger closure of a discrete record in the data logger
	CFG_DATALOG_CHRCOUNT                     = 6    # The number of characters that must be reached in order to trigger closure of a discrete record in the data logger
	CFG_DATALOG_LOGSTORE                     = 7    # Indicates which storage medium the data logger points to (internal or external SDHC)
	CFG_NUM_DATALOG_PARAMS                   = 8



#  Sect MODEM
# =============
#  
#  subsys=CFG_SECT_MODEM
class cfg_modem_param_enum_t:
	CFG_MODEM_DATARETRY                      = 0    # Acoustic data retry mode
	CFG_MODEM_ACRSPTMOUT                     = 1    # Acoustic response timeout
	CFG_MODEM_OPMODE                         = 2    # Operation mode
	CFG_MODEM_DEVENABLE                      = 3    # Device enable line behavior
	CFG_MODEM_UNUSED1                        = 4
	CFG_MODEM_FWDDELAY                       = 5    # Data packet forwarding delay
	CFG_MODEM_UNUSED2                        = 6
	CFG_MODEM_LOCALADDR                      = 7    # Modem local address
	CFG_MODEM_PRNTHEX                        = 8    # Print modem data hexadecimal
	CFG_MODEM_REMOTEADDR                     = 9    # Modem default remote address
	CFG_MODEM_RXPKTTYPE                      = 10    # Receive packet type
	CFG_MODEM_SHOWBADDATA                    = 11    # Determine whether to process or discard data with bit errors
	CFG_MODEM_STARTTONES                     = 12    # Control playing of startup tones upon boot
	CFG_MODEM_TXRATE                         = 13    # Acoustic transmit bitrate of data
	CFG_MODEM_TXPOWER                        = 14    # Acoustic transmit power level
	CFG_MODEM_WAKETONES                      = 15    # Control sending of wakeup preamble tones.
	CFG_MODEM_RSVD1                          = 16    # Unused
	CFG_MODEM_INPUTMODE                      = 17    # Select the UART input mode for data transfer and data logging (single, dual)
	CFG_MODEM_SMARTRETRY                     = 18    # Control use of SmartRetry functionality for corrupted packet transmissions when data retries are enabled
	CFG_MODEM_L2PROTOCOL                     = 19    # Layer 2 Protocol selector
	CFG_MODEM_HEADERRATE                     = 20    # Acoustic transmit bitrate rate of header
	CFG_MODEM_DOMAINKEY                      = 21    # Domain key that is used to create comms exclusivity groups
	CFG_MODEM_AUTODETECTHDR                  = 22    # Determine whether to enable auto detect of header or use setting in HeaderRate parm
	CFG_MODEM_CHIRP_THRESHOLD                = 23    # threshold adjustment for chirp detection
	CFG_MODEM_TXATTEN                        = 24    # Sets the maximum acoustic SPL output; the @TxPower parameter range is scaled according to this parameter.
	CFG_MODEM_ADDRGROUP                      = 25    # Moves LocalAddr to another group
	CFG_MODEM_APCNOISSEL                     = 26
	CFG_MODEM_APCALPHSM                      = 27
	CFG_MODEM_APCALPHSM2                     = 28
	CFG_MODEM_APCMAXTXP                      = 29
	CFG_MODEM_APCMINTXP                      = 30
	CFG_MODEM_ACKMODE_DONOTUSE               = 31
	CFG_NUM_MODEM_PARAMS                     = 32



#  Sect NETWORK
# =============
#  
#  subsys=CFG_SECT_NETWORK
class cfg_network_param_enum_t:
	CFG_NETWORK_RTSATTMPTS                   = 0    # Number or RTS Attempts
	CFG_NETWORK_RESERVE1                     = 1    # Formerly Data Retries
	CFG_NETWORK_NUMBCSTPING                  = 2    # Number of broadcast pings to try in a broadcast ping command.  1 - 255 (255 = ping indefinitely) 
	CFG_NETWORK_PINGRETRY                    = 3    # Number of ping retries if no response
	CFG_NETWORK_PKTBUFF                      = 4    # Packet buffering enable/disable
	CFG_NETWORK_PKTDELAY                     = 5    # Inter-packet delay, in seconds
	CFG_NETWORK_FXDRSPTIME                   = 6    # Fixed Acoustic response time for network packets
	CFG_NETWORK_FXDRSPCTL                    = 7    # Fixed response timer control enable/disable
	CFG_NETWORK_MAXPINGRSP                   = 8    # Maximum Ping Response (1-16)
	CFG_NETWORK_UNUSED1                      = 9
	CFG_NETWORK_BRIEFLOWRATE                 = 10    # Control use of 140 bps on handshakeless protocol retransmits 
	CFG_NETWORK_BRIEFPKTSZ                   = 11    # Packet size threshold for using handshakeless protocol
	CFG_NETWORK_NSMA                         = 12    # Neighbor Sense Multi-Access enable/disable
	CFG_NETWORK_DATAACKS                     = 13    # Data Acknowledgements Boolean
	CFG_NETWORK_BRIEFACKS                    = 14    # Acknowledgements Boolean for Brief Mode exchanges
	CFG_NUM_NETWORK_PARAMS                   = 15



#  Sect TRANSPORT
# ===============
#  
#  subsys=CFG_SECT_TRANSPORT
class cfg_transport_param_enum_t:
	CFG_TRANSPORT_L4ENB                      = 0    # Global enable or disable for transport layer activity
	CFG_TRANSPORT_TPMODE                     = 1    # Enable mode for transport layer addressing information (force always on or track with InputMode)
	CFG_TRANSPORT_SRCP1                      = 2    # Transport address to be applied to transmitted packets originating on UART 0
	CFG_TRANSPORT_SRCP2                      = 3    # Transport address to be applied to transmitted packets originating on UART 1
	CFG_TRANSPORT_DST1                       = 16    # Delivery destination for received packets tagged with transport address 1
	CFG_TRANSPORT_DST2                       = 17    # Delivery destination for received packets tagged with transport address 2
	CFG_TRANSPORT_DST3                       = 18    # Delivery destination for received packets tagged with transport address 3
	CFG_TRANSPORT_DST4                       = 19    # Delivery destination for received packets tagged with transport address 4



#  Sect RELEASE
# =============
#  
#  subsys=CFG_SECT_RELEASE
class cfg_release_param_enum_t:
	CFG_RELEASE_FSKRLSDUR                    = 0    # Duration (seconds) to play Benthos FSK release tones
	CFG_RELEASE_LSTCOMMSCNT                  = 1    # Lost communication count (15 second increments)
	CFG_RELEASE_RLSCODE                      = 2    # Release code to trigger this release (valid on release models only)
	CFG_RELEASE_UNUSED1                      = 3
	CFG_RELEASE_TIMEDRELEASE                 = 4    # Timeout count for timed releases
	CFG_RELEASE_MOTORTYPE                    = 5    # Type of motor used in this release; only valid for releases which can support differing motor type
	CFG_RELEASE_RLSMINENATIME                = 6    # Minimum on time for Release Enable
	CFG_RELEASE_RLSMAXENATIME                = 7    # Maximum on time for Release Enable
	CFG_RELEASE_ACOUTRIGTERM                 = 8    # Terminating conditions for acoustic triggers
	CFG_NUM_RELEASE_PARAMS                   = 9



#  Sect SERIAL
# =============
#  
#  subsys=CFG_SECT_SERIAL
class cfg_serial_param_enum_t:
	CFG_SERIAL_P1BAUD                        = 0    # Port 1 baud rate
	CFG_SERIAL_P1ECHOCHAR                    = 1    # Port 1 echo (full/half duplex)
	CFG_SERIAL_P1FLOWCTL                     = 2    # Port 1 flow control
	CFG_SERIAL_P1IDLEPOL                     = 3    # Port 1 idle polarity
	CFG_SERIAL_P1PROTOCOL                    = 4    # Port 1 comms protocol
	CFG_SERIAL_P1STRIPB7                     = 5    # Port 1 strip bit 7
	CFG_SERIAL_P1NOSLEEP                     = 6    # Port 1 not counted towards activity for sleep
	CFG_SERIAL_P2BAUD                        = 7    # Port 2 baud rate
	CFG_SERIAL_P2ECHOCHAR                    = 8    # Port 2 echo (full/half duplex)
	CFG_SERIAL_P2FLOWCTL                     = 9    # Port 2 flow control
	CFG_SERIAL_P2IDLEPOL                     = 10    # Port 2 idle polarity
	CFG_SERIAL_P2STRIPB7                     = 11    # Port 2 strip bit 7
	CFG_SERIAL_P2NOSLEEP                     = 12    # Port 2 not counted towards activity for sleep
	CFG_SERIAL_P1MODE                        = 13    # Port 1 cooking mode
	CFG_SERIAL_P2MODE                        = 14    # Port 2 cooking mode
	CFG_SERIAL_P2PROTOCOL                    = 15    # Port 2 on RS232 or CMOS
	CFG_SERIAL_LPFLOWCTL                     = 16    # allow RTS lines to be off on lowpower, follow HW flow control or remain on
	CFG_SERIAL_P1PROMPT                      = 17    # control prompt display level on Port 1
	CFG_SERIAL_P2PROMPT                      = 18    # control prompt display level on Port 2
	CFG_NUM_SERIAL_PARAMS                    = 19



#  Sect SYSTEM
# =============
#  
#  subsys=CFG_SECT_SYSTEM
class cfg_system_param_enum_t:
	CFG_SYSTEM_AUXINP                        = 0    # Enable auxiliary acoustic input
	CFG_SYSTEM_ASCIIBIN                      = 1    # Received data output in standard ASCII or as a hex byte dump
	CFG_SYSTEM_BANDWIDTH                     = 2
	CFG_SYSTEM_CARRFREQ                      = 3    # Center carrier frequency (sets acoustic band)
	CFG_SYSTEM_COMPMDMRST                    = 4    # Compact modem reset: 
	CFG_SYSTEM_CMWAKEHIB                     = 5    # Compact modem wakeup hibernate time (formerly last digit of S-10 when >300)
	CFG_SYSTEM_CMWAKELISTEN                  = 6    # Compact modem wakeup active listen time (formerly middle digit of S-10 when >400)
	CFG_SYSTEM_HALFBW                        = 7    # Half bandwidth modulation: 1 = Normal, 2 = half bandwidth
	CFG_SYSTEM_FHTHRESH                      = 8    # Frequency Hop receive threshold
	CFG_SYSTEM_RLSTYPE                       = 9    # Configuration of release type (factory-set)
	CFG_SYSTEM_SYNCPPS                       = 10    # Mode for 1 PPS clock signal syncing
	CFG_SYSTEM_VERBOSE                       = 11    # console status verbosity
	CFG_SYSTEM_WAKETHRESH                    = 12
	CFG_SYSTEM_AUXOUT                        = 13    # Control behavior of auxiliary acoustic output: either default behavior (speaker/phones for UDB, copies of samples for others), or force copies of outbound samples to aux port.
	CFG_SYSTEM_UNUSED1                       = 14
	CFG_SYSTEM_VOLCONT                       = 15    # Use an analog linear pot on EXT_SENSE1_ADC to control speaker and headphone volume
	CFG_SYSTEM_CMFASTWAKE                    = 16    # Enables fast wake from hibernate ability on compact modem (receiving side) and UDB (sending side).
	CFG_SYSTEM_NAMEFORMAT                    = 17
	CFG_SYSTEM_IDLETIMER                     = 18    # Low-power idle timer
	CFG_SYSTEM_PROMPT                        = 19
	CFG_SYSTEM_SYNCOUT                       = 20    # copy RTC PPS out on BIN_OUT_0
	CFG_SYSTEM_PULLUP0                       = 21    # BIN_IN_0 pullup 
	CFG_SYSTEM_PULLUP1                       = 22    # BIN_IN_1 pullup
	CFG_SYSTEM_MINOPVOLT                     = 23    # The operating voltage threshold below which transmissions will be automatically reduced in power to prevent brown-out resets 
	CFG_SYSTEM_BATTERYTYPE                   = 24    # The type of battery being used to power the modem (Standard alkaline, Smart Li+, Lithium primary, etc.)
	CFG_SYSTEM_BATTERYCAPACITY               = 25    # The capacity of the installed battery pack in watt-hours.  Only for certain release products with battery monitoring capability.
	CFG_SYSTEM_BATTERYMFGDATE                = 26    # Manufacture date of the battery specifying month and year. Only for certain release products with battery monitoring capability.
	CFG_SYSTEM_TILTAXIS                      = 27    # The axis of the built-in accelerometer to be used as the tilt/pitch reference
	CFG_SYSTEM_PWRONTIMER                    = 28    # The Power On Timer used for Releases
	CFG_SYSTEM_AWAKETIMER                    = 29    # The Awake Timer used for Releases
	CFG_SYSTEM_ARWAKEHIB                     = 30    # The Acoustic Release Hibernate Sleep period
	CFG_SYSTEM_RXSENS                        = 31    # hydrophone sensitivity in dB (uPa) for reference only
	CFG_SYSTEM_AWAKEPOWER                    = 32    # keep TR board 12V and 3.3V on when in active receive
	CFG_SYSTEM_TXSENS                        = 33    # Transmt Voltage Response, SPL in dB(uPa) at 1m at full power
	CFG_SYSTEM_TXINTERP                      = 34    # Used for the Tx interpolation
	CFG_SYSTEM_IOMODE0                       = 35    # Set behavior of external IO expansion signal 0 (UCT only)
	CFG_NUM_SYSTEM_PARAMS                    = 36



#  Sect TEST
# =============
#  
#  subsys=CFG_SECT_TEST
class cfg_test_param_enum_t:
	CFG_TEST_DBGLVL                          = 0    # Test debug level
	CFG_TEST_RCVALL                          = 1    # Receive all packets (sniffer mode)
	CFG_TEST_RSPDELAY                        = 2    # Test response delay
	CFG_TEST_PKTECHO                         = 3    # Test packet echo
	CFG_TEST_PKTSIZE                         = 4    # Test packet size
	CFG_TEST_UNUSED1                         = 5
	CFG_TEST_SIMACDLY                        = 6    # Simulated variable acoustic delay, in milliseconds
	CFG_TEST_TXSATURATE                      = 7    # Special test mode for enabling saturation on transmit
	CFG_TEST_UNUSED2                         = 8
	CFG_NUM_TEST_PARAMS                      = 9



#  Sect VERSION
# =============
#  
#  subsys=CFG_SECT_VERSION
class cfg_version_param_enum_t:
	CFG_VERSION_SWAPPNAME                    = 0    # Software application name string
	CFG_VERSION_SWVERSION                    = 1    # Software version string
	CFG_VERSION_DBVERSION                    = 2    # Configuration database version string
	CFG_NUM_VERSION_PARAMS                   = 3



#  Sect XPND
# =============
#  
#  subsys=CFG_SECT_XPND
class cfg_xpnd_param_enum_t:
	CFG_XPND_RXFREQ                          = 0    # Frequency to listen for response pings (applicable only to platforms without Multi-Rx capability)
	CFG_XPND_RXLOCKOUT                       = 1    # Ping response lockout, in milliseconds
	CFG_XPND_RXTONEDUR                       = 2    # Receive pulse width (enumerated: 0 = 12.5 ms, 1 = 6.25 ms, 5 = 5 ms ... 15 = 15 ms)
	CFG_XPND_TAT                             = 3    # Transpond turn-around time at remote node, in tenths of a millisecond
	CFG_XPND_TXTONEDUR                       = 4    # Interrogation pulse width (enumerated: 0 = 12.5 ms, 1 = 6.25 ms, 5 = 5 ms ... 15 = 15 ms)
	CFG_XPND_RXTHRESH                        = 5    # Receive detection threshold for transponder pings, in standard deviations above mean noise level
	CFG_XPND_AGCREF                          = 6    # The AGC level that should be set when the avg. background noise energy in the center of the band is at 1.  Lower values lower the noise floor allowing for more signal head-room; higher values raise it allowing more resolution for detecting weak signals.
	CFG_XPND_RESPFREQ                        = 7    # Response tone sent on reception of tone set by CFG_XPND_RXFREQ after delay of CFG_XPND_TAT.
	CFG_XPND_LBLMODE                         = 8    # Defines the action taken on the reception of a downward HFM chirp
	CFG_XPND_XPNDEMUTAT                      = 9    # Transponder emulator response turn-around time in tenths of a millisecond
	CFG_XPND_XPNDEMUMODE                     = 10    # Transponder emulator mode
	CFG_XPND_HPR400CHAN                      = 11    # Set the HPR400 channel
	CFG_XPND_RESPONDER                       = 12    # Enable Pulse responder mode
	CFG_XPND_CHIRP_RESP                      = 13    # Define response to be requested as a reply to at%rr command
	CFG_XPND_BANDWIDTH                       = 14    # Set bandwidth for processing
	CFG_XPND_LOGRESULTS                      = 15    # Enable logging to data logger
	CFG_XPND_GAPSRX                          = 16    # Gaps family C code to recieve
	CFG_XPND_GAPSTX                          = 17    # Gaps family C code to respond with
	CFG_XPND_GAPSWAKE                        = 18    # Gaps family C code to respond with
	CFG_NUM_XPND_PARAMS                      = 19



#  Sect DAT
# =============
# 
#  subsys=CFG_SECT_DAT
class cfg_dat_param_enum_t:
	CFG_DAT_PREGAIN                          = 0    # gain for DAT channels relative to main, in dB
	CFG_DAT_ROTATION                         = 1    # offset of acoustic zero to vehicle center line
	CFG_DAT_VERBOSE                          = 2    # bits defining DAT report fields 
	CFG_DAT_RXONDAT                          = 3    # main receiver uses DAT hydrophone
	CFG_DAT_WRAPRANGE                        = 4    # for one way flight times of multiple seconds 
	CFG_DAT_ORIENTATION                      = 5    # transducer points up or down
	CFG_DAT_PHASEA                           = 6    # phase offset for reciever module A
	CFG_DAT_PHASEB                           = 7    # phase offset for reciever module B
	CFG_DAT_PHASEC                           = 8    # phase offset for reciever module C
	CFG_DAT_PHASED                           = 9    # phase offset for reciever module D
	CFG_DAT_BEARINGRESP                      = 10    # bearing response type
	CFG_DAT_VTHRESH                          = 11    # vector quality threshold
	CFG_DAT_MIN_ELEV                         = 12    # minimum acceptable elevation
	CFG_DAT_MAX_ELEV                         = 13    # maximum acceptable elevation
	CFG_DAT_PHASEREF                         = 14    # replica to use as reference for phase offset detection
	CFG_DAT_ARRIVAL                          = 15    # Special test mode DAT for first or peak arrival
	CFG_NUM_DAT_PARAMS                       = 16



#  Sect USBL
# =============
# 
#  subsys=CFG_SECT_USBL
class cfg_usbl_param_enum_t:
	CFG_USBL_FORMAT                          = 0    # USBL bearing reporting format
	CFG_USBL_DEPTH_QUERY                     = 1    # enable to query depth on every USBL cycle
	CFG_USBL_REPEAT_QUERY                    = 2    # number of rapid range in every USBL cycle
	CFG_USBL_AUTO_QUERY                      = 3    # set to start acoustic of pulse cycles on boot
	CFG_USBL_AUTO_DELAY                      = 4    # delay between cycles in seconds
	CFG_USBL_XDCER_DEPTH                     = 5    # depth of USBL head below surface in tenths of a meter
	CFG_NUM_USBL_PARAMS                      = 6



#  Sect NAV
# =============
#  
#  subsys=CFG_SECT_NAV
class cfg_nav_param_enum_t:
	CFG_NAV_LATITUDE                         = 0    # Latitude  in millionths of a degree
	CFG_NAV_LONGITUDE                        = 1    # Longitude in millionths of a degree
	CFG_NAV_GPSALT                           = 2    # absolute altitude relative to WGS84
	CFG_NAV_ALTITUDE                         = 3    # altitude above sea floor in meters
	CFG_NAV_DEPTH                            = 4    # depth below sea level in meters
	CFG_NAV_COMPASS                          = 5    # compass bearing in degrees
	CFG_NAV_PITCH                            = 6    # pitch in degrees
	CFG_NAV_ROLL                             = 7    # roll in degrees
	CFG_NAV_CSOUND                           = 8    # speed of sound in m/s
	CFG_NAV_REPLY_DATA                       = 9    # additional data fields for position information
	CFG_NAV_HEADOFFSET                       = 10    # offset of compass heading to vehicle center line
	CFG_NAV_SYNCRANGING                      = 11    # Enable one-way ranging on data transmissions when sychronized to external 1PPS sources
	CFG_NAV_PITCHOFFSET                      = 12    # offset of AHRS pitch to transducer plane
	CFG_NAV_ROLLOFFSET                       = 13    # offset of AHRS roll to transducer plane
	CFG_NAV_GPSSYNCMSG                       = 14    # The type of GPS sentence, if any, that may be used to adjust the modem's system clock
	CFG_NUM_NAV_PARAMS                       = 15



#  Sect RECORDER
# =============
#  
#  subsys=CFG_SECT_RECORDER
class cfg_recorder_param_enum_t:
	CFG_RECORDER_FRONTEND                    = 0
	CFG_RECORDER_RECMODE                     = 1    # recording mode for automatic recording
	CFG_RECORDER_RECFORMAT                   = 2
	CFG_RECORDER_NAMEFORMAT                  = 3    # format of names for recorded audio files
	CFG_RECORDER_RXSENS                      = 4
	CFG_NUM_RECORDER_PARAMS                  = 5



#  Sect AIN
# =============
#  
#  subsys=CFG_SECT_AIN
class cfg_ain_param_enum_t:
	CFG_AIN_POLLRATE                         = 0    # time interval for automated polling
	CFG_AIN_1NMEAS                           = 1    # number of measurements on chan 1
	CFG_AIN_1STRTDLY                         = 2    # delay in 1st reading after turn-on (ch1)
	CFG_AIN_1RPTDLY                          = 3    # delay in each additional reading (ch1)
	CFG_AIN_1TYPE                            = 4    # type of sensor on chan 1
	CFG_AIN_2NMEAS                           = 5    # number of measurements on chan 2
	CFG_AIN_2STRTDLY                         = 6    # delay in 1st reading after turn-on (ch2)
	CFG_AIN_2RPTDLY                          = 7    # delay in each additional reading (ch2)
	CFG_AIN_2TYPE                            = 8    # type of sensor on chan 2
	CFG_AIN_3NMEAS                           = 9    # number of measurements on chan 3
	CFG_AIN_3STRTDLY                         = 10    # delay in 1st reading after turn-on (ch3)
	CFG_AIN_3RPTDLY                          = 11    # delay in each additional reading (ch3)
	CFG_AIN_4NMEAS                           = 12    # number of measurements on chan 4
	CFG_AIN_4STRTDLY                         = 13    # delay in 1st reading after turn-on (ch4)
	CFG_AIN_4RPTDLY                          = 14    # delay in each additional reading (ch4)
	CFG_AIN_5NMEAS                           = 15    # number of measurements on chan 5
	CFG_AIN_5STRTDLY                         = 16    # delay in 1st reading after turn-on (ch5)
	CFG_AIN_5RPTDLY                          = 17    # delay in each additional reading (ch5)
	CFG_AIN_6NMEAS                           = 18    # number of measurements on chan 6
	CFG_AIN_6STRTDLY                         = 19    # delay in 1st reading after turn-on (ch6)
	CFG_AIN_6RPTDLY                          = 20    # delay in each additional reading (ch6)
	CFG_NUM_AIN_PARAMS                       = 21



#  Sect PRESSURE
# =============
#  
#  subsys=CFG_SECT_PRESSURE
class cfg_pressure_param_enum_t:
	CFG_PRESSURE_AINCHNL                     = 0    # Analog input channel where the pressure transducer is connected, or 0 if none
	CFG_PRESSURE_METERSPERPSI                = 1    # Conversion factor for pressure, number of meters per psi
	CFG_PRESSURE_ATMOFFSET                   = 2    # Atmospheric pressure in PSI to be subtracted from pressure reading when converting to depth below sea level
	CFG_PRESSURE_PSI                         = 3    # The pressure in pounds per square inch (psi) as set by user or updated from pressure gauge
	CFG_NUM_PRESSURE_PARAMS                  = 4



#  Sect JANUS
# =============
#  
#  subsys=CFG_SECT_JANUS
class cfg_janus_param_enum_t:
	CFG_JANUS_CLASSUSERID                    = 0    # DPSK board enable - control for the feature
	CFG_JANUS_APPTYPE                        = 1    # Logging of DPSK Data
	CFG_JANUS_MACTHRESH                      = 2    # DPSK Acoustic Ouput Format
	CFG_NUM_JANUS_PARAMS                     = 3



#  Account privilege levels
#   system=constant
class cmd_privlev_t:
	CMD_PRIVLEV_SAFE                         = 0
	CMD_PRIVLEV_USER                         = 1
	CMD_PRIVLEV_UPDATE                       = 2
	CMD_PRIVLEV_FACTORY                      = 3
	CMD_PRIVLEV_DIAG                         = 4
	CMD_PRIVLEV_SYS                          = 6
	CMD_PRIVLEV_ROOT                         = 7
	NUM_CMD_PRIVLEVS                         = 8



#  
#  subfield=mmp_binio_t::value
class enable_t:
	DISABLE                                  = 0    # Disabled, off, low, etc.
	ENABLE                                   = 1    # Enabled, on, high, etc.



#  
class modem_feature_t:
	FEAT_MODEM_DATA                          = 0    # Transmit and receive data packets with other modems
	FEAT_MULTI_XPND_RX                       = 1    # Simultaneous receive of transpond pings on more than one frequency
	FEAT_DAT_BEARING                         = 2    # Bearing calculations use Directional Acoustic Transponder
	FEAT_WAVE_PLAY                           = 3    # User ability to use the 'play' and 'tone' commands for custom waveform transmission
	FEAT_DUAL_UART                           = 4    # Enable dual serial port mode for transmitting acoustic packets and logging data
	FEAT_INBAND_RECORD                       = 5    # Enable in band acoustic recording to SD card
	FEAT_LOW_OUTPUT_PWR                      = 9    # enable a(n approximate) -24dB attenuation to be switched in that shifts the entire @TxPower range
	FEAT_UTS_GNSS_SUPPORT                    = 10    # enable external GNSS functionality on UTS platforms that can support it
	FEAT_GAPS_EMULATION                      = 11    # enable ability to act as a GAPS transponder
	NUM_FEATS                                = 12



#  
#  subfield=mmp_data_feat_key_status_t::available_features
#  subfield=mmp_data_feat_key_status_t::expected_features
#  subfield=mmp_data_feat_key_status_t::enabled_features
#  subfield=mmp_data_feat_key_status_t::unauthorized_features
class modem_feature_bitflag_t:
	FEAT_FLAG_MODEM_DATA                     = 0x01    # Bit flag for Modem Data feature
	FEAT_FLAG_MULTI_XPND_RX                  = 0x02    # Bit flag for multi ping transpond receive feature
	FEAT_FLAG_DAT_BEARING                    = 0x04    # Bit flag for DAT Bearing feature
	FEAT_FLAG_WAVE_PLAY                      = 0x08    # Bit flag for arbitrary waveform play feature
	FEAT_FLAG_DUAL_UART                      = 0x10    # Bit flag for dual serial port input feature
	FEAT_FLAG_INBAND_RECORD                  = 0x20    # Bit flag for inband recorder feature
	FEAT_FLAG_LOW_OUTPUT_PWR                 = 0x200    # Bit flag for enabling -24 dB attenuation mode on transmit
	FEAT_FLAG_UTS_GNSS_SUPPORT               = 0x400    # Bit flag for enabling external GNSS devices on the UTS platforms that can support it
	FEAT_FLAG_GAPS_EMULATION                 = 0x800    # Bit flag for enabling GAPS emulation



#  
#  subfield=mmp_datalog_dump_t::source
#  subfield=mmp_datalog_cmdresult_dump_t::source
#  subfield=mmp_datalog_cmdresult_source_counts_t::source
#  subfield=mmp_datalog_remote_getdlogblk_t::source
class datalog_source_t:
	DLOG_SRC_P1                              = 0    # Serial port 1
	DLOG_SRC_P2                              = 1    # Serial port 2
	DLOG_SRC_RES1                            = 2
	DLOG_SRC_RES2                            = 3
	DLOG_SRC_AC                              = 4    # Acoustic transmission data
	DLOG_SRC_XP                              = 5    # Transponder data
	DLOG_SRC_DI                              = 6    # Diagnostic data
	DLOG_SRC_MMP                             = 7    # Data inserted via MMP message
	DLOG_SRC_DEV                             = 8    # Data inserted via /dev/logger system device
	DLOG_SRC_AIN                             = 9    # Data from analog input
	DLOG_NUM_SRCS                            = 10
	DLOG_SRC_ALL                             = 0xFF    # Sentinel for any/all sources



#  Datalogger source flags, for use in some MMP messages and function calls.  Each flag corresponds to (1 << enum_equivalent)
#  
#  subfield=mmp_datalog_srcinfo_t::source_flags
#  subfield=mmp_datalog_cmdresult_list_t::source_flags
#  subfield=mmp_datalog_cmdresult_srcinfo_t::source_flags
#  subfield=mmp_datalog_cmdresult_find_t::source_flags
class datalog_source_flag_t:
	DLOG_SRCFLAG_P1                          = 0x01    # Bit flag for Serial port 1
	DLOG_SRCFLAG_P2                          = 0x02    # Bit flag for Serial port 2
	DLOG_SRCFLAG_AC                          = 0x10    # Bit flag for Acoustic packets
	DLOG_SRCFLAG_XP                          = 0x20    # Bit flag for Transponder activity
	DLOG_SRCFLAG_DI                          = 0x40    # Bit flag for Diagnostic information (internally generated)
	DLOG_SRCFLAG_MMP                         = 0x80    # Bit flag for Data inserted via MMP directive
	DLOG_SRCFLAG_DEV                         = 0x100    # Bit flag for Data inserted via the /dev/logger interface
	DLOG_SRCFLAG_AIN                         = 0x200    # Bit flag for Data from the analog input
	DLOG_SRCFLAG_TRUNC                       = 0x2000    # Bit flag indicating this record was truncated
	DLOG_SRCFLAG_RECOV                       = 0x4000    # Bit flag indicating this record was recovered at boot



#  
#  subfield=mmp_datalog_cmdresult_list_t::storeloc
#  subfield=mmp_datalog_cmdresult_srcinfo_t::storeloc
class datalog_store_t:
	DLOG_STORE_INTERNAL                      = 0    # On-board flash memory
	DLOG_STORE_SDHC                          = 1    # External SDHC card



#  
#  subfield=mmp_axis_tilt_response_t::axis_w_pol
class tilt_axis_and_polarity_t:
	TILT_AP_XPOS                             = 0    # X axis, positive polarity
	TILT_AP_XNEG                             = 1    # X axis, negative polarity
	TILT_AP_YPOS                             = 2    # Y axis, positive polarity
	TILT_AP_YNEG                             = 3    # Y axis, negative polarity
	TILT_AP_ZPOS                             = 4    # Z axis, positive polarity
	TILT_AP_ZNEG                             = 5    # Z axis, negative polarity



#  
#  subfield=mmp_data_nav_status_t::location
#  subfield=mmp_data_nav_status_t::heading
#  subfield=mmp_data_nav_status_t::attitude
class nav_validity_t:
	NAV_NOT_VALID                            = 0    # data from stored values
	NAV_INT_VALID                            = 1    # data from internal source
	NAV_EXT_VALID                            = 2    # data from external source



#  JANUS Class IDs
#  
#  subfield=mmp_data_janus_packet_t::class_userid
class JANUS_classid_t:
	JANUS_CLASSID_EMERGENCY                  = 0
	JANUS_CLASSID_UWGPS                      = 1
	JANUS_CLASSID_UWAIS                      = 2
	JANUS_CLASSID_PINGER                     = 3
	JANUS_CLASSID_FIXEDVMOORING              = 4
	JANUS_CLASSID_RIGIDVSTRUCTURE            = 5
	JANUS_CLASSID_HAZARDMARKER               = 6
	JANUS_CLASSID_CHANNELMARKER              = 7
	JANUS_CLASSID_WINDGENERATOR              = 8
	JANUS_CLASSID_WAVEGENERATOR              = 9
	JANUS_CLASSID_SOLARGENERATOR             = 10
	JANUS_CLASSID_CAPABILITIES               = 15
	JANUS_CLASSID_NATOREF                    = 16
	JANUS_CLASSID_VENILIA                    = 17
	JANUS_CLASSID_CC_MONGOLIA                = 187
	JANUS_CLASSID_CC_NEWZEALAND              = 188
	JANUS_CLASSID_CC_REPUBLICOFKOREA         = 189
	JANUS_CLASSID_CC_PAKISTAN                = 190
	JANUS_CLASSID_CC_JAPAN                   = 191
	JANUS_CLASSID_CC_IRAQ                    = 192
	JANUS_CLASSID_CC_AUSTRALIA               = 193
	JANUS_CLASSID_CC_AFGHANISTAN             = 194
	JANUS_CLASSID_CC_UNITEDARABEMIRATES      = 195
	JANUS_CLASSID_CC_KUWAIT                  = 196
	JANUS_CLASSID_CC_QATAR                   = 197
	JANUS_CLASSID_CC_BAHRAIN                 = 198
	JANUS_CLASSID_CC_TUNISIA                 = 199
	JANUS_CLASSID_CC_MOROCCO                 = 200
	JANUS_CLASSID_CC_MAURITANIA              = 201
	JANUS_CLASSID_CC_JORDAN                  = 202
	JANUS_CLASSID_CC_ISRAEL                  = 203
	JANUS_CLASSID_CC_EGYPT                   = 204
	JANUS_CLASSID_CC_ALGERIA                 = 205
	JANUS_CLASSID_CC_UZBEKISTAN              = 206
	JANUS_CLASSID_CC_UKRAINE                 = 207
	JANUS_CLASSID_CC_TURKMENISTAN            = 208
	JANUS_CLASSID_CC_MACEDONIA               = 209
	JANUS_CLASSID_CC_TAJIKISTAN              = 210
	JANUS_CLASSID_CC_SWITZERLAND             = 211
	JANUS_CLASSID_CC_SWEDEN                  = 212
	JANUS_CLASSID_CC_SERBIA                  = 213
	JANUS_CLASSID_CC_MONTENEGRO              = 214
	JANUS_CLASSID_CC_MOLDOVA                 = 215
	JANUS_CLASSID_CC_MALTA                   = 216
	JANUS_CLASSID_CC_KYRGYZREPUBLIC          = 217
	JANUS_CLASSID_CC_KAZAKHSTAN              = 218
	JANUS_CLASSID_CC_IRELAND                 = 219
	JANUS_CLASSID_CC_GEORGIA                 = 220
	JANUS_CLASSID_CC_FINLAND                 = 221
	JANUS_CLASSID_CC_BOSNIAHERZEGOVINA       = 222
	JANUS_CLASSID_CC_BELARUS                 = 223
	JANUS_CLASSID_CC_AZERBAIJAN              = 224
	JANUS_CLASSID_CC_AUSTRIA                 = 225
	JANUS_CLASSID_CC_ARMENIA                 = 226
	JANUS_CLASSID_CC_UNITEDSTATES            = 227
	JANUS_CLASSID_CC_UNITEDKINGDOM           = 228
	JANUS_CLASSID_CC_TURKEY                  = 229
	JANUS_CLASSID_CC_SPAIN                   = 230
	JANUS_CLASSID_CC_SLOVENIA                = 231
	JANUS_CLASSID_CC_SLOVAKIA                = 232
	JANUS_CLASSID_CC_ROMANIA                 = 233
	JANUS_CLASSID_CC_PORTUGAL                = 234
	JANUS_CLASSID_CC_POLAND                  = 235
	JANUS_CLASSID_CC_NORWAY                  = 236
	JANUS_CLASSID_CC_NETHERLANDS             = 237
	JANUS_CLASSID_CC_LUXEMBOURG              = 238
	JANUS_CLASSID_CC_LITHUANIA               = 239
	JANUS_CLASSID_CC_LATVIA                  = 240
	JANUS_CLASSID_CC_ITALY                   = 241
	JANUS_CLASSID_CC_ICELAND                 = 242
	JANUS_CLASSID_CC_HUNGARY                 = 243
	JANUS_CLASSID_CC_GREECE                  = 244
	JANUS_CLASSID_CC_GERMANY                 = 245
	JANUS_CLASSID_CC_FRANCE                  = 246
	JANUS_CLASSID_CC_ESTONIA                 = 247
	JANUS_CLASSID_CC_DENMARK                 = 248
	JANUS_CLASSID_CC_CZECHREPUBLIC           = 249
	JANUS_CLASSID_CC_CROATIA                 = 250
	JANUS_CLASSID_CC_CANADA                  = 251
	JANUS_CLASSID_CC_BULGARIA                = 252
	JANUS_CLASSID_CC_BELGIUM                 = 253
	JANUS_CLASSID_CC_ALBANIA                 = 254
	JANUS_CLASSID_JANUSSPECIAL               = 255
	JANUS_NUM_CLASSIDS                       = 256



#  
#  subfield=mmp_data_lowpower_t::waketype
class wake_type_t:
	WAKE_TYPE_NULL                           = 0    # No wakeup
	WAKE_TYPE_UART                           = 1    # Wake up from UART input
	WAKE_TYPE_TIME                           = 2    # Wake up due to expiry of pre-set timer
	WAKE_TYPE_ACOU                           = 3    # Wake up due to acoustic wake tones
	WAKE_TYPE_ALARM                          = 4    # Wake up due RTC alarm
	WAKE_TYPE_BATTLIFE                       = 5    # Wake up to update battery life monitoring
	WAKE_TYPE_NO_SLEEP                       = 6    # Sleep mode not defined - did not sleep



# *************************
#  DATALOG Commands
# *************************
#  
#  cmdsect=DATALOG
class mmp_datalog_cmd_t:
	MMP_DATALOG_CMD_CLEAR                    = 0x00    # Clears the data logger buffer
	MMP_DATALOG_CMD_SIZE                     = 0x01    # Report the number of bytes in the data logger
	MMP_DATALOG_CMD_READ_DATA                = 0x02    # Read back the data logger buffer
	MMP_DATALOG_CMD_READ_PAGE                = 0x03    # Read back a 4 kbyte page
	MMP_DATALOG_CMD_READ_SECTOR              = 0x04    # Read back a 256 byte sector
	MMP_DATALOG_CMD_WRITE_DATA               = 0x05    # Write data in to the data logger
	MMP_DATALOG_CMD_SEEK                     = 0x06    # Set the read pointer to a specific location
	MMP_DATALOG_CMD_TELL                     = 0x07    # Report the position of the read pointer
	MMP_DATALOG_CMD_LIST                     = 0x08    # Retrieve general information about the local or remote data logger
	MMP_DATALOG_CMD_FIND                     = 0x09    # Find records in the local or remote data logger using the command line query syntax
	MMP_DATALOG_CMD_DUMP                     = 0x0A    # Dump the local or remote data logger based on byte offset and length (on all-source or per-source basis)
	MMP_DATALOG_CMD_SRCINFO                  = 0x0B    # Get information pertaining to one or more data sources in the logger (total bytes and number of records)
	MMP_DATALOG_CMD_REMOTE_GETDLOGBLK        = 0x0C    # Request a block of up to 4K from a remote modem's data logger with bit flags indicating which cells are valid/corrupted
	MMP_NUM_DATALOG_CMD                      = 0x0D



#  
#  subfield=mmp_datalog_cmdresult_write_data_t::status
class mmp_datalog_cmdresult_write_data_status_t:
	MMP_DATALOG_WRITE_ERR_DISABLED           = -4    # Data logger writes disabled due to incompatible file schema in flash
	MMP_DATALOG_WRITE_FILE_ERROR             = -3    # Error trying to open/delete/access a file
	MMP_DATALOG_WRITE_ERR_DATALOG_FULL       = -2    # No more room left in data logger
	MMP_DATALOG_WRITE_ERR_STORE_TO_FLASH     = -1    # Unable to store to flash	
	MMP_DATALOG_WRITE_SUCCESSFUL             = 0    # A successful write



# *************************
#  RNGRLS Commands
# *************************
#  
#  cmdsect=RNGRLS
class mmp_rngrls_cmd_t:
	MMP_RNGRLS_CMD_TRANSPOND                 = 0x00    # Issue interrogation or silent ping and enter transpond receive mode for the system default amount of time
	MMP_RNGRLS_CMD_RANGE                     = 0x01    # Obtain the range to another modem
	MMP_RNGRLS_CMD_RELEASE_STATUS            = 0x02    # Check the release mechanism status on a remote modem
	MMP_RNGRLS_CMD_SMART_RELEASE             = 0x03    # Issue a release command to a remote Benthos SMART release (SR-50, SR-100, etc.)
	MMP_RNGRLS_CMD_BURNWIRE                  = 0x04    # Issue a release command to a remote Benthos SMART modem (SM-75, OEM boardset w/ burn wire, etc.)
	MMP_RNGRLS_CMD_FSK_RELEASE               = 0x05    # Issue a release command to a remote Benthos FSK release (Model 865, etc.)
	MMP_RNGRLS_CMD_EDGETECH_RELEASE          = 0x06    # Issue a command to an EdgeTech/ORE/EG&G release
	MMP_RNGRLS_CMD_URI_RELEASE               = 0x07    # Issue a command to a University of Rhode Island release/device 
	MMP_RNGRLS_CMD_FLASH_XPNDADJ             = 0x08    # Save per-frequency transpond sensitivity threshold adjustments to flash
	MMP_RNGRLS_CMD_BEARING                   = 0x09    # Obtain bearing from a DAT
	MMP_RNGRLS_CMD_GEOPRO_RELEASE            = 0x0A    # Issue a command to a GeoPro (Germany) release unit
	MMP_RNGRLS_CMD_NAVDATA                   = 0x0B    # Obtain position information from a remote modem
	MMP_RNGRLS_CMD_CHANNEL_PROBE             = 0x0C    # probe channel for multipath
	MMP_RNGRLS_CMD_RSERIES_RANGE             = 0x0D    # Ranging specific to a Teledyne Benthos next-gen release
	MMP_RNGRLS_CMD_RSERIES_ACTIVATE          = 0x0E    # Activate an R Series release
	MMP_RNGRLS_CMD_RSERIES_HIBERNATE         = 0x0F    # Hibernate an R Series release
	MMP_RNGRLS_CMD_RSERIES_XPND_MODE         = 0x10    # Set the transpond reSponse mode in a remote R Series unit
	MMP_RNGRLS_CMD_STD_XPND_MODE             = 0x11    # Set the transpond reSponse mode in a remote standard unit
	MMP_RNGRLS_CMD_RSERIES_DB_UNLOCK         = 0x12    # Enable R Series transponding
	MMP_RNGRLS_CMD_RSERIES_DB_LOCK           = 0x13    # Disable R Series transponding
	MMP_RNGRLS_CMD_RSERIES_RELEASE           = 0x14    # Issue a release command to a remote Benthos R Series release
	MMP_RNGRLS_CMD_RESPONDER_RANGE           = 0x15    # Issue pulse on binary out 1 to a responder
	MMP_RNGRLS_CMD_TRANSPOND_W_TIMEOUT       = 0x16    # Issue interrogation or silent ping and enter transpond receive mode for a specified amount of time
	MMP_RNGRLS_CMD_RANGE_W_TIMEOUT           = 0x17    # Issue a range request with a timeout specified (not system @AcRspTmOut default)
	MMP_RNGRLS_CMD_SPECTRUM_MODE             = 0x18    # Enter or exit spectrum analysis mode, with update rate in 0.5 second increments (or 0 to disable)
	MMP_RNGRLS_CMD_RANGE_USBL_REPEAT         = 0x19    # (DAT ONLY) Issue a range request for a define number of responses
	MMP_RNGRLS_CMD_ABSREL                    = 0x1A    # Request the high precision absolute and relative bearing
	MMP_RNGRLS_CMD_ACOU_SAMPLE               = 0x1D    # Record a 1 second basebanded in-band acoustic sample
	MMP_RNGRLS_CMD_ABSCMPDEP                 = 0x1E    # Request the high precision compass and depth
	MMP_RNGRLS_CMD_ACOUSTIC_TRIGGER          = 0x1F    # Send a trigger code to a remote device to activate the acoustic trigger signal
	MMP_RNGRLS_CMD_BEARING_W_TIMEOUT         = 0x20    # Obtain bearing from a DAT with a timeout specified (not system @AcRspTmOut default)
	MMP_NUM_RNGRLS_CMD                       = 0x21



#  
#  subfield=mmp_rngrls_bearing_t::type
#  subfield=mmp_rngrls_navdata_t::type
class mmp_rngrls_bearing_type_t:
	MMP_RNGRLS_BEARING_ABS                   = 0    # relative to North
	MMP_RNGRLS_BEARING_REL                   = 1    # relative to DAT body
	MMP_RNGRLS_BEARING_COM                   = 2    # compass heading
	MMP_RNGRLS_BEARING_TLT                   = 3    # tilt sensors
	MMP_RNGRLS_BEARING_HIGH_ABS              = 4    # absolute bearing
	MMP_RNGRLS_BEARING_HIGH_INC              = 5    # absolute inclination
	MMP_RNGRLS_BEARING_HIGH_REL              = 6    # relative bearing
	MMP_RNGRLS_BEARING_HIGH_ELV              = 7    # relative elevation
	MMP_RNGRLS_BEARING_HIGH_COM              = 8    # compass heading
	MMP_RNGRLS_BEARING_HIGH_PCH              = 9    # compass pitch
	MMP_RNGRLS_BEARING_HIGH_RLL              = 10    # compass roll
	MMP_RNGRLS_BEARING_DEPTH                 = 11    # depth from pressure transducer
	MMP_RNGRLS_BEARING_PROBE                 = 13    # remote channel probe request
	MMP_RNGRLS_BEARING_HOMING                = 14    # start of terminal homing mode
	MMP_RNGRLS_BEARING_RANGE_ONLY            = 15    # Range only response
	MMP_RNGRLS_BEARING_W_REPLYDATA           = 32    # Add to bearing types to request reply data



#  
#  subfield=mmp_rngrls_bearing_t::tat
class mmp_rngrls_bearing_tat_t:
	MMP_RNGRLS_TAT_SLOW                      = 0    # legacy (slow) 2.4 second turn around
	MMP_RNGRLS_TAT_FAST                      = 1    # standard (fast) 1.6 second turn around
	MMP_RNGRLS_TAT_VFAST                     = 2    # very fast 1.1 second turn around



#  
#  subfield=mmp_rngrls_fsk_param_t::code
class mmp_rngrls_fsk_code_t:
	MMP_RNGRLS_FSK_CODE_A                    = 'A'    # ASCII A - 0x65
	MMP_RNGRLS_FSK_CODE_B                    = 'B'    # ASCII B - 0x66
	MMP_RNGRLS_FSK_CODE_C                    = 'C'    # ASCII C - 0x67
	MMP_RNGRLS_FSK_CODE_D                    = 'D'    # ASCII D - 0x68
	MMP_RNGRLS_FSK_CODE_E                    = 'E'    # ASCII E - 0x69
	MMP_RNGRLS_FSK_CODE_F                    = 'F'    # ASCII F - 0x6A
	MMP_RNGRLS_FSK_CODE_G                    = 'G'    # ASCII G - 0x6B
	MMP_RNGRLS_FSK_CODE_H                    = 'H'    # ASCII H - 0x6C
	MMP_RNGRLS_FSK_CODE_I                    = 'I'    # ASCII I - 0x6D
	MMP_RNGRLS_FSK_CODE_J                    = 'J'    # ASCII J - 0x6E
	MMP_RNGRLS_FSK_CODE_K                    = 'K'    # ASCII K - 0x6F
	MMP_RNGRLS_FSK_CODE_L                    = 'L'    # ASCII L - 0x70
	MMP_RNGRLS_FSK_CODE_M                    = 'M'    # ASCII M - 0x71



#  
#  subfield=mmp_rngrls_channel_probe_param_t::log
class mmp_rngrls_probe_log_t:
	MMP_RNGRLS_PROBE_LOG_NONE                = 0    # no logging
	MMP_RNGRLS_PROBE_LOG_STAT                = 1    # log only statistics
	MMP_RNGRLS_PROBE_LOG_STAT_IMPULSE        = 2    # log statistics and impulse



#  
#  subfield=mmp_rngrls_cmdresult_navdata_t::type
# *************************
class navdata_type_t:
	MMP_REPLY_DATA_NONE                      = 0    # no data replied
	MMP_REPLY_DATA_LATLONG                   = 1    # latitude and longitude 
	MMP_REPLY_DATA_LL_DEPTH                  = 2    # lat, long and depth
	MMP_REPLY_DATA_LL_SEAFLOOR               = 3    # lat, long, depth and altitude above sea floor
	MMP_REPLY_DATA_LL_GPSALT                 = 4    # lat, long, depth and altitude above sea level
	NUM_NAVDATA_TYPES                        = 5



#  
#  subfield=mmp_rngrls_edgetech_param_t::freq_spec
# *************************
class edgetech_freqspec_t:
	EDGETECH_9500_9900                       = 1    # 9500 Hz off, 9900 Hz on
	EDGETECH_9500_10300                      = 2    # 9500 Hz off, 10300 Hz on
	EDGETECH_9500_10700                      = 3    # 9500 Hz off, 10700 Hz on
	EDGETECH_9900_10300                      = 4    # 9900 Hz off, 10300 Hz on
	EDGETECH_9900_10700                      = 5    # 9900 Hz off, 10700 Hz on
	EDGETECH_10300_10700                     = 6    # 10300 Hz off, 10700 Hz on
	NUM_EDGETECH_FREQSPECS                   = 7



# *************************
#  STD Commands
# *************************
#  Do not remove MMP_STD_CMD_RESET or updates from deck box displays may stop working
#  
#  cmdsect=STD
class mmp_std_cmd_t:
	MMP_STD_CMD_INFO                         = 0x00    # Obtain modem build info (similar to ATI shell command)
	MMP_STD_CMD_REMOTE_MMPREQ                = 0x01    # Initiate an acoustic MMP request to another modem.  Remote MMP request should be embedded in the data field (no @ sentinel needed). Not implemented on networking builds.
	MMP_STD_CMD_FLASH_SREGS                  = 0x02    # Save S-registers to flash (soon to be deprecated)
	MMP_STD_CMD_RESET_SREGS                  = 0x03    # Reset S-registers to factory defaults (soon to be deprecated)
	MMP_STD_CMD_REMOTE_SETACOUBAUD           = 0x04    # Set acoustic baud rate on remote modem
	MMP_STD_CMD_REMOTE_SETTXPOWER            = 0x05    # Set transmit power on remote modem
	MMP_STD_CMD_REMOTE_GETSREGS              = 0x06    # Get S-registers from remote modem (soon to be deprecated)
	MMP_STD_CMD_REMOTE_SENDDATA              = 0x07    # Send data packet to remote modem
	MMP_STD_CMD_REMOTE_TESTLINK              = 0x08    # Test acoustic link with remote modem
	MMP_STD_CMD_UPDATE_FIRMWARE              = 0x09    # Begin firmware update cycle
	MMP_STD_CMD_RESET                        = 0x0A    # Reboot the modem
	MMP_STD_CMD_REMOTE_GETBATT               = 0x0B    # Get battery levels on remote modem
	MMP_STD_CMD_REMOTE_CMWAKEUP              = 0x0C    # Issue a compact modem wakeup sequence to a remote compact modem
	MMP_STD_CMD_REMOTE_GETAGCHIST            = 0x0D    # Obtain the AGC history for the last 10 seconds from a remote modem
	MMP_STD_CMD_REMOTE_AUTOBAUD              = 0x0E    # Initiate an auto-baud sequence to a remote modem to set an optimal acoustic baud rate between them
	MMP_STD_CMD_REMOTE_GETBATTCHG            = 0x0F    # Obtain battery charge from remote units with IBPS smart batteries
	MMP_STD_CMD_REMOTE_SENDCMD               = 0x10    # Send command packet to remote modem
	MMP_STD_CMD_TILT_ACCEL                   = 0x11    # Obtain acceleration and tilt values for X/Y/Z axis if function supported on board.  HW_NOT_PRESENT error results if board has no accelerometer. 
	MMP_STD_CMD_AXIS_TILT                    = 0x12    # Obtain overall unit tilt value based upon @TiltAxis configuration parameter.  HW_NOT_PRESENT error results if board has no accelerometer. 
	MMP_STD_CMD_RESET_BATT_METERING          = 0x13    # Reset the battery metering information on this platform, if applicable.
	MMP_STD_CMD_BATT_METER                   = 0x14    # Obtain metering information for the local battery, if supported
	MMP_STD_CMD_REMOTE_GETMETER              = 0x15    # Get battery metering information from a remote unit, if supported
	MMP_STD_CMD_GETBATT                      = 0x16    # Get battery levels from the local modem
	MMP_STD_CMD_GETBATTCHG                   = 0x17    # Obtain battery charge from a local modem with IBPS smart batteries
	MMP_STD_CMD_GETAGCHIST                   = 0x18    # Get the local AGC history buffer
	MMP_STD_CMD_REMOTE_GETONESREG            = 0x19    # Gets the value of a single S-register on a remote modem
	MMP_STD_CMD_REMOTE_SETONESREG            = 0x1A    # Sets and stores a single S-register on a remote modem; response is ACK or ERROR
	MMP_STD_CMD_REMOTE_RESET                 = 0x1B    # Reset a remote modem with a low-level reset instruction (no acknowledgement from remote)
	MMP_STD_CMD_BOARD_TEMP                   = 0x1C    # Obtain the board temperature from one of the built-in thermistors (one on ATM board sets, two on UDB board sets)
	MMP_STD_CMD_REMOTE_SENDBREAK             = 0x1D    # Send a serial break to remote modem
	MMP_STD_CMD_CONT_XMIT_TEST               = 0x1E
	MMP_STD_CMD_SET_REMOTE_GROUP             = 0x1F    # move a remote modem's address into a new address group
	MMP_STD_CMD_GETSMARTBATTDATA             = 0x20    # If smart batteries are supported, get selected parameters from the specified battery.
	MMP_STD_CMD_ADDFEATUREKEY                = 0x21    # Add a feature key to the platform.  CMDRESULT ACK on success, CMDRESULT ERROR if flash store full, BAD_CMDARGS error otherwsise.
	MMP_STD_CMD_DELFEATUREKEY                = 0x22    # Delete a feature key from the platform.  CMDRESULT ACK on success, BAD_CMDARGS error otherwise.
	MMP_STD_CMD_REMOTE_HANGUP                = 0x23    # Send an acoustic "hangup" to a remote node that takes it out of online mode and puts it to sleep/hibernate.  ACK/timeout when sending to individual node, or immediate ACK if sending to a multi-cast address with no acoustic ACK expected.
	MMP_STD_CMD_SENDJANUSPACKET              = 0x24    # Transmit a JANUS packet with pre-encoded ADB and cargo.  CMDRESULT ACK on success, CMDRESULT ERR on failure to validate, or general MMP error otherwise.
	MMP_STD_CMD_WRITE_DEVICE                 = 0x25    # Write to the device
	MMP_STD_CMD_READ_DEVICE                  = 0x26    # Read and clear the device
	MMP_STD_CMD_LEN_DEVICE                   = 0x27    # Length of data in the device
	MMP_STD_CMD_FIND_DEVICE                  = 0x28    # Find the device number from the name
	MMP_NUM_STD_CMD                          = 0x29



#  
#  subfield=mmp_remote_request_t::flags
class mmp_remote_request_flag_t:
	REMOTE_MMP_FLAG_ACKONLY                  = 0x01    # REMOTE_MMPREQ ONLY: requests a simple ACK/NACK from the remote instead of a fully-formed MMP response



#  This enumeration supplements the txpower_t enumeration for the remote_txpwr parameter in mmp_remote_testmsgstats_t
#  
#  subfield=mmp_remote_testmsgstats_t::remote_txpwr
class mmp_remote_testmsgstats_txpwr_t:
	TXPOWER_UNAVAIL                          = 0x7FFF    # No power level available
	TXPOWER_REDUCED_0DB                      = 0    # Reduced output 0 dB (non-standard)
	TXPOWER_REDUCED_3DB                      = -1    # Reduced output -3 dB (non-standard)
	TXPOWER_REDUCED_6DB                      = -2    # Reduced output -6 dB (non-standard)
	TXPOWER_REDUCED_9DB                      = -3    # Reduced output -9 dB (non-standard)
	TXPOWER_REDUCED_12DB                     = -4    # Reduced output -12 dB (non-standard)
	TXPOWER_REDUCED_15dB                     = -5    # Reduced output -15 dB (non-standard)
	TXPOWER_REDUCED_18dB                     = -6    # Reduced output -18 dB (non-standard)



#  
#  subfield=mmp_remote_battcharge_t::charge
#  subfield=mmp_battcharge_t::charge
class mmp_remote_battcharge_charge_t:
	MMP_REMOTE_BATTCHG_UNAVAIL               = 0xFF    # No battery charge information available



# **************************
#  DATA Fields
# **************************
#  
#  subsys=DATA
class mmp_data_fld_t:
	MMP_DATA_FLD_ACK                         = 0x00    # Data ACK from remote modem received
	MMP_DATA_FLD_REMOTE_DATA                 = 0x01    # Data packet from remote modem received
	MMP_DATA_FLD_XMIT_OVERTEMP               = 0x02    # Overtemp condition on transmit
	MMP_DATA_FLD_BURN_COMPLETE               = 0x03    # Release burn-wire burn cycle active, tilt detected (unit release)
	MMP_DATA_FLD_TRRC_STATUS                 = 0x04    # Information on T/R board and RCV module
	MMP_DATA_FLD_FEAT_KEY_STATUS             = 0x05    # Information on feature authorization keys
	MMP_DATA_FLD_REMOTE_HEADER               = 0x06    # Header information on packets received
	MMP_DATA_FLD_TIMESTAMP                   = 0x07    # Timestamp notification for a rx or tx event
	MMP_DATA_FLD_DOPPLER                     = 0x08    # Doppler speed information from tones
	MMP_DATA_FLD_BURN_TIMEOUT                = 0x09    # Release burn-wire cycle timed out with no tilt
	MMP_DATA_FLD_DIRECTIONAL                 = 0x0A    # (DAT ONLY) Information locally from a DAT
	MMP_DATA_FLD_FPM_VERSION                 = 0x0B    # Floating point co-processor module version
	MMP_DATA_FLD_PSK_PKT_NO_COPROC           = 0x0C    # Notification that a PSK packet was received but FPM coprocessor is not present/enabled.
	MMP_DATA_FLD_LOW_POWER                   = 0x0D    # Notification of the modem entering or exiting low power mode
	MMP_DATA_FLD_ACSTATS                     = 0x0E    # Acoustic statistics for the packet being received
	MMP_DATA_FLD_REMOTE_DLOGBLK              = 0x0F    # Data packet from remote modem containing data logger data, with CRC flags
	MMP_DATA_FLD_HEADER_ERROR                = 0x10    # Header received from remote modem with errors; contains acoustic statistics if header decoded, or sentinel value to indicate low SNR acquisition detected
	MMP_DATA_FLD_NAV_STATUS                  = 0x11    # Status of navigation sources (location, heading, attitude)
	MMP_DATA_FLD_RANGE_UPDATE                = 0x12    # Updated range to a remote node determined via acoustic communication  
	MMP_DATA_FLD_FPM_BOOT_FAIL               = 0x13    # Indication of whether a floating point coprocessor that was configured to be present at boot time failed to initialize.  Will always return 0 on platforms that don't support FPM coprocessors.
	MMP_DATA_FLD_RCV_GAIN                    = 0x14    # Gives the RCV module attenuator steps and total gain
	MMP_DATA_FLD_SPECTRUM_STATUS             = 0x15    # Indicates activation or deactivation of the spectrum mode, along with some parameters
	MMP_DATA_FLD_SPECTRUM_DATA               = 0x16    # Energy levels for frequency bins calculated during spectrum mode
	MMP_DATA_FLD_DIRECTIONAL_DEBUG           = 0x17    # (DAT ONLY) Additional debug information locally from a DAT
	MMP_DATA_FLD_TONAL_LOCATOR               = 0x18    # (DAT ONLY) information pertaining to ELP locator
	MMP_DATA_FLD_DIRECTIONAL_LOCDEBUG        = 0x1A    # (DAT ONLY) Additional debug information locally from a DAT pertaining to ELP locator
	MMP_DATA_FLD_JANUS_PACKET                = 0x1B    # JANUS data packet received
	MMP_DATA_FLD_ACOUTRIG_COMPLETE           = 0x1C    # Acoustic trigger cycle completion with confirmation
	MMP_DATA_FLD_ACOUTRIG_TIMEOUT            = 0x1D    # Acoustic trigger cycle complete with no confirmation (timeout)
	MMP_DATA_FLD_RESPBUFFER_XMIT             = 0x1E
	MMP_DATA_FLD_RNGBRG_UPDATE               = 0x1F    # Updated range and bearing to a remote node
	MMP_NUM_DATA_FLD                         = 0x20



#  
#  subfield=mmp_data_timestamp_t::event
class mmp_timestamp_event_t:
	MMP_TIMESTAMP_EVENT_TX                   = 0    # TX
	MMP_TIMESTAMP_EVENT_RX                   = 1    # RX
	MMP_TIMESTAMP_EVENT_TX_SYNC              = 2    # Captured timestamp of external Tx Sync signal



#  
#  subfield=mmp_data_lowpower_t::lpstat
class mmp_lowpower_lpstat_t:
	MMP_LOWPOWER_LPSTAT_EXIT                 = 0    # Signifies exiting low power mode
	MMP_LOWPOWER_LPSTAT_ENTER                = 1    # Signifies entering low power mode



#  
#  subfield=mmp_data_rangeupdate_t::range_type
class mmp_rangeupdate_range_type_t:
	MMP_RANGEUPDATE_TYPE_NULL                = 0    # Null/Unknown range update type
	MMP_RANGEUPDATE_TYPE_ONEWAY              = 1    # One-way range, calculated via scheduled transmission from time-synchronized remote modem 
	MMP_RANGEUPDATE_TYPE_TWOWAY              = 2    # Two-way range, calculated via round-trip packet exchange between two modems 



#  
#  subfield=mmp_spectrum_stat_t::stat
class mmp_spectrum_stat_status_t:
	MMP_SPECTRUM_STAT_OFF                    = 0    # MMP interface exited
	MMP_SPECTRUM_STAT_ON                     = 1    # MMP interface started
	MMP_NUM_SPECTRUM_STAT                    = 2



#  
#  subfield=mmp_data_janus_packet_t::schedule_type
class mmp_janus_schedule_type_t:
	MMP_JANUS_SCHEDULE_NONE                  = 0    # No scheduling present, all 34 bits may be used in the ADB.
	MMP_JANUS_SCHEDULE_RESERVE               = 1    # A reserve interval is being specified according to Annex B of ANEP-87.  Up to 26 bits of ADB data are present.
	MMP_JANUS_SCHEDULE_REPEAT                = 2    # A repeat interval is being specified according to Annec C of ANEP-87.  Up to 26 bits of ADB data are present.



# **************************
#  DECKBOX Fields
# **************************
#  
#  subsys=DECKBOX
class mmp_deckbox_fld_t:
	MMP_DECKBOX_FLD_SPKRVOL                  = 0x00    # Speaker volume
	MMP_DECKBOX_FLD_PHONESVOL                = 0x01    # Headphones volume
	MMP_DECKBOX_FLD_PWRSENSE                 = 0x02    # Power source information
	MMP_DECKBOX_FLD_BATTLEV                  = 0x03    # Internal battery level (rough percentage); a "critical" battery level will trigger a spontaneous MMP notification
	MMP_DECKBOX_FLD_BATTVOLT                 = 0x04    # Internal battery voltage
	MMP_DECKBOX_FLD_MODEL                    = 0x05    # Deck box model
	MMP_DECKBOX_FLD_GPS_RELAY                = 0x06    # GPS pass-through mode on display module (for tunneling external GPS time sync data through to modem - disables most display functions, only supported on some hardware configurations)
	MMP_NUM_DECKBOX_FLD                      = 0x07



#  For use with device sub-field
#  
#  subfield=mmp_pwrsense_t::device
class mmp_deckbox_pwrsense_device_t:
	MMP_DECKBOX_PWRSENSE_DEVICE_BATT         = 0    # Using internal batteries
	MMP_DECKBOX_PWRSENSE_DEVICE_AC           = 1    # Using external AC power
	MMP_DECKBOX_PWRSENSE_DEVICE_AUXDC        = 2    # Using external DC power
	NUM_MMP_DECKBOX_PWRSENSE_DEVICE          = 3



#  For use with charge sub-field, indicates battery level while charging via external AC or DC.
#  These are matched up with the _40, _80, and _100 enums in the BATTLEV_CHARGE subfield.
#  
#  subfield=mmp_pwrsense_t::charge
class mmp_deckbox_pwrsense_charge_t:
	MMP_DECKBOX_PWRSENSE_CHARGE_LT80         = 2    # Battery less than 80% charge 
	MMP_DECKBOX_PWRSENSE_CHARGE_GE80         = 4    # Battery at least 80% charged
	MMP_DECKBOX_PWRSENSE_CHARGE_FULL         = 5    # Battery fully charged
	MMP_DECKBOX_PWRSENSE_CHARGE_OFFSET       = 20    # For use with smart batteries that can report to 1% accuracy: if the charge percentage is equal to or above this value, then subtract the offset and use the number directly.



#  For use with charge sub-field, indicates battery level while rinning on battery.
#  
#  subfield=mmp_battlev_t::charge
class mmp_deckbox_battlev_charge_t:
	MMP_DECKBOX_BATTLEV_CHARGE_0             = 0    # Battery completely drained
	MMP_DECKBOX_BATTLEV_CHARGE_20            = 1    # Battery 20% charge remaining
	MMP_DECKBOX_BATTLEV_CHARGE_40            = 2    # Battery 40% charge remaining
	MMP_DECKBOX_BATTLEV_CHARGE_60            = 3    # Battery 60% charge remaining
	MMP_DECKBOX_BATTLEV_CHARGE_80            = 4    # Battery 80% charge remaining
	MMP_DECKBOX_BATTLEV_CHARGE_100           = 5    # Battery fully charged
	MMP_DECKBOX_BATTLEV_CHARGE_CRITICAL      = 6    # Battery critically low, auto-shut-down impending (triggers spontaneous MMP notification)
	NUM_MMP_DECKBOX_BATTLEV_CHARGE           = 7
	MMP_DECKBOX_BATTLEV_CHARGE_OFFSET        = 20    # For use with smart batteries that can report to 1% accuracy: if the charge percentage is equal to or above this value, then subtract the offset and use the number directly.



#  For use with model sub-field
#  
#  subfield=mmp_udb_model_t::model
class mmp_deckbox_model_t:
	MMP_DECKBOX_MODEL_UNKNOWN                = 0    # Unknown deck box model
	MMP_DECKBOX_MODEL_MODEM                  = 1    # UTS/UDB M variant, fully featured
	MMP_DECKBOX_MODEL_RELEASE                = 2    # UTS/UDB A variant, acoustic releases only
	MMP_DECKBOX_MODEL_MODEM_L3               = 3    # UDB-9000L3 special
	MMP_DECKBOX_MODEL_MODEM_SW               = 4    # UDB-9000SW special
	MMP_DECKBOX_MODEL_MODEM_EXPORT           = 5    # UTS/UDB E variant export model (no multi-frequency transpond receive)
	MMP_DECKBOX_MODEL_MODEM_BONITO           = 6    # UTS/UDB-9400BN modem-enabled with BONITO Open Network Interface to Off-board systems (BONITO)
	MMP_DECKBOX_MODEL_MODEM_DR               = 7    # UDB-9000DR modem-enabled with Data Recorder (OBSOLETE)
	MMP_DECKBOX_MODEL_MODEM_NR               = 8    # UDB-9000NR modem-enabled with NUWC Ranging
	MMP_DECKBOX_MODEL_MODEM_BN               = 9    # UDB-9400BN modem enabled with Benthonet networking
	MMP_DECKBOX_MODEL_MODEM_LITE             = 10    # UTS ML variant, fully featured with "lite" UI
	MMP_DECKBOX_MODEL_MODEM_EXPORT_LITE      = 11    # UTS EL variant, export model with "lite" UI (no multi-frequency transpond receive)
	MMP_DECKBOX_MODEL_RELEASE_LITE           = 12    # UTS AL variant, acoustic release only with "lite" UI
	MMP_DECKBOX_MODEL_ROPELESS_FISHING       = 13    # UTS RF variant, for ropeless fishing applications
	NUM_MMP_DECKBOX_MODEL                    = 14



#  
#  subfield=mmp_gps_relay_t::status
class mmp_gps_relay_mode_t:
	MMP_DECKBOX_GPS_RELAY_DISABLED           = 0
	MMP_DECKBOX_GPS_RELAY_ENABLED            = 1



# **************************
#  HWCTL Fields
# **************************
#  events in this subsystem are interface-specific (only go to inducing interface)
#  
#  subsys=HWCTL
class mmp_hwctl_fld_t:
	MMP_HWCTL_FLD_BINOUT0                    = 0x00    # Set or read the level of binary output 0
	MMP_HWCTL_FLD_BINOUT1                    = 0x01    # Set or read the level of binary output 1
	MMP_HWCTL_FLD_BININ0                     = 0x10    # Read the level of binary input 0
	MMP_HWCTL_FLD_BININ1                     = 0x11    # Read the level of binary input 1



#  
#  subfield=mmp_xdcr_switch_t::which
class mmp_xdcr_swtich_value_t:
	XDCR_UPPER                               = 0    # Upper (top) transducer
	XDCR_LOWER                               = 1    # Lower (bottom) transducer



# **************************
#  IFACE Fields
# **************************
#  events in this subsystem are interface-specific (only go to inducing interface)
#  
#  subsys=IFACE
class mmp_iface_fld_t:
	MMP_IFACE_FLD_MMPSTAT                    = 0x00    # Status of MMP subsystem
	MMP_IFACE_FLD_ERR                        = 0x01    # MMP error notification
	MMP_IFACE_FLD_VERSION                    = 0x02    # Version of MMP protocol running
	MMP_IFACE_FLD_CMDRESULT                  = 0x03    # MMP command (EXECUTE) result notification
	MMP_IFACE_FLD_BLOCKNOTIFY                = 0x04    # Block spontaneous notifications from one or more subsystems.  Used with SET, provide a variable length list of subsystems to block.  Returns a variable-length list of blocked subsystems.  Note that responses will always be received when induced by a direct SET/CMD on an interface even if the subsystem is blocked; this only filters spontaneous notifies. 
	MMP_IFACE_FLD_UNBLOCKNOTIFY              = 0x05    # Allow spontaneous notifications from one or more subsystems.  Used with SET, provide a variable-length list of subsystems to unblock.  Returns a variable-length list of unblocked subsystems. 
	MMP_IFACE_FLD_DSP_SW_VERSION             = 0x06    # DSP firmware version currently running
	MMP_IFACE_FLD_PRIVLEV                    = 0x07    # Privilege level on this MMP interface (requires password only if elevating from current privlev)
	MMP_IFACE_FLD_REMOTE_MMPRESP             = 0x08
	MMP_IFACE_FLD_FEATURE_KEY                = 0x09    # temporarily enable a feature key
	MMP_IFACE_FLD_UNIT_SERNO                 = 0x0A    # Obtain the assembly serial number
	MMP_IFACE_FLD_NTFY_COUNT                 = 0x0B    # Enable, disable, or query the status of appended notification counter (unique on a per-interface basis)
	MMP_IFACE_FLD_NTFY_CKSUM                 = 0x0C    # Enable, disable, or query the status of appended notification XOR checksum
	MMP_IFACE_FLD_AES_USER_KEY               = 0x0D    # Set an AES user key for use with encrypted code images, along with an optional timeout.  If 0xFFFF is provided for the timeout value, the AES key and auto-clear timeouts are cleared.  An INVALID_STATE error will result if an attempt is made to install a new key over an existing one without first clearing it.
	MMP_IFACE_FLD_COMPATIBILITY              = 0x0E    # A compatibility number used for syncing external controllers (such as ReleaseIT display) with a given range of software version.  This number may vary by platform and is intended primarily for Teledyne use.
	MMP_IFACE_FLD_FEATURE_KEY_INVENTORY      = 0x0F    # Get the inventory of installed feature keys
	MMP_IFACE_FLD_GATE_DATA_DIRECTIONAL      = 0x10    # (DAT ONLY) Suppress output of DATA::DIRECTIONAL notify when vector is below vthesh.
	MMP_NUM_IFACE_FLD                        = 0x11



#  
#  subfield=mmp_iface_stat_t::stat
class mmp_iface_stat_status_t:
	MMP_IFACE_STAT_EXITED                    = 0    # MMP interface exited
	MMP_IFACE_STAT_STARTED                   = 1    # MMP interface started
	MMP_NUM_IFACE_STAT                       = 2



#  
#  subfield=mmp_sfl_err_t::err
class mmp_iface_err_t:
	MMP_IFACE_ERR_NULL                       = 0x00    # Null error code
	MMP_IFACE_ERR_TIMEOUT                    = 0x01    # Operation has timed out
	MMP_IFACE_ERR_BAD_SUBSYS                 = 0x02    # Bad subsystem in GET/SET request
	MMP_IFACE_ERR_BAD_FIELD                  = 0x03    # Bad field in GET/SET request
	MMP_IFACE_ERR_BAD_VALUE                  = 0x04    # Bad value in GET/SET request
	MMP_IFACE_ERR_PARSE                      = 0x05    # Error parsing serial stream
	MMP_IFACE_ERR_BAD_CMDSECT                = 0x06    # Bad command section in EXEC request
	MMP_IFACE_ERR_BAD_CMD                    = 0x07    # Bad command in EXEC request
	MMP_IFACE_ERR_BAD_CMDARGS                = 0x08    # Bad arguments to command in EXEC request
	MMP_IFACE_ERR_MULTICMD                   = 0x09    # More than one EXEC operation in single transaction
	MMP_IFACE_ERR_DEVICE_BUSY                = 0x0A    # Modem too busy to process request
	MMP_IFACE_ERR_NOTIFY_ONLY                = 0x0B    # Field not accessible with GET/SET, spontaneous NOTIFY only
	MMP_IFACE_ERR_NO_RESOURCE                = 0x0C    # Resources not available to process request
	MMP_IFACE_ERR_UNMODIFIABLE               = 0x0D    # Value may not be modified with a SET
	MMP_IFACE_ERR_PERMISSION                 = 0x0E    # Insufficient permission level to carry out operation
	MMP_IFACE_ERR_INVALID_STATE              = 0x0F    # The modem is not in a state that can validly process the request
	MMP_IFACE_ERR_FEAT_NOT_ENABLED           = 0x10    # The requested operation requires feature key activation, but the key is not installed
	MMP_IFACE_ERR_NOT_IMPLEMENTED            = 0x11    # The requested operation is recognized but is not yet implemented in the MMP engine
	MMP_IFACE_ERR_HW_NOT_PRESENT             = 0x12    # The requested operation relies on hardware that is either not present on the board or did not initialize properly
	MMP_IFACE_ERR_DB_LOCKED                  = 0x13    # An attempt to modify a database (like the configuration) was disallowed because it is in a locked state
	MMP_IFACE_ERR_ACOU_DISALLOWED            = 0x14    # The modification attempt cannot be performed acoustically
	MMP_IFACE_ERR_SET_ONLY                   = 0x15    # The field may only be SET, and not queried with a GET operation
	MMP_NUM_IFACE_ERR                        = 0x16



#  CMDRESULT message types.  Note that all errors and mmp_exec_notify() calls will clear the current MMP
#  exec information with the exception of the CMD_STARTED and PROGRESS command result message types.
#  
#  subfield=mmp_cmd_result_t::message
class mmp_cmdresult_msg_t:
	MMP_CMDRESULT_ERROR                      = 0    # An error occurred - clears current execution data
	MMP_CMDRESULT_CMD_ACK                    = 1    # Action completed successfully - clears current execution data
	MMP_CMDRESULT_CMD_STARTED                = 2    # Action/mode has started - should be followed by CMD_ENDED and does not automatically clear the current execution data
	MMP_CMDRESULT_CMD_ENDED                  = 3    # Action/mode has ended - clears current execution data
	MMP_CMDRESULT_DATA                       = 4    # Data is being returned from the command.  The standard CMDRESULT header will be followed by a command-specific set of result data.  Clears current execution data.
	MMP_CMDRESULT_TIMEOUT                    = 5    # Command ended with a timeout condition - clears current execution data
	MMP_CMDRESULT_PROGRESS                   = 6    # Command is progressing with more messages forthcoming.  Like CMDRESULT_DATA, it may be followed by more information.  Does not automatically clear the current execution data.
	MMP_CMDRESULT_REMOTE_ERROR               = 7    # Remotely executed MMP operation contains one or more error conditions
	MMP_CMDRESULT_REMOTE_TIMEOUT             = 8    # Remotely executed MMP operation timed out
	MMP_CMDRESULT_REMOTE_DENIED              = 9    # Remotely executed MMP operation disallowed due to locking, permissions, etc.
	MMP_NUM_CMDRESULT                        = 10



# **************************
#  SREG Fields
# **************************
#  
#  subsys=SREG
class mmp_sreg_fld_t:
	MMP_SREG_FLD_VERSION                     = 0    # DSP SW version
	MMP_SREG_FLD_POSACK                      = 2    # Positive acknowledgements
	MMP_SREG_FLD_SERBAUD                     = 3    # Serial port baud & configuration
	MMP_SREG_FLD_ACOUBAUD                    = 4    # Acoustic baud rate
	MMP_SREG_FLD_TXPOWER                     = 6    # Transmit power
	MMP_SREG_FLD_RESPTIMEOUT                 = 7    # Acoustic response timeout
	MMP_SREG_FLD_FWDDELAY                    = 8    # Packet forwarding delay
	MMP_SREG_FLD_COPROC                      = 9    # PSK coprocessor enable/status
	MMP_SREG_FLD_LPTIMEOUT                   = 10    # Low-power idle timeout
	MMP_SREG_FLD_FLOWCTRL                    = 11    # Serial port flow control
	MMP_SREG_FLD_TESTMSGLEN                  = 12    # Acoustic test message length
	MMP_SREG_FLD_VERBOSITY                   = 13    # Console message verbosity
	MMP_SREG_FLD_REMADDR                     = 14    # Default remote modem address
	MMP_SREG_FLD_LOCADDR                     = 18    # Local modem address
	MMP_SREG_FLD_RXTHRESHOLD                 = 21    # Receive sensitivity threshold for transpond pings
	MMP_SREG_FLD_BAND                        = 24    # Acoustic band
	MMP_SREG_FLD_TXPULSEWIDTH                = 32    # Transpond interrogation ping pulse width
	MMP_SREG_FLD_RXPULSEWIDTH                = 33    # Transpond received ping pulse width
	MMP_SREG_FLD_TAT                         = 40    # Transponder/ranging turn-around time
	MMP_SREG_FLD_PPSSYNC                     = 49    # Internal/external 1 PPS time sync mode
	MMP_SREG_FLD_RXFREQ                      = 53    # Transpond ping receive frequency (only for units that can't receive multiple frequencies)
	MMP_SREG_FLD_XPNDLOCKOUT                 = 55    # Transpond ping lockout time
	MMP_SREG_FLD_ALL                         = 255    # Use to SET/GET all S-registers at once



#  SREG subsys - field BAND
#  
#  subfield=mmp_sreg_fld_val_t::val
class mmp_sreg_band_t:
	MMP_SREG_BAND_LF                         = 56    # LF band
	MMP_SREG_BAND_MF                         = 100    # MF band
	MMP_SREG_BAND_C                          = 141    # C band
	MMP_SREG_BAND_HF                         = 156    # HF band



#  SREG subsys - field TESTMSGLEN
#  
#  subfield=mmp_sreg_fld_val_t::val
class mmp_sreg_testmsglen_t:
	MMP_SREG_TESTMSGLEN_8                    = 0    # 8 byte test message
	MMP_SREG_TESTMSGLEN_32                   = 1    # 32 byte test message
	MMP_SREG_TESTMSGLEN_128                  = 2    # 128 byte test message
	MMP_SREG_TESTMSGLEN_256                  = 3    # 256 byte test message
	MMP_SREG_TESTMSGLEN_512                  = 4    # 512 byte test message
	MMP_SREG_TESTMSGLEN_1024                 = 5    # 1024 byte test message
	MMP_SREG_TESTMSGLEN_2048                 = 6    # 2048 byte test message
	MMP_SREG_TESTMSGLEN_4096                 = 7    # 4096 byte test message



# **************************
#  TIME Fields
# **************************
#  events in this subsystem are interface-specific (only go to inducing interface)
#  
#  subsys=TIME
class mmp_time_fld_t:
	MMP_TIME_FLD_1PPS_PULSE                  = 0x00    # (currently unsupported) Arrival of 1 PPS synchronization pulse
	MMP_TIME_FLD_TIMEDATE                    = 0x01    # The time and date on the modem's clock
	MMP_TIME_FLD_DSTPARMS                    = 0x02    # (currently unsupported) Parameters governing Daylight Savings Time adjustments of local time
	MMP_TIME_FLD_RTCBATT                     = 0x03    # Battery level on modem's clock
	MMP_TIME_FLD_SYNCINFO                    = 0x04    # Synchronization status of the modem to an accurate 1PPS reference (internal or external) and timestamping information (e.g., $GPZDA messages)
	MMP_NUM_TIME_FLD                         = 0x05



# **************************
#  TRANSPOND Fields
# **************************
#  
#  subsys=TRANSPOND
class mmp_transpond_fld_t:
	MMP_TRANSPOND_FLD_STAT                   = 0x00    # Transpond mode status
	MMP_TRANSPOND_FLD_PINGRCVD               = 0x01    # Transpond ping received
	MMP_TRANSPOND_FLD_CHNLRXADJ_0            = 0x02    # Receive sensitivity adjustment for channel 0
	MMP_TRANSPOND_FLD_CHNLRXADJ_1            = 0x03    # Receive sensitivity adjustment for channel 1
	MMP_TRANSPOND_FLD_CHNLRXADJ_2            = 0x04    # Receive sensitivity adjustment for channel 2
	MMP_TRANSPOND_FLD_CHNLRXADJ_3            = 0x05    # Receive sensitivity adjustment for channel 3
	MMP_TRANSPOND_FLD_CHNLRXADJ_4            = 0x06    # Receive sensitivity adjustment for channel 4
	MMP_TRANSPOND_FLD_CHNLRXADJ_5            = 0x07    # Receive sensitivity adjustment for channel 5
	MMP_TRANSPOND_FLD_CHNLRXADJ_6            = 0x08    # Receive sensitivity adjustment for channel 6
	MMP_TRANSPOND_FLD_CHNLRXADJ_7            = 0x09    # Receive sensitivity adjustment for channel 7
	MMP_TRANSPOND_FLD_CHNLRXADJ_8            = 0x0A    # Receive sensitivity adjustment for channel 8
	MMP_TRANSPOND_FLD_CHNLRXADJ_9            = 0x0B    # Receive sensitivity adjustment for channel 9
	MMP_TRANSPOND_FLD_CHNLRXADJ_10           = 0x0C    # Receive sensitivity adjustment for channel 10
	MMP_TRANSPOND_FLD_CHNLRXADJ_11           = 0x0D    # Receive sensitivity adjustment for channel 11
	MMP_TRANSPOND_FLD_CHNLRXADJ_12           = 0x0E    # Receive sensitivity adjustment for channel 12
	MMP_TRANSPOND_FLD_CHNLRXADJ_13           = 0x0F    # Receive sensitivity adjustment for channel 13
	MMP_TRANSPOND_FLD_CHNLRXADJ_14           = 0x10    # Receive sensitivity adjustment for channel 14
	MMP_TRANSPOND_FLD_CHNLRXADJ_15           = 0x11    # Receive sensitivity adjustment for channel 15
	MMP_TRANSPOND_FLD_CHNLRXADJ_16           = 0x12    # Receive sensitivity adjustment for channel 16
	MMP_TRANSPOND_FLD_CHNLRXADJ_17           = 0x13    # Receive sensitivity adjustment for channel 17
	MMP_TRANSPOND_FLD_CHNLRXADJ_18           = 0x14    # Receive sensitivity adjustment for channel 18
	MMP_TRANSPOND_FLD_CHNLRXADJ_19           = 0x15    # Receive sensitivity adjustment for channel 19
	MMP_TRANSPOND_FLD_CHNLRXADJ_20           = 0x16    # Receive sensitivity adjustment for channel 20
	MMP_TRANSPOND_FLD_CHNLRXADJ_21           = 0x17    # Receive sensitivity adjustment for channel 21
	MMP_TRANSPOND_FLD_CHNLRXADJ_22           = 0x18    # Receive sensitivity adjustment for channel 22
	MMP_TRANSPOND_FLD_CHNLRXADJ_23           = 0x19    # Receive sensitivity adjustment for channel 23
	MMP_TRANSPOND_FLD_CHNLRXADJ_24           = 0x1A    # Receive sensitivity adjustment for channel 24
	MMP_TRANSPOND_FLD_CHNLRXADJ_25           = 0x1B    # Receive sensitivity adjustment for channel 25
	MMP_TRANSPOND_FLD_CHNLRXADJ_26           = 0x1C    # Receive sensitivity adjustment for channel 26
	MMP_TRANSPOND_FLD_CHNLRXADJ_27           = 0x1D    # Receive sensitivity adjustment for channel 27
	MMP_TRANSPOND_FLD_CHNLRXADJ_28           = 0x1E    # Receive sensitivity adjustment for channel 28
	MMP_TRANSPOND_FLD_CHNLRXADJ_29           = 0x1F    # Receive sensitivity adjustment for channel 29
	MMP_TRANSPOND_FLD_CHNLRXADJ_30           = 0x20    # Receive sensitivity adjustment for channel 30
	MMP_TRANSPOND_FLD_CHNLRXADJ_31           = 0x21    # Receive sensitivity adjustment for channel 31
	MMP_TRANSPOND_FLD_CHNLRXADJ_32           = 0x22    # Receive sensitivity adjustment for channel 32
	MMP_TRANSPOND_FLD_CHNLRXADJ_33           = 0x23    # Receive sensitivity adjustment for channel 33
	MMP_TRANSPOND_FLD_CHNLRXADJ_34           = 0x24    # Receive sensitivity adjustment for channel 34
	MMP_TRANSPOND_FLD_CHNLRXADJ_35           = 0x25    # Receive sensitivity adjustment for channel 35
	MMP_TRANSPOND_FLD_CHNLRXADJ_36           = 0x26    # Receive sensitivity adjustment for channel 36
	MMP_TRANSPOND_FLD_CHNLRXADJ_37           = 0x27    # Receive sensitivity adjustment for channel 37
	MMP_TRANSPOND_FLD_CHNLRXADJ_38           = 0x28    # Receive sensitivity adjustment for channel 38
	MMP_TRANSPOND_FLD_CHNLRXADJ_39           = 0x29    # Receive sensitivity adjustment for channel 39
	MMP_TRANSPOND_FLD_CHNLRXADJ_40           = 0x2A    # Receive sensitivity adjustment for channel 40
	MMP_TRANSPOND_FLD_CHNLRXADJ_ALL          = 0x2B    # Set or get all receive channel sensitivity adjustments at once
	MMP_NUM_TRANSPOND_FLD                    = 0x2C



#  
#  subfield=mmp_transpond_stat_t::stat
class mmp_transpond_stat_status_t:
	MMP_TRANSPOND_STAT_IDLE                  = 0    # Modem is not listening for transpond pings
	MMP_TRANSPOND_STAT_ACTIVE                = 1    # Modem is listening for transpond receive pings for a finite period of time
	MMP_TRANSPOND_STAT_CONTINUOUS            = 2    # Modem is continually listening for transpond receive pings
	MMP_NUM_TRANSPOND_STAT                   = 3



#  
#  subfield=mmp_transpond_pingrcvd_t::flags  (each flag may be set independently)
class mmp_transpond_pingrcvd_flag_t:
	MMP_TRANSPOND_PINGRCVD_FLAG_RESIDUAL     = 0x01    # This ping is measured against an earlier interrogation and not a new one about to depart.



#  Values for use with ACOUBAUD/modspec parameter
#  
#  subfield=mmp_sreg_fld_val_t::val
#  subfield=mmp_remote_setacoubaud_t::modspec
#  subfield=mmp_remote_testmsgstats_t::mod_spec
#  subfield=mmp_data_acstats_t::mod_spec
#  subfield=mmp_network_pkthdr_t::mod_spec
#  subfield=mmp_network_l2utilpkt_t::modspec
#  subfield=mmp_remote_autobaud_t::max_modspec
#  subfield=mmp_remote_autobaud_t::min_modspec
class modspec_t:
	MODSPEC_NULL                             = 0    # Null modspec value
	MODSPEC_80_STDFH                         = 1    # 80 bps FH
	MODSPEC_140_MFSK                         = 2    # 140 bps MFSK
	MODSPEC_300_MFSK                         = 3    # 300 bps MFSK
	MODSPEC_600_MFSK                         = 4    # 600 bps MFSK
	MODSPEC_800_MFSK                         = 5    # 800 bps MFSK
	MODSPEC_1066_MFSK                        = 6    # 1066 bps MFSK
	MODSPEC_1200_MFSK                        = 7    # 1200 bps MFSK
	MODSPEC_2400_MFSK                        = 8    # 2400 bps MFSK
	MODSPEC_2560_PSK                         = 9    # 2560 bps PSK
	MODSPEC_5120_PSK                         = 10    # 5120 bps PSK
	MODSPEC_7680_PSK                         = 11    # 7680 bps PSK
	MODSPEC_10240_PSK                        = 12    # 10240 bps PSK
	MODSPEC_15360_PSK                        = 13    # 15360 bps PSK
	MODSPEC_80_WHFH                          = 64
	MODSPEC_80_MRFH                          = 65
	MODSPEC_160_MAFH                         = 66
	MODSPEC_80_MAFH                          = 67
	MODSPEC_80_JAFH                          = 68
	NUM_MODSPEC                              = 19



# ACK codes
#  
#  subfield=mmp_data_ack_t::ack
#  subfield=mmp_rngrls_cmdresult_release_response_t::status
class ack_code_t:
	OK                                       = 0    # Operation successful
	BUFFER_EMPTY                             = 1    # Nothing in data logger
	BLOCK_EMPTY                              = 2    # Nothing in requested block of data logger
	INVALID_SETTING                          = 3    # Invalid setting
	INVALID_RELEASE_CODE                     = 4    # Invalid release code
	GOOD_RELEASE                             = 5    # Mechanical release successful
	VALID_RELEASE_CODE                       = 6    # Received valid release code, activating motor
	NOT_RELEASED                             = 7    # Unit not released
	BUSY                                     = 8    # Unit busy
	VALID_RELEASE_CODE_BURN                  = 9    # Received valid release code, beginning burn wire burn cycle
	GOOD_BURN_RELEASE                        = 10    # Burn wire burn cycle completed successfully
	BURN_RELEASE_TIMEOUT                     = 11    # Burn wire burn cycle stopped due to timeout, no tilt detected
	SREG_SAVED                               = 12    # Remote S-register saved
	DATALOG_NOT_SUPPORTED                    = 13    # Datalogger not supported on this unit
	DATALOG_ERASE_STARTED                    = 14    # Datalogger erase started
	INVALID_ACOUSTIC_TRIGGER_CODE            = 15    # Invalid trigger code
	VALID_ACOUSTIC_TRIGGER_CODE              = 16    # Received valid acoustic trigger code, asserting signal
	ACOUSTIC_TRIGGER_CONFIRMED               = 17    # Acoustic trigger confirmed (signal may or may not be de-asserted depending on configuration)
	ACOUSTIC_TRIGGER_TIMEOUT                 = 18    # Acoustic trigger timed out with no confirmation, signal de-asserted



#  
#  subfield=mmp_rngrls_cmdresult_release_status_t::status
class rls_status_code_t:
	RLSSTAT_STD_MODEM                        = 0    # Standard modem, no release capability
	RLSSTAT_CONFIRMED                        = 1    # Release triggered and confirmed
	RLSSTAT_NOT_CONFIRMED                    = 2    # Release triggered and not confirmed
	RLSSTAT_ARMED                            = 3    # Release armed and ready to accept release code
	RLSSTAT_BURNWIRE_ACTIVATED               = 4    # Release burn wire burn cycle is active
	RLSSTAT_BURNWIRE_CONFIRMED               = 5    # Release burn wire burn cycle triggered, tilt sensor triggered
	RLSSTAT_BURNWIRE_TIMEOUT                 = 6    # release burn wire burn cycle timed out, no tilt detected
	RLSSTAT_BURNWIRE_ARMED                   = 7    # New (4G) status to differentiate armed burn wire units from mech releases
	RLSSTAT_RSERIES_ARMED                    = 16    # Next-Gen Release armed
	RLSSTAT_RSERIES_CONFIRMED                = 17    # Next-Gen Release triggered and confirmed
	RLSSTAT_RSERIES_NOT_CONFIRMED            = 18    # Next-Gen release triggered and not confirmed
	RLSSTAT_ACOUTRIG_NOT_ASSERTED            = 19    # Acoustic trigger signal not asserted
	RLSSTAT_ACOUTRIG_ASSERTED                = 20    # Acoustic trigger signal asserted
	RLSSTAT_ACOUTRIG_CONFIRMED               = 21    # Acoustic trigger signal confirmed and de-asserted
	RLSSTAT_ACOUTRIG_ASSERTED_CONFIRMED      = 22    # Acoustic trigger signal confirmed and still asserted
	RLSSTAT_ACOUTRIG_TIMEOUT                 = 23    # Acoustic trigger signal not confirmed and de-asserted
	NUM_RLSSTAT                              = 24



#  
#  subfield=mmp_rngrls_cmdresult_release_status_t::battery
class battery_status_t:
	BATTERY_GOOD                             = 0    # Battery voltage is good
	BATTERY_LOW                              = 1    # Battery voltage is low
	BATTERY_REDUCED                          = 2    # Battery voltage reduced
	BATTERY_CHARGE_BASE                      = 20    # Values between 20 and 120 are the charge status in percent remaining, offset by 20
	BATTERY_VOLT_BASE                        = 125    # Values between 125 and 245 are the battery voltage in 0.5 volt increments (0 - 60 V range)



#  
#  subfield=mmp_rngrls_cmdresult_release_status_t::tilt
class tilt_status_t:
	RLS_NOT_TILTED                           = 0    # The release unit is upright
	RLS_TILTED                               = 1    # The release unit is tilted
	RLS_TILT_EXCESS_MOTION                   = 2    # The tilt value could not be read because the sensor was moving too much
	RLS_TILT_HW_NOT_READY                    = 3    # Error attempting to read tilt-sensing hardware
	RLS_DEGREE_BASE                          = 20    # Values between 20 and 200 are the tilt measurement in degrees, offset by 20; subtract RLS_DEGREE_BASE to obtain the true measurement
	RLS_TILT_COMPACT                         = 254    # The release unit is a Compact Release with no tilt sensor
	RLS_TILT_OEMBOARDSET                     = 255



#  The positional state of continuous (one-way) relase motors such as Compact Release and ARM6K
#  
#  subfield=mmp_data_rls_cmotor_status_t::status
class cmotor_release_stat_t:
	CMOTOR_TIMEOUT                           = -1    # The motor has timed out without reaching a known position and is stopped
	CMOTOR_RUNNING                           = 0    # The motor is energized and turning
	CMOTOR_LATCHED                           = 1    # The motor has reached its armed/latched position
	CMOTOR_RELEASED                          = 2    # The motor has reached its release position
	CMOTOR_INVALID                           = 3    # Invalid state where both sense switches are active at the same time (should not happen!)



#  Transmit power enums
#  
#  subfield=mmp_sreg_fld_val_t::val
#  subfield=mmp_remote_settxpower_t::txpower
#  subfield=mmp_network_ping_t::pwrlev
#  subfield=mmp_swcmd_netcfgstart_t::txpower
#  subfield=mmp_remote_testmsgstats_t::remote_txpwr
class txpower_t:
	TXPOWER_MIN                              = 1
	TXPOWER_21DB                             = 1    # -21 dB
	TXPOWER_18DB                             = 2    # -18 dB
	TXPOWER_15DB                             = 3    # -15 dB
	TXPOWER_12DB                             = 4    # -12 dB
	TXPOWER_9DB                              = 5    # -9 dB
	TXPOWER_6DB                              = 6    # -6 dB
	TXPOWER_3DB                              = 7    # -3 dB
	TXPOWER_MAX                              = 8    # 0 dB (full transmit power)
	LEVEL_SILENT_PING                        = 255



#  Maximum SPL enums
#  
#  subfield=mmp_sreg_fld_val_t::val
class txatten_t:
	TXATTEN_0DB                              = 0    # Full transmit power
	TXATTEN_24DB                             = 1    # (approximately) 24 dB attenuation



#  
#  subfield=mmp_remote_autobaud_t::set_flags
#  subfield=mmp_remote_autobaud_result_t::set_flags
class autobaud_set_flags_t:
	AUTOBAUD_LOCAL_SET                       = 0x01    # When set, causes the the local modem to set its own transmission baud rate to the best one found
	AUTOBAUD_REMOTE_SET                      = 0x02



#  Layer 2 commands
#  
#  subfield=mmp_data_remote_header_t::type
# *************************
class std_layer2_command_t:
	L2CMD_875C                               = 0
	L2CMD_UNUSED1                            = 1
	L2CMD_UNUSED2                            = 2
	L2CMD_NUWC_RNG                           = 3
	L2CMD_BRG_DATA                           = 4
	L2CMD_875D_TRANSPORT                     = 5
	L2CMD_UNUSED6                            = 6
	L2CMD_UNUSED7                            = 7
	L2CMD_UNUSED8                            = 8
	L2CMD_UNUSED9                            = 9
	L2CMD_UNUSED10                           = 10
	L2CMD_SRQ                                = 11
	L2CMD_FHC                                = 12
	L2CMD_FHD                                = 13
	L2CMD_DATA                               = 14
	L2CMD_875D                               = 15



#  
#  subfield=mmp_time_syncinfo_t::pps_state
class pps_sync_state_t:
	PPS_NO_SYNC                              = 0    # Not synchronized to a 1PPS source, awaiting qualification of a source
	PPS_PULSE_SYNC                           = 1    # Locked to a 1PPS source following qualification
	PPS_COAST_MODE                           = 2    # Coasting based on compiled statistics after having been locked to an erstwhile 1PPS source
	PPS_DISABLED_SYNC                        = 3    # Synchronization to a 1PPS source has been manually disabled



#  
#  subfield=mmp_time_syncinfo_t::time_sync
class tss_state_t:
	TSS_NO_CHANGE                            = -1
	TSS_OUT_OF_SYNC                          = 0    # Time has not been set
	TSS_NORM_IN_SYNC                         = 1    # Time is set
	TSS_EXT_READY_TIME_UPDATE                = 2    # Waiting to receive an external timestamp (non-standard applications only)
	TSS_EXT_TIME_RECEIVED                    = 3    # External timetstamp received (non-standard applications only)



#  
#  subfield=mmp_rngrls_geopro_param_t::cmdtype
class geopro_cmd_t:
	GEOPRO_CMD_ENABLE                        = 0
	GEOPRO_CMD_RELEASE                       = 1
	GEOPRO_CMD_RESET                         = 2



#  
#  subfield=mmp_rngrls_xpnd_param_t::xpnd_mode
class io_tone_mode_type_t:
	IO_TONE_MODE_NONE                        = 0
	IO_TONE_MODE_TONE                        = 1
	IO_TONE_MODE_HPR400                      = 2



#  
class udb_version_num_t:
	UDB_VERSION_MAJOR                        = 8
	UDB_VERSION_MINOR                        = 15
	UDB_VERSION_REVISION                     = 3




#===========================================================

# 
# Common header for GET/SET/EXECUTE/NOTIFY packets
class mmp_gsxn_t(MMPMessage):
	fmt = "!BBB"
	args = ("_xid", "_type", "_nparms")
	defaults = (0, 0, 0)


#===========================================================

# 
# Specifier for system/field/len use with GET/SET/NOTIFY packets
class mmp_sfl_t(MMPMessage):
	fmt = "!BBBB"
	args = ("_subsys", "_field", "_len_msb", "_len_lsb")
	defaults = (0, 0, 0, 0)


#===========================================================

# Used for any command that takes a single remote modem address as an argument
# commands REMOTE_GETSREGS, REMOTE_TESTLINK, etc. (request)
#------------------------------
# 
# cmd=STD::REMOTE_GETSREGS
# cmd=STD::REMOTE_TESTLINK
# cmd=STD::REMOTE_GETBATT
# cmd=STD::REMOTE_CMWAKEUP
# cmd=STD::REMOTE_GETAGCHIST
# cmd=STD::REMOTE_GETBATTCHG
# cmd=STD::REMOTE_GETMETER
# cmd=STD::REMOTE_RESET
# cmd=STD::REMOTE_HANGUP
class mmp_remote_t(MMPMessage):
	fmt = "!H"
	args = ("_modem_ID")
	defaults = (0)


#===========================================================

# Use for any command that takes a single remote modem address as an argument, where that address may be
# 0xFFFF to indicate the local modem.  The only difference from mmp_remote_t is the comment for documentation
# purposes.
#------------------------------
# 
# cmd=DATALOG::CLEAR
# cmd=DATALOG::SIZE
class mmp_remote_or_local_t(MMPMessage):
	fmt = "!H"
	args = ("_modem_ID")
	defaults = (0)


#===========================================================

# 
# cmd=SWCMD::LOADROUTES
# cmd=SWCMD::SAVEROUTES
class mmp_pathname_t(MMPMessage):
	fmt = "!hb"
	args = ("_len", "_path")
	defaults = (0, [])


#===========================================================

# This struct is computed from a battery_rec_t record using config params and other factors from the local
# environment
# 
# cmdresult=STD::BATT_METER
# cmdresult=STD::REMOTE_GETMETER
class battery_metering_info_t(MMPMessage):
	fmt = "!LLLLLLLLHhhhhhh"
	args = ("_time", "_rxactive_sec_x10", "_txactive_wattsec_x10", "_lpactive_sec", "_hibactive_sec", "_age_factor_x10K", "_run_age_x10K", "_watt_hours_extracted_x1000", "_tot_age", "_mfg_date", "_capacity", "_pct_remaining_x10", "_voltage", "_temp_C_x10", "_addr")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, [None] * 2, 0, 0)


#===========================================================

#*************************
# DATALOG Command Structs & Values
#*************************
# command READ_DATA
#------------------------------
# 
# cmd=DATALOG::READ_DATA
# cmd=DATALOG::READ_SECTOR
# cmd=DATALOG::READ_PAGE
class mmp_datalog_read_t(MMPMessage):
	fmt = "!HH"
	args = ("_modem_ID", "_number")
	defaults = (0, 0)


#===========================================================

# command WRITE_DATA
#------------------------------
# 
# cmd=DATALOG::WRITE_DATA
class mmp_datalog_write_t(MMPMessage):
	fmt = "!HHb"
	args = ("_modem_ID", "_bytes", "_data")
	defaults = (0, 0, [])


#===========================================================

# command SEEK
#------------------------------
# 
# cmd=DATALOG::SEEK
class mmp_datalog_seek_t(MMPMessage):
	fmt = "!L"
	args = ("_pointer")
	defaults = (0)


#===========================================================

# command FIND
#------------------------------
# 
# cmd=DATALOG::FIND
class mmp_datalog_find_t(MMPMessage):
	fmt = "!Hb"
	args = ("_size", "_query")
	defaults = (0, [])


#===========================================================

# command DUMP
#------------------------------
# 
# cmd=DATALOG::DUMP
class mmp_datalog_dump_t(MMPMessage):
	fmt = "!LBBH"
	args = ("_byte_offset_l", "_byte_offset_h", "_source", "_byte_count")
	defaults = (0, 0, 0, 0)


#===========================================================

# command SRCINFO
#------------------------------
# 
# cmd=DATALOG::SRCINFO
class mmp_datalog_srcinfo_t(MMPMessage):
	fmt = "!H"
	args = ("_source_flags")
	defaults = (0)


#===========================================================

# command REMOTE_GETDLOGBLK
#------------------------------
# 
# cmd=DATALOG::REMOTE_GETDLOGBLK
class mmp_datalog_remote_getdlogblk_t(MMPMessage):
	fmt = "!HHLBB"
	args = ("_addr", "_byte_count", "_byte_offset_l", "_byte_offset_h", "_source")
	defaults = (0, 0, 0, 0, 0)


#===========================================================

#*************************
# DATALOG Structs and Values for IFACE::CMDRESULT messages
#*************************
# command SIZE
#------------------------------
# 
# cmdresult=DATALOG::SIZE
class mmp_datalog_cmdresult_size_t(MMPMessage):
	fmt = "!LH"
	args = ("_size", "_use_mb")
	defaults = (0, 0)


#===========================================================

# command READ
#------------------------------
# 
# cmdresult=DATALOG::READ_DATA
# cmdresult=DATALOG::READ_SECTOR
# cmdresult=DATALOG::READ_PAGE
class mmp_datalog_cmdresult_read_t(MMPMessage):
	fmt = "!Lb"
	args = ("_length", "_data")
	defaults = (0, [])


#===========================================================

# command TELL
#------------------------------
# 
# cmdresult=DATALOG::TELL
class mmp_datalog_cmdresult_tell_t(MMPMessage):
	fmt = "!LL"
	args = ("_position", "_remaining")
	defaults = (0, 0)


#===========================================================

# command WRITE
#------------------------------
# 
# cmdresult=DATALOG::WRITE_DATA
class mmp_datalog_cmdresult_write_data_t(MMPMessage):
	fmt = "!Hh"
	args = ("_bytes_writ", "_status")
	defaults = (0, 0)


#===========================================================

# command LIST
#------------------------------
# 
# cmdresult=DATALOG::LIST
class mmp_datalog_cmdresult_list_t(MMPMessage):
	fmt = "!LBBHLLL"
	args = ("_byte_count_l", "_byte_count_h", "_storeloc", "_source_flags", "_record_count", "_first_rec_time", "_last_rec_time")
	defaults = (0, 0, 0, 0, 0, 0, 0)


#===========================================================

# command FIND
#------------------------------
# 
# cmdresult=DATALOG::FIND
class mmp_datalog_cmdresult_find_t(MMPMessage):
	fmt = "!LLHHb"
	args = ("_recno", "_time", "_source_flags", "_size", "_data")
	defaults = (0, 0, 0, 0, [])


#===========================================================

# command DUMP
#------------------------------
# 
# cmdresult=DATALOG::DUMP
class mmp_datalog_cmdresult_dump_t(MMPMessage):
	fmt = "!LBBHb"
	args = ("_byte_offset_l", "_byte_offset_h", "_source", "_length", "_data")
	defaults = (0, 0, 0, 0, [])


#===========================================================

# Use to overlay the variable-length source_counts[] array in mmp_datalog_cmdresult_srcinfo_t, one for each raised bit flag
# The source and byte_count_h fields are 16-bit because multiple instances of this structure will be packed
# and the compiler fleshes the sizeof() the struct out to the next 32-bit interval anyway, so it is
# reflecting reality. 
# 
# subfield=mmp_data_cmdresult_srcinfo_t::source_counts
class mmp_datalog_cmdresult_source_counts_t(MMPMessage):
	fmt = "!LLHH"
	args = ("_record_count", "_byte_count_l", "_byte_count_h", "_source")
	defaults = (0, 0, 0, 0)


#===========================================================

# command SRCINFO
#------------------------------
# 
# cmdresult=DATALOG::SRCINFO
class mmp_datalog_cmdresult_srcinfo_t(MMPMessage):
	fmt = "!HBBH"
	args = ("_source_flags", "_storeloc", "_size", "_source_counts")
	defaults = (0, 0, 0, [])


#===========================================================

#*************************
# RNGRLS Command Structs & Values
#*************************
# command TRANSPOND
#------------------------------
# 
# cmd=RNGRLS::TRANSPOND
class mmp_rngrls_transpond_t(MMPMessage):
	fmt = "!LHH"
	args = ("_freq", "_silent", "_rcv_only")
	defaults = (0, 0, 0)


#===========================================================

# command TRANSPOND_W_TIMEOUT
#------------------------------
# 
# cmd=RNGRLS::TRANSPOND_W_TIMEOUT
class mmp_rngrls_transpond_w_timeout_t(MMPMessage):
	fmt = "!LHHH"
	args = ("_freq", "_silent", "_rcv_only", "_timeout_x10")
	defaults = (0, 0, 0, 0)


#===========================================================

# command RANGE, RANGE_W_TIMEOUT
#------------------------------
# 
# cmd=RNGRLS::RANGE
# cmd=RNGRLS::RANGE_W_TIMEOUT
class mmp_rngrls_range_t(MMPMessage):
	fmt = "!HH"
	args = ("_address", "_timeout_x10")
	defaults = (0, 0)


#===========================================================

# command RANGE_USBL_REPEAT
#------------------------------
# 
# cmd=RNGRLS::RANGE_USBL_REPEAT
class mmp_rngrls_range_repeat_t(MMPMessage):
	fmt = "!HHH"
	args = ("_address", "_timeout_x10", "_repeats")
	defaults = (0, 0, 0)


#===========================================================

# command BEARING
#------------------------------
# 
# cmd=RNGRLS::BEARING
# cmd=RNGRLS::BEARING_W_TIMEOUT
class mmp_rngrls_bearing_t(MMPMessage):
	fmt = "!HHHH"
	args = ("_address", "_type", "_tat", "_timeout_x10")
	defaults = (0, 0, 0, 0)


#===========================================================

# command NAVDATA
#------------------------------
# 
# cmd=RNGRLS::NAVDATA
class mmp_rngrls_navdata_t(MMPMessage):
	fmt = "!HH"
	args = ("_address", "_type")
	defaults = (0, 0)


#===========================================================

# command ABSREL
#------------------------------
# 
# cmd=RNGRLS::ABSREL
# cmd=RNGRLS::ABSCMPDEP
class mmp_rngrls_absrel_t(MMPMessage):
	fmt = "!H"
	args = ("_address")
	defaults = (0)


#===========================================================

# command STATUS
#------------------------------
# 
# cmd=RNGRLS::RELEASE_STATUS
class mmp_rngrls_release_status_t(MMPMessage):
	fmt = "!H"
	args = ("_address")
	defaults = (0)


#===========================================================

# command SMART_RELEASE / BURNWIRE
#------------------------------
# 
# cmd=RNGRLS::SMART_RELEASE
# cmd=RNGRLS::BURNWIRE
class mmp_rngrls_smart_release_burnwire_t(MMPMessage):
	fmt = "!HH"
	args = ("_address", "_code")
	defaults = (0, 0)


#===========================================================

# command FSK_RELEASE
#------------------------------
# 
# cmd=RNGRLS::FSK_RELEASE
class mmp_rngrls_fsk_param_t(MMPMessage):
	fmt = "!HHL"
	args = ("_duration", "_code", "_freq")
	defaults = (0, 0, 0)


#===========================================================

# command EDGETECH_RELEASE
#------------------------------
# 
# cmd=RNGRLS::EDGETECH_RELEASE
class mmp_rngrls_edgetech_param_t(MMPMessage):
	fmt = "!HH"
	args = ("_freq_spec", "_code")
	defaults = (0, 0)


#===========================================================

# command URI_RELEASE
#------------------------------
# 
# cmd=RNGRLS::URI_RELEASE
class mmp_rngrls_uri_param_t(MMPMessage):
	fmt = "!H"
	args = ("_code")
	defaults = (0)


#===========================================================

# command GEOPRO_RELEASE
#------------------------------
# 
# cmd=RNGRLS::GEOPRO_RELEASE
class mmp_rngrls_geopro_param_t(MMPMessage):
	fmt = "!HH"
	args = ("_cmdtype", "_addr")
	defaults = (0, 0)


#===========================================================

# command CHANNEL_PROBE
#------------------------------
# 
# cmd=RNGRLS::CHANNEL_PROBE
class mmp_rngrls_channel_probe_param_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_log")
	defaults = (0, 0)


#===========================================================

# command RESPONDER_RANGE
#------------------------------
# 
# cmd=RNGRLS::RESPONDER_RANGE
class mmp_rngrls_responder_range_t(MMPMessage):
	fmt = "!H"
	args = ("_timeout_x10")
	defaults = (0)


#===========================================================

# command RSERIES_RANGE
#------------------------------
# 
# cmd=RNGRLS::RSERIES_RANGE
class mmp_rngrls_rseries_range_t(MMPMessage):
	fmt = "!HH"
	args = ("_address", "_timeout_x10")
	defaults = (0, 0)


#===========================================================

# command RSERIES_ACTIVATE
#------------------------------
# 
# cmd=RNGRLS::RSERIES_ACTIVATE
class mmp_rngrls_rseries_activate_t(MMPMessage):
	fmt = "!HHH"
	args = ("_address", "_wake_up", "_awake_mins")
	defaults = (0, 0, 0)


#===========================================================

# command RSERIES_HIBERNATE /  DB lock
#------------------------------
# 
# cmd=RNGRLS::RSERIES_HIBERNATE
class mmp_rngrls_rseries_hib_t(MMPMessage):
	fmt = "!HH"
	args = ("_address", "_wake_up")
	defaults = (0, 0)


#===========================================================

# command RSERIES_DB_LOCK/UNLOCK
#------------------------------
# 
# cmd=RNGRLS::RSERIES_DB_UNLOCK
# cmd=RNGRLS::RSERIES_DB_LOCK
class mmp_rngrls_rseries_dblock_t(MMPMessage):
	fmt = "!HHL"
	args = ("_address", "_wake_up", "_serial_no")
	defaults = (0, 0, 0)


#===========================================================

# command RSERIES_RELEASE
#------------------------------
# 
# cmd=RNGRLS::RSERIES_RELEASE
class mmp_rngrls_rseries_release_t(MMPMessage):
	fmt = "!HHH"
	args = ("_address", "_wake_up", "_code")
	defaults = (0, 0, 0)


#===========================================================

# command RSERIES_XPND_MODE / STD_XPND_MODE
#------------------------------
# 
# cmd=RNGRLS::RSERIES_XPND_MODE
# cmd=RNGRLS::STD_XPND_MODE
class mmp_rngrls_xpnd_mode_t(MMPMessage):
	fmt = "!HHH"
	args = ("_address", "_wake_up", "_xpnd_mode")
	defaults = (0, 0, 0)


#===========================================================

# command VRSERIES_LOCALRLS
#------------------------------
# 
# cmd=RNGRLS::VRSERIES_LOCALRLS
class mmp_rngrls_vrseries_localrls_t(MMPMessage):
	fmt = "!HH"
	args = ("_code", "_delay_s")
	defaults = (0, 0)


#===========================================================

# command ACOUSTIC_TRIGGER
#------------------------------
# 
# cmd=RNGRLS::ACOUSTIC_TRIGGER
class mmp_rngrls_acoustic_trigger_t(MMPMessage):
	fmt = "!HHBB"
	args = ("_address", "_code", "_assert_time", "_wake_up")
	defaults = (0, 0, 0, 0)


#===========================================================

#*************************
# RNGRLS Structs and Values for IFACE::CMDRESULT messages
#*************************
# command RANGE
#------------------------------
# 
# cmdresult=RNGRLS::RANGE
# cmdresult=RNGRLS::RANGE_W_TIMEOUT
# cmdresult=RNGRLS::RSERIES_RANGE
class mmp_rngrls_cmdresult_range_t(MMPMessage):
	fmt = "!LL"
	args = ("_range", "_rt_time")
	defaults = (0, 0)


#===========================================================

# command BEARING
#------------------------------
# This is a subset of mmp_rngrls_cmdresult_navdata_t and must match the start of that structure.  Changes made
# to one must be made to the other to keep them in sync.
# 
# cmdresult=RNGRLS::BEARING
# cmdresult=RNGRLS::BEARING_W_TIMEOUT
class mmp_rngrls_cmdresult_bearing_t(MMPMessage):
	fmt = "!LLlhh"
	args = ("_range", "_rt_time", "_doppler", "_azimuth", "_elevation")
	defaults = (0, 0, 0, 0, 0)


#===========================================================

# command RANGE_USBL_REPEAT
#------------------------------
# This is a subset of mmp_rngrls_cmdresult_navdata_t and must match the start of that structure.  Changes made
# to one must be made to the other to keep them in sync.
# 
# cmdresult=RNGRLS::RANGE_USBL_REPEAT
class mmp_rngrls_cmdresult_range_usbl_repeat_t(MMPMessage):
	fmt = "!LLlhh"
	args = ("_range", "_trip_time", "_doppler", "_azimuth", "_elevation")
	defaults = (0, 0, 0, 0, 0)


#===========================================================

# command NAVDATA
#------------------------------
# This is a superset of mmp_rngrls_cmdresult_bearing_t and the start of this structure must match the 
# entirety of that structure.  Changes made to one must be made to the other to keep them in sync.
# 
# cmdresult=RNGRLS::NAVDATA
class mmp_rngrls_cmdresult_navdata_t(MMPMessage):
	fmt = "!LLLhhllll"
	args = ("_range", "_rt_time", "_type", "_azimuth", "_elevation", "_latitude", "_longitude", "_depth", "_altitude")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

# command ABSREL
#------------------------------
# 
# cmdresult=RNGRLS::ABSREL
class mmp_rngrls_cmdresult_absrel_t(MMPMessage):
	fmt = "!LLlHhHh"
	args = ("_range", "_rt_time", "_doppler", "_bearing", "_inclination", "_azimuth", "_elevation")
	defaults = (0, 0, 0, 0, 0, 0, 0)


#===========================================================

# command ABSCMPDEP
#------------------------------
# 
# cmdresult=RNGRLS::ABSCMPDEP
class mmp_rngrls_cmdresult_abscmpdep_t(MMPMessage):
	fmt = "!LLlHhHh"
	args = ("_range", "_rt_time", "_doppler", "_bearing", "_inclination", "_compass", "_depth")
	defaults = (0, 0, 0, 0, 0, 0, 0)


#===========================================================

# command CHANNEL_PROBE
#------------------------------
# 
# cmdresult=RNGRLS::CHANNEL_PROBE
class mmp_rngrls_cmdresult_channel_probe_t(MMPMessage):
	fmt = "!llllhhlH"
	args = ("_first", "_peak", "_EDT", "_T10", "_C25", "_C50", "_period", "_data")
	defaults = (0, 0, 0, 0, 0, 0, 0, [None] * 512)


#===========================================================

# command ACOU_SAMPLE
#------------------------------
# 
# cmdresult=RNGRLS::ACOU_SAMPLE
class mmp_rngrls_cmdresult_acou_sample_t(MMPMessage):
	fmt = "!LLLhBBBBh"
	args = ("_Fs", "_Fc", "_Bw", "_gain", "_cell", "_total_cells", "_clip", "_spare", "_data")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, [None] * 1024)


#===========================================================

# command SPECTRUM_MODE
#------------------------------
# 
# cmd=RNGRLS::SPECTRUM_MODE
class mmp_rngrls_spectrum_mode_t(MMPMessage):
	fmt = "!BB"
	args = ("_update_rate", "_freq_bins")
	defaults = (0, 0)


#===========================================================

# response to all RELEASE / BURNWIRE commands
#----------------------------------
# 
# cmdresult=RNGRLS::SMART_RELEASE
# cmdresult=RNGRLS::BURNWIRE
# cmdresult=RNGRLS::RSERIES_RELEASE
# cmdresult=RNGRLS::ACOUSTIC_TRIGGER
class mmp_rngrls_cmdresult_release_response_t(MMPMessage):
	fmt = "!H"
	args = ("_status")
	defaults = (0)


#===========================================================

# command STATUS
#------------------------------
# 
# cmdresult=RNGRLS::RELEASE_STATUS
class mmp_rngrls_cmdresult_release_status_t(MMPMessage):
	fmt = "!HHH"
	args = ("_status", "_tilt", "_battery")
	defaults = (0, 0, 0)


#===========================================================

#*************************
# STD Command Structs & Values
#*************************
# command REMOTE_MMPREQ
#------------------------------
# 
# cmd=STD::REMOTE_MMPREQ
class mmp_remote_request_t(MMPMessage):
	fmt = "!HHHb"
	args = ("_addr", "_flags", "_len", "_data")
	defaults = (0, 0, 0, [])


#===========================================================

# command REMOTE_SETACOUBAUD
#------------------------------
# 
# cmd=STD::REMOTE_SETACOUBAUD
class mmp_remote_setacoubaud_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_modspec")
	defaults = (0, 0)


#===========================================================

# command REMOTE_SETTXPOWER
#------------------------------
# 
# cmd=STD::REMOTE_SETTXPOWER
class mmp_remote_settxpower_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_txpower")
	defaults = (0, 0)


#===========================================================

# command REMOTE_SETONESREG
#------------------------------
# 
# cmd=STD::REMOTE_SETONESREG
class mmp_remote_setonesreg_t(MMPMessage):
	fmt = "!HHH"
	args = ("_addr", "_sreg", "_value")
	defaults = (0, 0, 0)


#===========================================================

# command REMOTE_GETSREGS (response)
#------------------------------
# 
# cmdresult=STD::REMOTE_GETSREGS
class mmp_remote_sregisters_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_sregs")
	defaults = (0, [None] * 21)


#===========================================================

# command REMOTE_GETONESREG
#------------------------------
# 
# cmd=STD::REMOTE_GETONESREG
class mmp_remote_getonesreg_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_sreg")
	defaults = (0, 0)


#===========================================================

# command REMOTE_GETONESREG (response)
#------------------------------
# 
# cmdresult=STD::REMOTE_GETONESREG
class mmp_remote_getonesreg_resp_t(MMPMessage):
	fmt = "!HHH"
	args = ("_addr", "_sreg", "_value")
	defaults = (0, 0, 0)


#===========================================================

# command REMOTE_SENDDATA
#------------------------------
# 
# cmd=STD::REMOTE_SENDDATA
# cmd=STD::REMOTE_SENDCMD
# cmd=STD::REMOTE_SENDBREAK
class mmp_remote_senddata_t(MMPMessage):
	fmt = "!HHHb"
	args = ("_addr", "_transport", "_len", "_data")
	defaults = (0, 0, 0, [])


#===========================================================

# command REMOTE_MMPREQ (response)
#----------------------------
# 
# cmdresult=STD::REMOTE_MMPREQ
class mmp_remote_mmpresp_t(MMPMessage):
	fmt = "!HHb"
	args = ("_addr", "_len", "_data")
	defaults = (0, 0, [])


#===========================================================

# command UPDATE_FIRMWARE
#------------------------------
# 
# cmd=STD::UPDATE_FIRMWARE
class mmp_update_firmware_t(MMPMessage):
	fmt = "!L"
	args = ("_addr")
	defaults = (0)


#===========================================================

# command REMOTE_CMWAKEUP
#------------------------------
# 
# cmd=STD::REMOTE_CMWAKEUP
class mmp_remote_cmwakeup_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_stay_awake_mins")
	defaults = (0, 0)


#===========================================================

# command TILT_ACCEL
#------------------------------
# 
# cmd=STD::TILT_ACCEL
class mmp_tilt_accel_t(MMPMessage):
	fmt = "!H"
	args = ("_g_lpf")
	defaults = (0)


#===========================================================

# command REMOTE_TESTLINK (response)
#------------------------------
# 
# cmdresult=STD::REMOTE_TESTLINK
class mmp_remote_testmsgstats_t(MMPMessage):
	fmt = "!HHhhHHhhHHhHHh"
	args = ("_addr", "_mod_spec", "_speedx10", "_acq_SNRx10", "_acq_MPDx10", "_acq_RCT", "_acq_FSNR", "_hdr_SNRx10", "_hdr_CCERR", "_msg_ERR", "_msg_SNRx10", "_msg_AGC", "_msg_CCERR", "_remote_txpwr")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

# command REMOTE_GETBATT (response)
# ---------------------------------
# 
# cmdresult=STD::REMOTE_GETBATT
class mmp_remote_battvoltage_t(MMPMessage):
	fmt = "!HHH"
	args = ("_addr", "_batt_voltage", "_aux_voltage")
	defaults = (0, 0, 0)


#===========================================================

# command REMOTE_GETAGCHIST (response)
#------------------------------
# 
# cmdresult=STD::REMOTE_GETAGCHIST
class mmp_remote_agchist_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_rem_agc")
	defaults = (0, [None] * 10)


#===========================================================

# command REMOTE_AUTOBAUD
#------------------------------
# 
# cmd=STD::REMOTE_AUTOBAUD
class mmp_remote_autobaud_t(MMPMessage):
	fmt = "!HHHHH"
	args = ("_addr", "_max_modspec", "_min_modspec", "_max_bit_errs", "_set_flags")
	defaults = (0, 0, 0, 0, 0)


#===========================================================

# command REMOTE_AUTOBAUD (response)
#------------------------------
# 
# cmdresult=STD::REMOTE_AUTOBAUD
class mmp_remote_autobaud_result_t(MMPMessage):
	fmt = "!HHHH"
	args = ("_addr", "_modspec", "_bit_errs", "_set_flags")
	defaults = (0, 0, 0, 0)


#===========================================================

# command REMOTE_GETBATTCHG (response)
# ---------------------------------
# 
# cmdresult=STD::REMOTE_GETBATTCHG
class mmp_remote_battcharge_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_charge")
	defaults = (0, 0)


#===========================================================

# command TILT_ACCEL (response)
#------------------------------
# 
# cmdresult=STD::TILT_ACCEL
class mmp_tilt_accel_response_t(MMPMessage):
	fmt = "!hhhh"
	args = ("_one_g", "_xyz_accel", "_xyz_tilt", "_g")
	defaults = (0, [None] * 3, [None] * 3, 0)


#===========================================================

# command AXIS_TILT (response)
#------------------------------
# 
# cmdresult=STD::AXIS_TILT
class mmp_axis_tilt_response_t(MMPMessage):
	fmt = "!BB"
	args = ("_tilt", "_axis_w_pol")
	defaults = (0, 0)


#===========================================================

#*************************
# command GETBATT (response)
# ---------------------------------
# 
# cmdresult=STD::GETBATT
class mmp_battvoltage_t(MMPMessage):
	fmt = "!HH"
	args = ("_batt_voltage", "_aux_voltage")
	defaults = (0, 0)


#===========================================================

# command GETBATTCHG (response)
# ---------------------------------
# 
# cmdresult=STD::GETBATTCHG
class mmp_battcharge_t(MMPMessage):
	fmt = "!H"
	args = ("_charge")
	defaults = (0)


#===========================================================

# command GETAGCHIST (response)
#------------------------------
# 
# cmdresult=STD::GETAGCHIST
class mmp_agchist_t(MMPMessage):
	fmt = "!H"
	args = ("_agchist")
	defaults = ([None] * 10)


#===========================================================

# command BOARD_TEMP
#------------------------------
# 
# cmd=STD::BOARD_TEMP
class mmp_board_temp_t(MMPMessage):
	fmt = "!H"
	args = ("_thermistor")
	defaults = (0)


#===========================================================

# command BOARD_TEMP (response)
#------------------------------
# 
# cmdresult=STD::BOARD_TEMP
class mmp_board_temp_resp_t(MMPMessage):
	fmt = "!h"
	args = ("_temp_C_x10")
	defaults = (0)


#===========================================================

# cmd CONT_XMIT_TEST
#------------------------------
# 
# cmd=STD::CONT_XMIT_TEST
class mmp_std_contxmit_enable_t(MMPMessage):
	fmt = "!H"
	args = ("_enable")
	defaults = (0)


#===========================================================

# cmd SET_REMOTE_GROUP
#------------------------------
# 
# cmd=STD::SET_REMOTE_GROUP
class mmp_std_set_remote_group_t(MMPMessage):
	fmt = "!HH"
	args = ("_address", "_group")
	defaults = (0, 0)


#===========================================================

# cmd GETSMARTBATTDATA
#------------------------------
# 
# cmd=STD::GETSMARTBATTDATA
class mmp_std_getsmartbattdata_t(MMPMessage):
	fmt = "!H"
	args = ("_battery")
	defaults = (0)


#===========================================================

# response object in smart_batt.h
# cmd ADDFEATUREKEY, DELFEATUREKEY
#------------------------------
# 
# cmd=STD::ADDFEATUREKEY
# cmd=STD::DELFEATUREKEY
class mmp_std_featkeystring_t(MMPMessage):
	fmt = "!b"
	args = ("_key")
	defaults = ([None] * 42)


#===========================================================

# command WRITE_DEVICE
#------------------------------
# 
# cmd=STD::WRITE_DEVICE
class mmp_write_device_t(MMPMessage):
	fmt = "!HHb"
	args = ("_device_num", "_len", "_data")
	defaults = (0, 0, [])


#===========================================================

# command WRITE_DEVICE(response)
#------------------------------
# 
# cmdresult=STD::WRITE_DEVICE
class mmp_write_device_result_t(MMPMessage):
	fmt = "!Hh"
	args = ("_bytes_writ", "_status")
	defaults = (0, 0)


#===========================================================

# command READ_DEVICE
#------------------------------
# 
# cmd=STD::READ_DEVICE
class mmp_read_device_t(MMPMessage):
	fmt = "!HH"
	args = ("_device_num", "_len")
	defaults = (0, 0)


#===========================================================

# command READ_DEVICE (response)
#------------------------------
# 
# cmdresult=STD::READ_DEVICE
class mmp_read_device_result_t(MMPMessage):
	fmt = "!hHb"
	args = ("_status", "_len", "_data")
	defaults = (0, 0, [])


#===========================================================

# command LEN_DEVICE
#------------------------------
# 
# cmd=STD::LEN_DEVICE
class mmp_len_device_t(MMPMessage):
	fmt = "!H"
	args = ("_device_num")
	defaults = (0)


#===========================================================

# command LEN_DEVICE (response)
#------------------------------
# 
# cmdresult=STD::LEN_DEVICE
class mmp_len_device_result_t(MMPMessage):
	fmt = "!HH"
	args = ("_device_num", "_len")
	defaults = (0, 0)


#===========================================================

# command FIND_DEVICE
#------------------------------
# 
# cmd=STD::FIND_DEVICE
class mmp_find_device_t(MMPMessage):
	fmt = "!Hb"
	args = ("_len", "_name")
	defaults = (0, [])


#===========================================================

# command FIND_DEVICE (response)
#------------------------------
# 
# cmdresult=STD::FIND_DEVICE
class mmp_find_device_result_t(MMPMessage):
	fmt = "!H"
	args = ("_device_num")
	defaults = (0)


#===========================================================

# command REMOTE_MMPREQ
#------------------------------
# 
# cmd=SWCMD::REMOTE_MMPREQ
class mmp_swb_remote_request_t(MMPMessage):
	fmt = "!HHHHb"
	args = ("_addr", "_cellid", "_flags", "_len", "_data")
	defaults = (0, 0, 0, 0, [])


#===========================================================

#**************************
# CFG Fields
#**************************
#**************************
# CFG Structs & Field Values
#**************************
# 
# field=CFG_SECT_COPROC::*
# field=CFG_SECT_DATALOG::*
# field=CFG_SECT_MODEM::*
# field=CFG_SECT_RELEASE::*
# field=CFG_SECT_SEAWEB::*
# field=CFG_SECT_SERIAL::*
# field=CFG_SECT_SYSTEM::*
# field=CFG_SECT_TEST::*
# field=CFG_SECT_VERSION::*
# field=CFG_SECT_XPND::*
# field=CFG_SECT_NETWORK::*
# field=CFG_SECT_NAV::*
# field=CFG_SECT_DAT::*
# field=CFG_SECT_RECORDER::*
# field=CFG_SECT_SONAR::*
# field=CFG_SECT_TRANSPORT::*
# field=CFG_SECT_WHOI::*
# field=CFG_SECT_USBL::*
class mmp_cfg_paramval_t(MMPMessage):
	fmt = "!lBBb"
	args = ("_val_or_len", "_places", "_type", "_buf")
	defaults = (0, 0, 0, [])


#===========================================================

#**************************
# DATA Structs & Field Values
#**************************
# field ACK -- uses ack codes from pmdef.h
#------------------------------
# 
# field=DATA::ACK
class mmp_data_ack_t(MMPMessage):
	fmt = "!H"
	args = ("_ack")
	defaults = (0)


#===========================================================

# field REMOTE_DATA, REMOTE_DLOGBLK
#------------------------------
# Note the data[1] item is variable length, but declared as 1-element to allow array indexing
# 
# field=DATA::REMOTE_DATA
# field=DATA::REMOTE_DLOGBLK
class mmp_remote_data_t(MMPMessage):
	fmt = "!HHHHb"
	args = ("_addr", "_transport", "_invalid_blks", "_len", "_data")
	defaults = (0, 0, 0, 0, [])


#===========================================================

# field XMIT_OVERTEMP
#------------------------------
# 
# field=DATA::XMIT_OVERTEMP
class mmp_data_xmit_overtemp_t(MMPMessage):
	fmt = "!HH"
	args = ("_sensor", "_setpoint_x_100")
	defaults = (0, 0)


#===========================================================

# field BURN_COMPLETE, BURN_TIMEOUT
#------------------------------
# 
# field=DATA::BURN_COMPLETE
# field=DATA::BURN_TIMEOUT
class mmp_burn_complete_t(MMPMessage):
	fmt = "!H"
	args = ("_addr")
	defaults = (0)


#===========================================================

# field ACOUTRIG_COMPLETE, ACOUTRIG_TIMEOUT
#------------------------------
# 
# field=DATA::ACOUTRIG_COMPLETE
# field=DATA::ACOUTRIG_TIMEOUT
class mmp_acoutrig_complete_t(MMPMessage):
	fmt = "!HH"
	args = ("_addr", "_assert_state")
	defaults = (0, 0)


#===========================================================

# field TRRC_STATUS   
#------------------------------
# 
# field=DATA::TRRC_STATUS
class mmp_data_trrc_status_t(MMPMessage):
	fmt = "!HHHH"
	args = ("_tr_read_fail", "_rc_read_fail", "_tr_band_fail", "_rc_band_fail")
	defaults = (0, 0, 0, 0)


#===========================================================

# field FEAT_KEY_STATUS
#------------------------------------
# 
# field=DATA::FEAT_KEY_STATUS
class mmp_data_feat_key_status_t(MMPMessage):
	fmt = "!LLLL"
	args = ("_available_features", "_expected_features", "_enabled_features", "_unauthorized_features")
	defaults = (0, 0, 0, 0)


#===========================================================

# field DATA::REMOTE_HEADER   
#------------------------------
# 
# field=DATA::REMOTE_HEADER
class mmp_data_remote_header_t(MMPMessage):
	fmt = "!BBBBBBBB"
	args = ("_type", "_extension", "_parm1", "_parm2", "_parm3", "_Rx_addr", "_Tx_addr", "_CRC")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

# field MMP_DATA_FLD_FPM_VERSION
#------------------------------------
# 
# field=DATA::FPM_VERSION
class mmp_data_fpm_version_t(MMPMessage):
	fmt = "!BB"
	args = ("_ver_major", "_ver_minor")
	defaults = (0, 0)


#===========================================================

# field TIMESTAMP
#------------------------------
# 
# field=DATA::TIMESTAMP
class mmp_data_timestamp_t(MMPMessage):
	fmt = "!HHHHH"
	args = ("_event", "_hour", "_min", "_sec", "_msec10")
	defaults = (0, 0, 0, 0, 0)


#===========================================================

# field DOPPLER
#------------------------------
# 
# field=DATA::DOPPLER
class mmp_data_doppler_t(MMPMessage):
	fmt = "!h"
	args = ("_speed")
	defaults = (0)


#===========================================================

# field DIRECTIONAL
#------------------------------
#
# field=DATA::DIRECTIONAL
class mmp_data_directional_t(MMPMessage):
	fmt = "!hhhhhhHhhhll"
	args = ("_raw_bearing", "_raw_elevation", "_cal_bearing", "_cal_elevation", "_bearing", "_elevation", "_range", "_compass", "_pitch", "_roll", "_latitude", "_longitude")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

# field DIRECTIONAL_DEBUG
#------------------------------
#
# field=DATA::DIRECTIONAL_DEBUG
class mmp_data_directional_debug_t(MMPMessage):
	fmt = "!hhhhhhhh"
	args = ("_cal_bearing", "_cal_elevation", "_AGC", "_vector", "_level_1", "_level_2", "_level_3", "_level_4")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

# field DIRECTIONAL_LOCDEBUG
#------------------------------
#
# field=DATA::DIRECTIONAL_LOCDEBUG
class mmp_data_directional_locdebug_t(MMPMessage):
	fmt = "!hhhhhhhh"
	args = ("_compass", "_pitch", "_roll", "_vector", "_level_1", "_level_2", "_level_3", "_level_4")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

#**************************
# field TONAL_LOCATOR
#------------------------------
# 
# field=DATA::TONAL_LOCATOR
class mmp_data_locator_t(MMPMessage):
	fmt = "!hhhhHHHHH"
	args = ("_bearing", "_elevation", "_vector", "_AGC", "_frequency", "_hour", "_min", "_sec", "_msec10")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

#**************************
# field LOW_POWER
#------------------------------
# 
# field=DATA::LOW_POWER
class mmp_data_lowpower_t(MMPMessage):
	fmt = "!HHL"
	args = ("_lpstat", "_waketype", "_sleep_secs")
	defaults = (0, 0, 0)


#===========================================================

# field ACSTATS
#------------------------------
# 
# field=DATA::ACSTATS
class mmp_data_acstats_t(MMPMessage):
	fmt = "!HHhhHHhhHHhHHH"
	args = ("_addr", "_mod_spec", "_speedx10", "_acq_SNRx10", "_acq_MPDx10", "_acq_RCT", "_acq_FSNR", "_hdr_SNRx10", "_hdr_CCERR", "_msg_ERR", "_msg_SNRx10", "_msg_AGC", "_msg_CCERR", "_msg_CRC")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

# field HEADER ERROR
#------------------------------
# 
# field=DATA::HEADER_ERROR
class mmp_data_hdrerr_t(MMPMessage):
	fmt = "!hhHHhhH"
	args = ("_speedx10", "_acq_SNRx10", "_acq_MPDx10", "_acq_RCT", "_acq_FSNR", "_hdr_SNRx10", "_hdr_CCERR")
	defaults = (0, 0, 0, 0, 0, 0, 0)


#===========================================================

# field RANGE_UPDATE
#------------------------------
# 
# field=DATA::RANGE_UPDATE
class mmp_data_rangeupdate_t(MMPMessage):
	fmt = "!HhLL"
	args = ("_node", "_range_type", "_range_x10", "_propdly_x10")
	defaults = (0, 0, 0, 0)


#===========================================================

# field MMP_DATA_FLD_NAV_STATUS
#------------------------------------
# 
# field=DATA::NAV_STATUS
class mmp_data_nav_status_t(MMPMessage):
	fmt = "!hhh"
	args = ("_location", "_heading", "_attitude")
	defaults = (0, 0, 0)


#===========================================================

# field FPM_BOOT_FAIL
#------------------------------------
# 
# field=DATA::FPM_BOOT_FAIL
class mmp_data_fpm_boot_failure_t(MMPMessage):
	fmt = "!h"
	args = ("_failure")
	defaults = (0)


#===========================================================

# field MMP_DATA_FLD_RCV_GAIN
#------------------------------------
# 
# field=DATA::RCV_GAIN
class mmp_data_rcv_gain_t(MMPMessage):
	fmt = "!hhh"
	args = ("_rc_atten_step1", "_rc_atten_step2", "_rc_total_gain")
	defaults = (0, 0, 0)


#===========================================================

# field SPECTRUM_STATUS
#------------------------------
# 
# field=DATA::SPECTRUM_STATUS
class mmp_spectrum_stat_t(MMPMessage):
	fmt = "!BBHLL"
	args = ("_stat", "_bins", "_step", "_freq_low", "_freq_high")
	defaults = (0, 0, 0, 0, 0)


#===========================================================

# field SPECTRUM_DATA
#------------------------------
# Note the data[1] item is variable length, but declared as 1-element to allow array indexing
# 
# field=DATA::SPECTRUM_DATA
class mmp_spectrum_data_t(MMPMessage):
	fmt = "!hhb"
	args = ("_AGC", "_bins", "_data")
	defaults = (0, 0, [])


#===========================================================

# field RLS_CMOTOR_STATUS
#------------------------------
# 
# field=DATA::RLS_CMOTOR_STATUS
class mmp_data_rls_cmotor_status_t(MMPMessage):
	fmt = "!h"
	args = ("_status")
	defaults = (0)


#===========================================================

# field JANUS_PACKET
#------------------------------
# 
# field=DATA::JANUS_PACKET
# cmd=STD::SENDJANUSPACKET
class mmp_data_janus_packet_t(MMPMessage):
	fmt = "!BBBBBBBBLHb"
	args = ("_version", "_mobility_flag", "_txrx_flag", "_forwarding_flag", "_class_userid", "_app_type", "_schedule_type", "_schedule_index_adb_upper", "_adb_lower", "_cargo_len", "_cargo")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, [])


#===========================================================

# field RNGBRG_UPDATE
#------------------------------
# 
# field=DATA::RNGBRG_UPDATE
class mmp_data_rngbrg_update_t(MMPMessage):
	fmt = "!LLHhh"
	args = ("_range", "_propdly_x10", "_node", "_azimuth", "_elevation")
	defaults = (0, 0, 0, 0, 0)


#===========================================================

#**************************
# DECKBOX Structs & Field Values
#**************************
# field SPKRVOL/PHONESVOL
#------------------------------
# 
# field=DECKBOX::SPKRVOL
# field=DECKBOX::PHONESVOL
class mmp_spkr_phones_vol_t(MMPMessage):
	fmt = "!BB"
	args = ("_volume", "_mute")
	defaults = (0, 0)


#===========================================================

# field PWRSENSE
#------------------------------
# 
# field=DECKBOX::PWRSENSE
class mmp_pwrsense_t(MMPMessage):
	fmt = "!HBB"
	args = ("_device", "_charge", "_charging")
	defaults = (0, 0, 0)


#===========================================================

# field BATTLEV
#------------------------------
# 
# field=DECKBOX::BATTLEV
class mmp_battlev_t(MMPMessage):
	fmt = "!H"
	args = ("_charge")
	defaults = (0)


#===========================================================

# field BATTVOLT
#------------------------------
# 
# field=DECKBOX::BATTVOLT
class mmp_battvolt_t(MMPMessage):
	fmt = "!H"
	args = ("_volts_x_100")
	defaults = (0)


#===========================================================

# field MODEL
#------------------------------
# 
# field=DECKBOX::MODEL
class mmp_udb_model_t(MMPMessage):
	fmt = "!H"
	args = ("_model")
	defaults = (0)


#===========================================================

# field GPS_RELAY
#------------------------------
# 
# field=DECKBOX::GPS_RELAY
class mmp_gps_relay_t(MMPMessage):
	fmt = "!H"
	args = ("_status")
	defaults = (0)


#===========================================================

# field XDCR_SWITCH
#------------------------------
# 
# field=HWCTL::XDCR_SWITCH
class mmp_xdcr_switch_t(MMPMessage):
	fmt = "!h"
	args = ("_which")
	defaults = (0)


#===========================================================

#**************************
# IFACE Structs & Field Values
#**************************
# field MMPSTAT
#------------------------------
# 
# field=IFACE::MMPSTAT
class mmp_iface_stat_t(MMPMessage):
	fmt = "!H"
	args = ("_stat")
	defaults = (0)


#===========================================================

# field ERR
#----------------------------
# Structure used to return MMP error codes.  Contains error type and the subsystem/field of the 
# request that generated it
# 
# field=IFACE::ERR
class mmp_sfl_err_t(MMPMessage):
	fmt = "!BBH"
	args = ("_subsys", "_field", "_err")
	defaults = (0, 0, 0)


#===========================================================

# field VERSION
#------------------------------
# 
# field=IFACE::VERSION
class mmp_version_t(MMPMessage):
	fmt = "!HH"
	args = ("_major", "_minor")
	defaults = (0, 0)


#===========================================================

# field CMDRESULT
#-------------------------------
# 
# field=IFACE::CMDRESULT
class mmp_cmd_result_t(MMPMessage):
	fmt = "!BBBB"
	args = ("_cmdsect", "_cmd", "_seqno", "_message")
	defaults = (0, 0, 0, 0)


#===========================================================

# field BLOCKNOTIFY, UNBLOCKNOTIFY
#----------------------------
# 
# field=IFACE::BLOCKNOTIFY
# field=IFACE::UNBLOCKNOTIFY
class mmp_iface_blocknotify_t(MMPMessage):
	fmt = "!Hb"
	args = ("_numsubsys", "_subsys")
	defaults = (0, [])


#===========================================================

# field PRIVLEV
#----------------------------
# 
# field=IFACE::PRIVLEV
class mmp_iface_privlev_t(MMPMessage):
	fmt = "!BBb"
	args = ("_privlev", "_pwlen", "_password")
	defaults = (0, 0, [])


#===========================================================

# field DSP_SW_VERSION
#------------------------------
# 
# field=IFACE::DSP_SW_VERSION
class mmp_iface_dsp_sw_version_t(MMPMessage):
	fmt = "!BBHL"
	args = ("_major", "_minor", "_revision", "_svnver")
	defaults = (0, 0, 0, 0)


#===========================================================

# field FEATURE_KEY
#------------------------------
# 
# field=IFACE::FEATURE_KEY
class mmp_iface_featurekey_t(MMPMessage):
	fmt = "!b"
	args = ("_key")
	defaults = ([None] * 16)


#===========================================================

# field UNIT_SERNO
#------------------------------
# 
# field=IFACE::UNIT_SERNO
class mmp_iface_unit_serno_t(MMPMessage):
	fmt = "!L"
	args = ("_serno")
	defaults = (0)


#===========================================================

#**************************
# field NTFY_COUNT, NTFY_CKSUM
#------------------------------
# 
# field=IFACE::NTFY_COUNT
# field=IFACE::NTFY_CKSUM
# field=IFACE::GATE_DATA_DIRECTIONAL
class mmp_iface_flag_enable_t(MMPMessage):
	fmt = "!H"
	args = ("_enable")
	defaults = (0)


#===========================================================

# field AES_USER_KEY
#------------------------------
# 
# field=IFACE::AES_USER_KEY
class mmp_iface_aes_key_t(MMPMessage):
	fmt = "!HH"
	args = ("_timeout_hrs", "_key")
	defaults = (0, [None] * 16)


#===========================================================

# field COMPATIBILITY
#------------------------------
# 
# field=IFACE::COMPATIBILITY
class mmp_iface_compatibility_t(MMPMessage):
	fmt = "!BB"
	args = ("_compat_1", "_compat_2")
	defaults = (0, 0)


#===========================================================

# field FEATURE_KEY_INVENTORY
#------------------------------
# 
# field=IFACE::FEATURE_KEY_INVENTORY
class mmp_iface_featurekeyinventory_t(MMPMessage):
	fmt = "!HHb"
	args = ("_numkeys", "_totlen", "_keys")
	defaults = (0, 0, [])


#===========================================================

#**************************
# SREG Structs & Field Values
#**************************
# 
# field=SREG::*
class mmp_sreg_fld_val_t(MMPMessage):
	fmt = "!H"
	args = ("_val")
	defaults = (0)


#===========================================================

# 
# field=SREG::ALL
class mmp_sreg_fld_val_all_t(MMPMessage):
	fmt = "!H"
	args = ("_val")
	defaults = ([None] * 60)


#===========================================================

#**************************
# TIME Structs & Field Values
#**************************
# field TIMEDATE
#------------------------------
# 
# field=TIME::TIMEDATE
class mmp_time_t(MMPMessage):
	fmt = "!BBBBBBHh"
	args = ("_isdst", "_hh", "_mm", "_ss", "_mo", "_da", "_yr", "_tz")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

# field DSTPARMS
#-------------------------------
# 
# field=TIME::DSTPARMS
class mmp_dst_t(MMPMessage):
	fmt = "!BBBBBBBB"
	args = ("_fwd_hr", "_fwd_mo", "_fwd_wk", "_fwd_dotw", "_back_hr", "_back_mo", "_back_wk", "_back_dotw")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0)


#===========================================================

# field RTCBATT
#-------------------------------
# 
# field=TIME::RTCBATT
class mmp_rtcbatt_t(MMPMessage):
	fmt = "!h"
	args = ("_rtcbatt_x100")
	defaults = (0)


#===========================================================

#**************************
# field SYNCINFO
#-------------------------------
# 
# field=TIME::SYNCINFO
class mmp_time_syncinfo_t(MMPMessage):
	fmt = "!BBBB"
	args = ("_pps_state", "_qualifying", "_time_sync", "_ext_time")
	defaults = (0, 0, 0, 0)


#===========================================================

#**************************
# TRANSPOND Structs & Field Values
#**************************
# field STAT
#------------------------------
# 
# field=TRANSPOND::STAT
class mmp_transpond_stat_t(MMPMessage):
	fmt = "!HH"
	args = ("_stat", "_timeout")
	defaults = (0, 0)


#===========================================================

# field PINGRCVD
#-------------------------------
# 
# field=TRANSPOND::PINGRCVD
class mmp_transpond_pingrcvd_t(MMPMessage):
	fmt = "!LLLH"
	args = ("_freq", "_rt_time", "_detect_lev", "_flags")
	defaults = (0, 0, 0, 0)


#===========================================================

# field CHNLRXADJ_<x> (except ALL)
#-------------------------------
# 
# field=TRANSPOND::CHNLRXADJ_0
# field=TRANSPOND::CHNLRXADJ_1
# field=TRANSPOND::CHNLRXADJ_2
# field=TRANSPOND::CHNLRXADJ_3
# field=TRANSPOND::CHNLRXADJ_4
# field=TRANSPOND::CHNLRXADJ_5
# field=TRANSPOND::CHNLRXADJ_6
# field=TRANSPOND::CHNLRXADJ_7
# field=TRANSPOND::CHNLRXADJ_8
# field=TRANSPOND::CHNLRXADJ_9
# field=TRANSPOND::CHNLRXADJ_10
# field=TRANSPOND::CHNLRXADJ_11
# field=TRANSPOND::CHNLRXADJ_12
# field=TRANSPOND::CHNLRXADJ_13
# field=TRANSPOND::CHNLRXADJ_14
# field=TRANSPOND::CHNLRXADJ_15
# field=TRANSPOND::CHNLRXADJ_16
# field=TRANSPOND::CHNLRXADJ_17
# field=TRANSPOND::CHNLRXADJ_18
# field=TRANSPOND::CHNLRXADJ_19
# field=TRANSPOND::CHNLRXADJ_20
# field=TRANSPOND::CHNLRXADJ_21
# field=TRANSPOND::CHNLRXADJ_22
# field=TRANSPOND::CHNLRXADJ_23
# field=TRANSPOND::CHNLRXADJ_24
# field=TRANSPOND::CHNLRXADJ_25
# field=TRANSPOND::CHNLRXADJ_26
# field=TRANSPOND::CHNLRXADJ_27
# field=TRANSPOND::CHNLRXADJ_28
# field=TRANSPOND::CHNLRXADJ_29
# field=TRANSPOND::CHNLRXADJ_30
# field=TRANSPOND::CHNLRXADJ_31
# field=TRANSPOND::CHNLRXADJ_32
# field=TRANSPOND::CHNLRXADJ_33
# field=TRANSPOND::CHNLRXADJ_34
# field=TRANSPOND::CHNLRXADJ_35
# field=TRANSPOND::CHNLRXADJ_36
# field=TRANSPOND::CHNLRXADJ_37
# field=TRANSPOND::CHNLRXADJ_38
# field=TRANSPOND::CHNLRXADJ_39
# field=TRANSPOND::CHNLRXADJ_40
class mmp_transpond_rxadj_t(MMPMessage):
	fmt = "!h"
	args = ("_adjustment")
	defaults = (0)


#===========================================================

# field CHNLRXADJ_ALL
#-------------------------------
# 
# field=TRANSPOND::CHNLRXADJ_ALL
class mmp_transpond_rxadjall_t(MMPMessage):
	fmt = "!h"
	args = ("_adjustment")
	defaults = ([None] * 41)


#===========================================================

# Structures populated on demand by get_smartbatt_info() API call
# 
# cmdresult=STD::GETSMARTBATTDATA
class smartbatt_info_t(MMPMessage):
	fmt = "!HhHhhHHHHHhhHHHHH"
	args = ("_batt_mode", "_temperature", "_voltage", "_current", "_avg_current", "_max_error", "_batt_charge", "_abs_charge", "_rem_capacity", "_full_chg_capacity", "_mins_to_empty", "_mins_to_full", "_batt_status", "_cycle_count", "_design_capacity", "_mfg_date", "_serno")
	defaults = (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

class MMP_Dictionary:
	subsys_dict = {
		mmp_subsys_t.MMP_SUBSYS_IFACE: {
			mmp_iface_fld_t.MMP_IFACE_FLD_MMPSTAT: (mmp_iface_stat_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_ERR: (mmp_sfl_err_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_UNIT_SERNO: (mmp_iface_unit_serno_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_NTFY_COUNT: (mmp_iface_flag_enable_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_NTFY_CKSUM: (mmp_iface_flag_enable_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_AES_USER_KEY: (mmp_iface_aes_key_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_COMPATIBILITY: (mmp_iface_compatibility_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_FEATURE_KEY_INVENTORY: (mmp_iface_featurekeyinventory_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_GATE_DATA_DIRECTIONAL: (mmp_iface_flag_enable_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_VERSION: (mmp_version_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_CMDRESULT: (mmp_cmd_result_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_BLOCKNOTIFY: (mmp_iface_blocknotify_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_UNBLOCKNOTIFY: (mmp_iface_blocknotify_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_DSP_SW_VERSION: (mmp_iface_dsp_sw_version_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_PRIVLEV: (mmp_iface_privlev_t, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_REMOTE_MMPRESP: (None, None),
			mmp_iface_fld_t.MMP_IFACE_FLD_FEATURE_KEY: (mmp_iface_featurekey_t, None),
		},
		mmp_subsys_t.MMP_SUBSYS_SREG: {
			mmp_sreg_fld_t.MMP_SREG_FLD_VERSION: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_LPTIMEOUT: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_FLOWCTRL: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_TESTMSGLEN: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_VERBOSITY: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_REMADDR: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_LOCADDR: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_POSACK: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_RXTHRESHOLD: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_BAND: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_ALL: (mmp_sreg_fld_val_all_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_SERBAUD: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_TXPULSEWIDTH: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_RXPULSEWIDTH: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_ACOUBAUD: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_TAT: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_PPSSYNC: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_RXFREQ: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_XPNDLOCKOUT: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_TXPOWER: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_RESPTIMEOUT: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_FWDDELAY: (mmp_sreg_fld_val_t, None),
			mmp_sreg_fld_t.MMP_SREG_FLD_COPROC: (mmp_sreg_fld_val_t, None),
		},
		mmp_subsys_t.MMP_SUBSYS_DECKBOX: {
			mmp_deckbox_fld_t.MMP_DECKBOX_FLD_SPKRVOL: (mmp_spkr_phones_vol_t, None),
			mmp_deckbox_fld_t.MMP_DECKBOX_FLD_PHONESVOL: (mmp_spkr_phones_vol_t, None),
			mmp_deckbox_fld_t.MMP_DECKBOX_FLD_PWRSENSE: (mmp_pwrsense_t, None),
			mmp_deckbox_fld_t.MMP_DECKBOX_FLD_BATTLEV: (mmp_battlev_t, None),
			mmp_deckbox_fld_t.MMP_DECKBOX_FLD_BATTVOLT: (mmp_battvolt_t, None),
			mmp_deckbox_fld_t.MMP_DECKBOX_FLD_MODEL: (mmp_udb_model_t, None),
			mmp_deckbox_fld_t.MMP_DECKBOX_FLD_GPS_RELAY: (mmp_gps_relay_t, None),
		},
		mmp_subsys_t.MMP_SUBSYS_DATA: {
			mmp_data_fld_t.MMP_DATA_FLD_ACK: (mmp_data_ack_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_REMOTE_DATA: (mmp_remote_data_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_DIRECTIONAL: (mmp_data_directional_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_FPM_VERSION: (mmp_data_fpm_version_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_PSK_PKT_NO_COPROC: (None, None),
			mmp_data_fld_t.MMP_DATA_FLD_LOW_POWER: (mmp_data_lowpower_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_ACSTATS: (mmp_data_acstats_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_REMOTE_DLOGBLK: (mmp_remote_data_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_HEADER_ERROR: (mmp_data_hdrerr_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_NAV_STATUS: (mmp_data_nav_status_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_RANGE_UPDATE: (mmp_data_rangeupdate_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_FPM_BOOT_FAIL: (mmp_data_fpm_boot_failure_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_XMIT_OVERTEMP: (mmp_data_xmit_overtemp_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_RCV_GAIN: (mmp_data_rcv_gain_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_SPECTRUM_STATUS: (mmp_spectrum_stat_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_SPECTRUM_DATA: (mmp_spectrum_data_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_DIRECTIONAL_DEBUG: (mmp_data_directional_debug_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_TONAL_LOCATOR: (mmp_data_locator_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_DIRECTIONAL_LOCDEBUG: (mmp_data_directional_locdebug_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_JANUS_PACKET: (mmp_data_janus_packet_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_ACOUTRIG_COMPLETE: (mmp_acoutrig_complete_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_ACOUTRIG_TIMEOUT: (mmp_acoutrig_complete_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_BURN_COMPLETE: (mmp_burn_complete_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_RESPBUFFER_XMIT: (None, None),
			mmp_data_fld_t.MMP_DATA_FLD_RNGBRG_UPDATE: (mmp_data_rngbrg_update_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_TRRC_STATUS: (mmp_data_trrc_status_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_FEAT_KEY_STATUS: (mmp_data_feat_key_status_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_REMOTE_HEADER: (mmp_data_remote_header_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_TIMESTAMP: (mmp_data_timestamp_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_DOPPLER: (mmp_data_doppler_t, None),
			mmp_data_fld_t.MMP_DATA_FLD_BURN_TIMEOUT: (mmp_burn_complete_t, None),
		},
		mmp_subsys_t.MMP_SUBSYS_TRANSPOND: {
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_STAT: (mmp_transpond_stat_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_PINGRCVD: (mmp_transpond_pingrcvd_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_8: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_9: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_10: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_11: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_12: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_13: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_14: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_15: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_16: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_17: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_0: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_18: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_19: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_20: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_21: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_22: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_23: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_24: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_25: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_26: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_27: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_1: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_28: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_29: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_30: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_31: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_32: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_33: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_34: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_35: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_36: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_37: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_2: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_38: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_39: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_40: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_ALL: (mmp_transpond_rxadjall_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_3: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_4: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_5: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_6: (mmp_transpond_rxadj_t, None),
			mmp_transpond_fld_t.MMP_TRANSPOND_FLD_CHNLRXADJ_7: (mmp_transpond_rxadj_t, None),
		},
		mmp_subsys_t.MMP_SUBSYS_TIME: {
			mmp_time_fld_t.MMP_TIME_FLD_1PPS_PULSE: (None, None),
			mmp_time_fld_t.MMP_TIME_FLD_TIMEDATE: (mmp_time_t, None),
			mmp_time_fld_t.MMP_TIME_FLD_DSTPARMS: (mmp_dst_t, None),
			mmp_time_fld_t.MMP_TIME_FLD_RTCBATT: (mmp_rtcbatt_t, None),
			mmp_time_fld_t.MMP_TIME_FLD_SYNCINFO: (mmp_time_syncinfo_t, None),
		},
		mmp_subsys_t.MMP_SUBSYS_CFG_ALL: {
		},
		mmp_subsys_t.CFG_SECT_COPROC: {
			cfg_coproc_param_enum_t.CFG_COPROC_CPBOARD: (mmp_cfg_paramval_t, None),
			cfg_coproc_param_enum_t.CFG_COPROC_FDFWDTAPS: (mmp_cfg_paramval_t, None),
			cfg_coproc_param_enum_t.CFG_COPROC_FDBCKTAPS: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_DATALOG: {
			cfg_datalog_param_enum_t.CFG_DATALOG_ACDATA: (mmp_cfg_paramval_t, None),
			cfg_datalog_param_enum_t.CFG_DATALOG_ACSTATS: (mmp_cfg_paramval_t, None),
			cfg_datalog_param_enum_t.CFG_DATALOG_RINGBUF: (mmp_cfg_paramval_t, None),
			cfg_datalog_param_enum_t.CFG_DATALOG_SUBBLKS: (mmp_cfg_paramval_t, None),
			cfg_datalog_param_enum_t.CFG_DATALOG_LOGMODE: (mmp_cfg_paramval_t, None),
			cfg_datalog_param_enum_t.CFG_DATALOG_SENTINEL: (mmp_cfg_paramval_t, None),
			cfg_datalog_param_enum_t.CFG_DATALOG_CHRCOUNT: (mmp_cfg_paramval_t, None),
			cfg_datalog_param_enum_t.CFG_DATALOG_LOGSTORE: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_MODEM: {
			cfg_modem_param_enum_t.CFG_MODEM_DATARETRY: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_ACRSPTMOUT: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_RXPKTTYPE: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_SHOWBADDATA: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_STARTTONES: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_TXRATE: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_TXPOWER: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_WAKETONES: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_RSVD1: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_INPUTMODE: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_SMARTRETRY: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_L2PROTOCOL: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_OPMODE: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_HEADERRATE: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_DOMAINKEY: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_AUTODETECTHDR: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_CHIRP_THRESHOLD: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_TXATTEN: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_ADDRGROUP: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_APCNOISSEL: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_APCALPHSM: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_APCALPHSM2: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_APCMAXTXP: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_DEVENABLE: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_APCMINTXP: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_ACKMODE_DONOTUSE: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_UNUSED1: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_FWDDELAY: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_UNUSED2: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_LOCALADDR: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_PRNTHEX: (mmp_cfg_paramval_t, None),
			cfg_modem_param_enum_t.CFG_MODEM_REMOTEADDR: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_RELEASE: {
			cfg_release_param_enum_t.CFG_RELEASE_FSKRLSDUR: (mmp_cfg_paramval_t, None),
			cfg_release_param_enum_t.CFG_RELEASE_LSTCOMMSCNT: (mmp_cfg_paramval_t, None),
			cfg_release_param_enum_t.CFG_RELEASE_RLSCODE: (mmp_cfg_paramval_t, None),
			cfg_release_param_enum_t.CFG_RELEASE_UNUSED1: (mmp_cfg_paramval_t, None),
			cfg_release_param_enum_t.CFG_RELEASE_TIMEDRELEASE: (mmp_cfg_paramval_t, None),
			cfg_release_param_enum_t.CFG_RELEASE_MOTORTYPE: (mmp_cfg_paramval_t, None),
			cfg_release_param_enum_t.CFG_RELEASE_RLSMINENATIME: (mmp_cfg_paramval_t, None),
			cfg_release_param_enum_t.CFG_RELEASE_RLSMAXENATIME: (mmp_cfg_paramval_t, None),
			cfg_release_param_enum_t.CFG_RELEASE_ACOUTRIGTERM: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_SERIAL: {
			cfg_serial_param_enum_t.CFG_SERIAL_P1BAUD: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P1ECHOCHAR: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2IDLEPOL: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2STRIPB7: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2NOSLEEP: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P1MODE: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2MODE: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2PROTOCOL: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_LPFLOWCTL: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P1PROMPT: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2PROMPT: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P1FLOWCTL: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P1IDLEPOL: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P1PROTOCOL: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P1STRIPB7: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P1NOSLEEP: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2BAUD: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2ECHOCHAR: (mmp_cfg_paramval_t, None),
			cfg_serial_param_enum_t.CFG_SERIAL_P2FLOWCTL: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_SYSTEM: {
			cfg_system_param_enum_t.CFG_SYSTEM_AUXINP: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_ASCIIBIN: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_SYNCPPS: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_VERBOSE: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_WAKETHRESH: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_AUXOUT: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_UNUSED1: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_VOLCONT: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_CMFASTWAKE: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_NAMEFORMAT: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_IDLETIMER: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_PROMPT: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_BANDWIDTH: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_SYNCOUT: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_PULLUP0: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_PULLUP1: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_MINOPVOLT: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_BATTERYTYPE: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_BATTERYCAPACITY: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_BATTERYMFGDATE: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_TILTAXIS: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_PWRONTIMER: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_AWAKETIMER: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_CARRFREQ: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_ARWAKEHIB: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_RXSENS: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_AWAKEPOWER: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_TXSENS: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_TXINTERP: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_IOMODE0: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_COMPMDMRST: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_CMWAKEHIB: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_CMWAKELISTEN: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_HALFBW: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_FHTHRESH: (mmp_cfg_paramval_t, None),
			cfg_system_param_enum_t.CFG_SYSTEM_RLSTYPE: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_TEST: {
			cfg_test_param_enum_t.CFG_TEST_DBGLVL: (mmp_cfg_paramval_t, None),
			cfg_test_param_enum_t.CFG_TEST_RCVALL: (mmp_cfg_paramval_t, None),
			cfg_test_param_enum_t.CFG_TEST_RSPDELAY: (mmp_cfg_paramval_t, None),
			cfg_test_param_enum_t.CFG_TEST_PKTECHO: (mmp_cfg_paramval_t, None),
			cfg_test_param_enum_t.CFG_TEST_PKTSIZE: (mmp_cfg_paramval_t, None),
			cfg_test_param_enum_t.CFG_TEST_UNUSED1: (mmp_cfg_paramval_t, None),
			cfg_test_param_enum_t.CFG_TEST_SIMACDLY: (mmp_cfg_paramval_t, None),
			cfg_test_param_enum_t.CFG_TEST_TXSATURATE: (mmp_cfg_paramval_t, None),
			cfg_test_param_enum_t.CFG_TEST_UNUSED2: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_VERSION: {
			cfg_version_param_enum_t.CFG_VERSION_SWAPPNAME: (mmp_cfg_paramval_t, None),
			cfg_version_param_enum_t.CFG_VERSION_SWVERSION: (mmp_cfg_paramval_t, None),
			cfg_version_param_enum_t.CFG_VERSION_DBVERSION: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_XPND: {
			cfg_xpnd_param_enum_t.CFG_XPND_RXFREQ: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_RXLOCKOUT: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_XPNDEMUMODE: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_HPR400CHAN: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_RESPONDER: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_CHIRP_RESP: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_BANDWIDTH: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_LOGRESULTS: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_GAPSRX: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_GAPSTX: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_GAPSWAKE: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_RXTONEDUR: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_TAT: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_TXTONEDUR: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_RXTHRESH: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_AGCREF: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_RESPFREQ: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_LBLMODE: (mmp_cfg_paramval_t, None),
			cfg_xpnd_param_enum_t.CFG_XPND_XPNDEMUTAT: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_DAT: {
			cfg_dat_param_enum_t.CFG_DAT_PREGAIN: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_ROTATION: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_BEARINGRESP: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_VTHRESH: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_MIN_ELEV: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_MAX_ELEV: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_PHASEREF: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_ARRIVAL: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_VERBOSE: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_RXONDAT: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_WRAPRANGE: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_ORIENTATION: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_PHASEA: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_PHASEB: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_PHASEC: (mmp_cfg_paramval_t, None),
			cfg_dat_param_enum_t.CFG_DAT_PHASED: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_NAV: {
			cfg_nav_param_enum_t.CFG_NAV_LATITUDE: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_LONGITUDE: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_HEADOFFSET: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_SYNCRANGING: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_PITCHOFFSET: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_ROLLOFFSET: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_GPSSYNCMSG: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_GPSALT: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_ALTITUDE: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_DEPTH: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_COMPASS: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_PITCH: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_ROLL: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_CSOUND: (mmp_cfg_paramval_t, None),
			cfg_nav_param_enum_t.CFG_NAV_REPLY_DATA: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_RECORDER: {
			cfg_recorder_param_enum_t.CFG_RECORDER_FRONTEND: (mmp_cfg_paramval_t, None),
			cfg_recorder_param_enum_t.CFG_RECORDER_RECMODE: (mmp_cfg_paramval_t, None),
			cfg_recorder_param_enum_t.CFG_RECORDER_RECFORMAT: (mmp_cfg_paramval_t, None),
			cfg_recorder_param_enum_t.CFG_RECORDER_NAMEFORMAT: (mmp_cfg_paramval_t, None),
			cfg_recorder_param_enum_t.CFG_RECORDER_RXSENS: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_TRANSPORT: {
			cfg_transport_param_enum_t.CFG_TRANSPORT_L4ENB: (mmp_cfg_paramval_t, None),
			cfg_transport_param_enum_t.CFG_TRANSPORT_TPMODE: (mmp_cfg_paramval_t, None),
			cfg_transport_param_enum_t.CFG_TRANSPORT_DST1: (mmp_cfg_paramval_t, None),
			cfg_transport_param_enum_t.CFG_TRANSPORT_DST2: (mmp_cfg_paramval_t, None),
			cfg_transport_param_enum_t.CFG_TRANSPORT_DST3: (mmp_cfg_paramval_t, None),
			cfg_transport_param_enum_t.CFG_TRANSPORT_DST4: (mmp_cfg_paramval_t, None),
			cfg_transport_param_enum_t.CFG_TRANSPORT_SRCP1: (mmp_cfg_paramval_t, None),
			cfg_transport_param_enum_t.CFG_TRANSPORT_SRCP2: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_AIN: {
			cfg_ain_param_enum_t.CFG_AIN_POLLRATE: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_1NMEAS: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_3STRTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_3RPTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_4NMEAS: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_4STRTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_4RPTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_5NMEAS: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_5STRTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_5RPTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_6NMEAS: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_6STRTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_1STRTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_6RPTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_1RPTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_1TYPE: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_2NMEAS: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_2STRTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_2RPTDLY: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_2TYPE: (None, None),
			cfg_ain_param_enum_t.CFG_AIN_3NMEAS: (None, None),
		},
		mmp_subsys_t.CFG_SECT_PRESSURE: {
			cfg_pressure_param_enum_t.CFG_PRESSURE_AINCHNL: (None, None),
			cfg_pressure_param_enum_t.CFG_PRESSURE_METERSPERPSI: (None, None),
			cfg_pressure_param_enum_t.CFG_PRESSURE_ATMOFFSET: (None, None),
			cfg_pressure_param_enum_t.CFG_PRESSURE_PSI: (None, None),
		},
		mmp_subsys_t.CFG_SECT_USBL: {
			cfg_usbl_param_enum_t.CFG_USBL_FORMAT: (mmp_cfg_paramval_t, None),
			cfg_usbl_param_enum_t.CFG_USBL_DEPTH_QUERY: (mmp_cfg_paramval_t, None),
			cfg_usbl_param_enum_t.CFG_USBL_REPEAT_QUERY: (mmp_cfg_paramval_t, None),
			cfg_usbl_param_enum_t.CFG_USBL_AUTO_QUERY: (mmp_cfg_paramval_t, None),
			cfg_usbl_param_enum_t.CFG_USBL_AUTO_DELAY: (mmp_cfg_paramval_t, None),
			cfg_usbl_param_enum_t.CFG_USBL_XDCER_DEPTH: (mmp_cfg_paramval_t, None),
		},
		mmp_subsys_t.CFG_SECT_JANUS: {
			cfg_janus_param_enum_t.CFG_JANUS_CLASSUSERID: (None, None),
			cfg_janus_param_enum_t.CFG_JANUS_APPTYPE: (None, None),
			cfg_janus_param_enum_t.CFG_JANUS_MACTHRESH: (None, None),
		},
	}

	cmdsect_dict = {
		mmp_cmdsect_t.MMP_CMDSECT_NULL: {
		},
		mmp_cmdsect_t.MMP_CMDSECT_STD: {
			mmp_std_cmd_t.MMP_STD_CMD_INFO: (None, None),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_MMPREQ: (mmp_remote_request_t, mmp_remote_mmpresp_t),
			mmp_std_cmd_t.MMP_STD_CMD_RESET: (None, None),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETBATT: (mmp_remote_t, mmp_remote_battvoltage_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_CMWAKEUP: (mmp_remote_cmwakeup_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETAGCHIST: (mmp_remote_t, mmp_remote_agchist_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_AUTOBAUD: (mmp_remote_autobaud_t, mmp_remote_autobaud_result_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETBATTCHG: (mmp_remote_t, mmp_remote_battcharge_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SENDCMD: (mmp_remote_senddata_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_TILT_ACCEL: (mmp_tilt_accel_t, mmp_tilt_accel_response_t),
			mmp_std_cmd_t.MMP_STD_CMD_AXIS_TILT: (None, mmp_axis_tilt_response_t),
			mmp_std_cmd_t.MMP_STD_CMD_RESET_BATT_METERING: (None, None),
			mmp_std_cmd_t.MMP_STD_CMD_FLASH_SREGS: (None, None),
			mmp_std_cmd_t.MMP_STD_CMD_BATT_METER: (None, battery_metering_info_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETMETER: (mmp_remote_t, battery_metering_info_t),
			mmp_std_cmd_t.MMP_STD_CMD_GETBATT: (None, mmp_battvoltage_t),
			mmp_std_cmd_t.MMP_STD_CMD_GETBATTCHG: (None, mmp_battcharge_t),
			mmp_std_cmd_t.MMP_STD_CMD_GETAGCHIST: (None, mmp_agchist_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETONESREG: (mmp_remote_getonesreg_t, mmp_remote_getonesreg_resp_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SETONESREG: (mmp_remote_setonesreg_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_RESET: (mmp_remote_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_BOARD_TEMP: (mmp_board_temp_t, mmp_board_temp_resp_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SENDBREAK: (mmp_remote_senddata_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_RESET_SREGS: (None, None),
			mmp_std_cmd_t.MMP_STD_CMD_CONT_XMIT_TEST: (mmp_std_contxmit_enable_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_SET_REMOTE_GROUP: (mmp_std_set_remote_group_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_GETSMARTBATTDATA: (mmp_std_getsmartbattdata_t, smartbatt_info_t),
			mmp_std_cmd_t.MMP_STD_CMD_ADDFEATUREKEY: (mmp_std_featkeystring_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_DELFEATUREKEY: (mmp_std_featkeystring_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_HANGUP: (mmp_remote_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_SENDJANUSPACKET: (mmp_data_janus_packet_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_WRITE_DEVICE: (mmp_write_device_t, mmp_write_device_result_t),
			mmp_std_cmd_t.MMP_STD_CMD_READ_DEVICE: (mmp_read_device_t, mmp_read_device_result_t),
			mmp_std_cmd_t.MMP_STD_CMD_LEN_DEVICE: (mmp_len_device_t, mmp_len_device_result_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SETACOUBAUD: (mmp_remote_setacoubaud_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_FIND_DEVICE: (mmp_find_device_t, mmp_find_device_result_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SETTXPOWER: (mmp_remote_settxpower_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_GETSREGS: (mmp_remote_t, mmp_remote_sregisters_t),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_SENDDATA: (mmp_remote_senddata_t, None),
			mmp_std_cmd_t.MMP_STD_CMD_REMOTE_TESTLINK: (mmp_remote_t, mmp_remote_testmsgstats_t),
			mmp_std_cmd_t.MMP_STD_CMD_UPDATE_FIRMWARE: (mmp_update_firmware_t, None),
		},
		mmp_cmdsect_t.MMP_CMDSECT_RNGRLS: {
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_TRANSPOND: (mmp_rngrls_transpond_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RANGE: (mmp_rngrls_range_t, mmp_rngrls_cmdresult_range_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_GEOPRO_RELEASE: (mmp_rngrls_geopro_param_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_NAVDATA: (mmp_rngrls_navdata_t, mmp_rngrls_cmdresult_navdata_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_CHANNEL_PROBE: (mmp_rngrls_channel_probe_param_t, mmp_rngrls_cmdresult_channel_probe_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_RANGE: (mmp_rngrls_rseries_range_t, mmp_rngrls_cmdresult_range_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_ACTIVATE: (mmp_rngrls_rseries_activate_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_HIBERNATE: (mmp_rngrls_rseries_hib_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_XPND_MODE: (mmp_rngrls_xpnd_mode_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_STD_XPND_MODE: (mmp_rngrls_xpnd_mode_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_DB_UNLOCK: (mmp_rngrls_rseries_dblock_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_DB_LOCK: (mmp_rngrls_rseries_dblock_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RELEASE_STATUS: (mmp_rngrls_release_status_t, mmp_rngrls_cmdresult_release_status_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RSERIES_RELEASE: (mmp_rngrls_rseries_release_t, mmp_rngrls_cmdresult_release_response_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RESPONDER_RANGE: (mmp_rngrls_responder_range_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_TRANSPOND_W_TIMEOUT: (mmp_rngrls_transpond_w_timeout_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RANGE_W_TIMEOUT: (mmp_rngrls_range_t, mmp_rngrls_cmdresult_range_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_SPECTRUM_MODE: (mmp_rngrls_spectrum_mode_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_RANGE_USBL_REPEAT: (mmp_rngrls_range_repeat_t, mmp_rngrls_cmdresult_range_usbl_repeat_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_ABSREL: (mmp_rngrls_absrel_t, mmp_rngrls_cmdresult_absrel_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_ACOU_SAMPLE: (None, mmp_rngrls_cmdresult_acou_sample_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_SMART_RELEASE: (mmp_rngrls_smart_release_burnwire_t, mmp_rngrls_cmdresult_release_response_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_ABSCMPDEP: (mmp_rngrls_absrel_t, mmp_rngrls_cmdresult_abscmpdep_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_ACOUSTIC_TRIGGER: (mmp_rngrls_acoustic_trigger_t, mmp_rngrls_cmdresult_release_response_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_BEARING_W_TIMEOUT: (mmp_rngrls_bearing_t, mmp_rngrls_cmdresult_bearing_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_BURNWIRE: (mmp_rngrls_smart_release_burnwire_t, mmp_rngrls_cmdresult_release_response_t),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_FSK_RELEASE: (mmp_rngrls_fsk_param_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_EDGETECH_RELEASE: (mmp_rngrls_edgetech_param_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_URI_RELEASE: (mmp_rngrls_uri_param_t, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_FLASH_XPNDADJ: (None, None),
			mmp_rngrls_cmd_t.MMP_RNGRLS_CMD_BEARING: (mmp_rngrls_bearing_t, mmp_rngrls_cmdresult_bearing_t),
		},
		mmp_cmdsect_t.MMP_CMDSECT_DATALOG: {
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_CLEAR: (mmp_remote_or_local_t, None),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_SIZE: (mmp_remote_or_local_t, mmp_datalog_cmdresult_size_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_DUMP: (mmp_datalog_dump_t, mmp_datalog_cmdresult_dump_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_SRCINFO: (mmp_datalog_srcinfo_t, mmp_datalog_cmdresult_srcinfo_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_REMOTE_GETDLOGBLK: (mmp_datalog_remote_getdlogblk_t, None),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_READ_DATA: (mmp_datalog_read_t, mmp_datalog_cmdresult_read_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_READ_PAGE: (mmp_datalog_read_t, mmp_datalog_cmdresult_read_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_READ_SECTOR: (mmp_datalog_read_t, mmp_datalog_cmdresult_read_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_WRITE_DATA: (mmp_datalog_write_t, mmp_datalog_cmdresult_write_data_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_SEEK: (mmp_datalog_seek_t, None),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_TELL: (None, mmp_datalog_cmdresult_tell_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_LIST: (None, mmp_datalog_cmdresult_list_t),
			mmp_datalog_cmd_t.MMP_DATALOG_CMD_FIND: (mmp_datalog_find_t, mmp_datalog_cmdresult_find_t),
		},
	}

	msgbody_dict = {
		mmp_axis_tilt_response_t: {
			"_axis_w_pol": tilt_axis_and_polarity_t,
		},
		mmp_battcharge_t: {
			"_charge": mmp_remote_battcharge_charge_t,
		},
		mmp_battlev_t: {
			"_charge": mmp_deckbox_battlev_charge_t,
		},
		mmp_cfg_paramval_t: {
			"_type": cfg_param_type_t,
			"_val_or_len": mmp_various_t,
		},
		mmp_cmd_result_t: {
			"_cmdsect": mmp_cmdsect_t,
			"_message": mmp_cmdresult_msg_t,
		},
		mmp_data_ack_t: {
			"_ack": ack_code_t,
		},
		mmp_data_acstats_t: {
			"_mod_spec": modspec_t,
		},
		mmp_data_feat_key_status_t: {
			"_available_features": modem_feature_bitflag_t,
			"_enabled_features": modem_feature_bitflag_t,
			"_expected_features": modem_feature_bitflag_t,
			"_unauthorized_features": modem_feature_bitflag_t,
		},
		mmp_data_fpm_boot_failure_t: {
			"_failure": mmp_bool_t,
		},
		mmp_data_janus_packet_t: {
			"_class_userid": JANUS_classid_t,
			"_schedule_type": mmp_janus_schedule_type_t,
		},
		mmp_data_lowpower_t: {
			"_lpstat": mmp_lowpower_lpstat_t,
			"_waketype": wake_type_t,
		},
		mmp_data_nav_status_t: {
			"_attitude": nav_validity_t,
			"_heading": nav_validity_t,
			"_location": nav_validity_t,
		},
		mmp_data_rangeupdate_t: {
			"_range_type": mmp_rangeupdate_range_type_t,
		},
		mmp_data_remote_header_t: {
			"_type": std_layer2_command_t,
		},
		mmp_data_timestamp_t: {
			"_event": mmp_timestamp_event_t,
		},
		mmp_data_trrc_status_t: {
			"_rc_band_fail": mmp_bool_t,
			"_rc_read_fail": mmp_bool_t,
			"_tr_band_fail": mmp_bool_t,
			"_tr_read_fail": mmp_bool_t,
		},
		mmp_datalog_cmdresult_dump_t: {
			"_source": datalog_source_t,
		},
		mmp_datalog_cmdresult_find_t: {
			"_source_flags": datalog_source_flag_t,
		},
		mmp_datalog_cmdresult_list_t: {
			"_source_flags": datalog_source_flag_t,
			"_storeloc": datalog_store_t,
		},
		mmp_datalog_cmdresult_srcinfo_t: {
			"_source_flags": datalog_source_flag_t,
			"_storeloc": datalog_store_t,
		},
		mmp_datalog_cmdresult_write_data_t: {
			"_status": mmp_datalog_cmdresult_write_data_status_t,
		},
		mmp_datalog_dump_t: {
			"_source": datalog_source_t,
		},
		mmp_datalog_remote_getdlogblk_t: {
			"_source": datalog_source_t,
		},
		mmp_datalog_srcinfo_t: {
			"_source_flags": datalog_source_flag_t,
		},
		mmp_gps_relay_t: {
			"_status": mmp_gps_relay_mode_t,
		},
		mmp_iface_stat_t: {
			"_stat": mmp_iface_stat_status_t,
		},
		mmp_pwrsense_t: {
			"_charge": mmp_deckbox_pwrsense_charge_t,
			"_charging": mmp_bool_t,
			"_device": mmp_deckbox_pwrsense_device_t,
		},
		mmp_remote_autobaud_result_t: {
			"_set_flags": autobaud_set_flags_t,
		},
		mmp_remote_autobaud_t: {
			"_max_modspec": modspec_t,
			"_min_modspec": modspec_t,
			"_set_flags": autobaud_set_flags_t,
		},
		mmp_remote_battcharge_t: {
			"_charge": mmp_remote_battcharge_charge_t,
		},
		mmp_remote_request_t: {
			"_flags": mmp_remote_request_flag_t,
		},
		mmp_remote_setacoubaud_t: {
			"_modspec": modspec_t,
		},
		mmp_remote_settxpower_t: {
			"_txpower": txpower_t,
		},
		mmp_remote_testmsgstats_t: {
			"_mod_spec": modspec_t,
			"_remote_txpwr": mmp_remote_testmsgstats_txpwr_t,
		},
		mmp_rngrls_bearing_t: {
			"_tat": mmp_rngrls_bearing_tat_t,
			"_type": mmp_rngrls_bearing_type_t,
		},
		mmp_rngrls_channel_probe_param_t: {
			"_log": mmp_rngrls_probe_log_t,
		},
		mmp_rngrls_cmdresult_navdata_t: {
			"_type": navdata_type_t,
		},
		mmp_rngrls_cmdresult_release_response_t: {
			"_status": ack_code_t,
		},
		mmp_rngrls_cmdresult_release_status_t: {
			"_battery": battery_status_t,
			"_status": rls_status_code_t,
			"_tilt": tilt_status_t,
		},
		mmp_rngrls_edgetech_param_t: {
			"_freq_spec": edgetech_freqspec_t,
		},
		mmp_rngrls_fsk_param_t: {
			"_code": mmp_rngrls_fsk_code_t,
		},
		mmp_rngrls_geopro_param_t: {
			"_cmdtype": geopro_cmd_t,
		},
		mmp_rngrls_navdata_t: {
			"_type": mmp_rngrls_bearing_type_t,
		},
		mmp_rngrls_transpond_t: {
			"_rcv_only": mmp_bool_t,
			"_silent": mmp_bool_t,
		},
		mmp_sfl_err_t: {
			"_err": mmp_iface_err_t,
		},
		mmp_spectrum_stat_t: {
			"_stat": mmp_spectrum_stat_status_t,
		},
		mmp_spkr_phones_vol_t: {
			"_mute": mmp_bool_t,
			"_volume": mmp_u8_bit_range_t,
		},
		mmp_sreg_fld_val_t: {
			"_val": mmp_sreg_band_t,
		},
		mmp_std_contxmit_enable_t: {
			"_enable": mmp_bool_t,
		},
		mmp_time_syncinfo_t: {
			"_ext_time": mmp_bool_t,
			"_pps_state": pps_sync_state_t,
			"_qualifying": mmp_bool_t,
			"_time_sync": tss_state_t,
		},
		mmp_transpond_pingrcvd_t: {
			"_flags": mmp_transpond_pingrcvd_flag_t,
		},
		mmp_transpond_stat_t: {
			"_stat": mmp_transpond_stat_status_t,
		},
		mmp_udb_model_t: {
			"_model": mmp_deckbox_model_t,
		},
	}

