/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID ABS = 1134309211U;
        static const AkUniqueID ACCELENGINE = 3672365669U;
        static const AkUniqueID ACCELEXHAUST = 2877878251U;
        static const AkUniqueID AMBIENCE = 85412153U;
        static const AkUniqueID CONTACTDAMAGE = 3720364492U;
        static const AkUniqueID DAMAGE = 1786804762U;
        static const AkUniqueID ENGINE = 268529915U;
        static const AkUniqueID EXHAUST = 1377834261U;
        static const AkUniqueID FLAME = 1590552294U;
        static const AkUniqueID GEARSWITCHDOWN = 3539630744U;
        static const AkUniqueID GEARSWITCHUP = 4124367675U;
        static const AkUniqueID INDICATOR = 3405468100U;
        static const AkUniqueID NOS = 544973847U;
        static const AkUniqueID PLAY_BRAKES = 749483426U;
        static const AkUniqueID PLAY_CRASHLONG = 669976853U;
        static const AkUniqueID PLAY_HANDBREAK = 3324933786U;
        static const AkUniqueID PLAY_QUICK_BRAKE = 489739855U;
        static const AkUniqueID REPAIR = 2102349170U;
        static const AkUniqueID ROADBUMP = 2566788879U;
        static const AkUniqueID SKID = 822292696U;
        static const AkUniqueID STOP_BRAKES = 1775716168U;
        static const AkUniqueID STOP_CRASHLONG = 1812414295U;
        static const AkUniqueID STOP_HANDBREAK = 933980564U;
        static const AkUniqueID STOP_INDICATOR = 2788506979U;
        static const AkUniqueID TIRE = 3006696107U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace CAMERAPOSITION
        {
            static const AkUniqueID GROUP = 884718081U;

            namespace STATE
            {
                static const AkUniqueID NEW_STATE = 2021425847U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace CAMERAPOSITION

        namespace ISAIRBORNE
        {
            static const AkUniqueID GROUP = 1166993875U;

            namespace STATE
            {
                static const AkUniqueID FALSE = 2452206122U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID TRUE = 3053630529U;
            } // namespace STATE
        } // namespace ISAIRBORNE

        namespace ISBRAKING
        {
            static const AkUniqueID GROUP = 2959914603U;

            namespace STATE
            {
                static const AkUniqueID FALSE = 2452206122U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID TRUE = 3053630529U;
            } // namespace STATE
        } // namespace ISBRAKING

        namespace LOAD
        {
            static const AkUniqueID GROUP = 523229933U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID OFFLOAD = 2987420976U;
                static const AkUniqueID ONLOAD = 2466053606U;
            } // namespace STATE
        } // namespace LOAD

        namespace MALL
        {
            static const AkUniqueID GROUP = 3111576183U;

            namespace STATE
            {
                static const AkUniqueID INSIDE = 3553349781U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID OUTSIDE = 438105790U;
            } // namespace STATE
        } // namespace MALL

        namespace SURFACE
        {
            static const AkUniqueID GROUP = 1834394558U;

            namespace STATE
            {
                static const AkUniqueID ASPHALT = 4169408098U;
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID GRAVEL = 2185786256U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace SURFACE

    } // namespace STATES

    namespace SWITCHES
    {
        namespace ACCELINTENCITY
        {
            static const AkUniqueID GROUP = 1333843330U;

            namespace SWITCH
            {
                static const AkUniqueID HIGH = 3550808449U;
                static const AkUniqueID LOW = 545371365U;
                static const AkUniqueID MED = 981339021U;
                static const AkUniqueID VERYHIGH = 390941685U;
            } // namespace SWITCH
        } // namespace ACCELINTENCITY

        namespace ASSISTANCE
        {
            static const AkUniqueID GROUP = 1233885117U;

            namespace SWITCH
            {
                static const AkUniqueID ABS = 1134309211U;
                static const AkUniqueID ESP = 1016277431U;
                static const AkUniqueID TCS = 879540517U;
            } // namespace SWITCH
        } // namespace ASSISTANCE

        namespace BRAKETYPE
        {
            static const AkUniqueID GROUP = 2064179654U;

            namespace SWITCH
            {
                static const AkUniqueID LONG = 674228435U;
                static const AkUniqueID MEDIUM = 2849147824U;
                static const AkUniqueID QUICK = 1666346102U;
            } // namespace SWITCH
        } // namespace BRAKETYPE

        namespace CRASHTYPE
        {
            static const AkUniqueID GROUP = 3838421974U;

            namespace SWITCH
            {
                static const AkUniqueID BIG = 647611021U;
                static const AkUniqueID SMALL = 1846755610U;
            } // namespace SWITCH
        } // namespace CRASHTYPE

        namespace CURRENTGEAR
        {
            static const AkUniqueID GROUP = 1676588817U;

            namespace SWITCH
            {
                static const AkUniqueID GEAR_1 = 1307359308U;
                static const AkUniqueID GEAR_2 = 1307359311U;
                static const AkUniqueID GEAR_3 = 1307359310U;
                static const AkUniqueID GEAR_4 = 1307359305U;
                static const AkUniqueID GEAR_5 = 1307359304U;
                static const AkUniqueID GEAR_6 = 1307359307U;
                static const AkUniqueID GEAR_N = 1307359251U;
                static const AkUniqueID GEAR_R = 1307359247U;
            } // namespace SWITCH
        } // namespace CURRENTGEAR

        namespace DRIFTING
        {
            static const AkUniqueID GROUP = 1543635962U;

            namespace SWITCH
            {
            } // namespace SWITCH
        } // namespace DRIFTING

        namespace ENGINEPOS
        {
            static const AkUniqueID GROUP = 2271556599U;

            namespace SWITCH
            {
                static const AkUniqueID ENGINE = 268529915U;
                static const AkUniqueID EXHAUST = 1377834261U;
            } // namespace SWITCH
        } // namespace ENGINEPOS

        namespace INDICATOR
        {
            static const AkUniqueID GROUP = 3405468100U;

            namespace SWITCH
            {
                static const AkUniqueID BOTH = 1576947084U;
                static const AkUniqueID L = 84696435U;
                static const AkUniqueID R = 84696429U;
            } // namespace SWITCH
        } // namespace INDICATOR

        namespace SURFACE
        {
            static const AkUniqueID GROUP = 1834394558U;

            namespace SWITCH
            {
                static const AkUniqueID ASPHALT = 4169408098U;
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID GRAVEL = 2185786256U;
            } // namespace SWITCH
        } // namespace SURFACE

        namespace TURBO
        {
            static const AkUniqueID GROUP = 1624708103U;

            namespace SWITCH
            {
                static const AkUniqueID OFF = 930712164U;
                static const AkUniqueID ON = 1651971902U;
            } // namespace SWITCH
        } // namespace TURBO

        namespace TURNSIGNAL
        {
            static const AkUniqueID GROUP = 3858101368U;

            namespace SWITCH
            {
                static const AkUniqueID IDLE = 1874288895U;
                static const AkUniqueID SEQUENCE = 311444866U;
                static const AkUniqueID TURNOFF = 637426651U;
                static const AkUniqueID TURNON = 2576072551U;
            } // namespace SWITCH
        } // namespace TURNSIGNAL

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID RTPC_ACCELSC = 2654500707U;
        static const AkUniqueID RTPC_BRAKEAMOUNT = 3738715652U;
        static const AkUniqueID RTPC_CAMERADISTANCE = 1203992631U;
        static const AkUniqueID RTPC_DAMAGEVALUE = 491252395U;
        static const AkUniqueID RTPC_DIRECTION = 1018940110U;
        static const AkUniqueID RTPC_DRIFTAMOUNT = 3368035288U;
        static const AkUniqueID RTPC_DRIFTANGLE = 1689494181U;
        static const AkUniqueID RTPC_EXHAUSTAZIMUTH = 3958629485U;
        static const AkUniqueID RTPC_GEAR = 1692101114U;
        static const AkUniqueID RTPC_GEARSHIFTINGSC = 2378251232U;
        static const AkUniqueID RTPC_HANDBRAKEAMOUNT = 1688749197U;
        static const AkUniqueID RTPC_ISAIRBORNE = 3108363069U;
        static const AkUniqueID RTPC_LOAD = 1193280819U;
        static const AkUniqueID RTPC_NOSINTENCITY = 3806866312U;
        static const AkUniqueID RTPC_RPM = 3774151474U;
        static const AkUniqueID RTPC_SPEED = 1381474336U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID NEW_SOUNDBANK = 4072029455U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID _010_COLLISION = 4072737380U;
        static const AkUniqueID _015_SHIFTGEARS = 1451316327U;
        static const AkUniqueID _018_ACCEL = 1030452868U;
        static const AkUniqueID _019_BRAKES = 2003414403U;
        static const AkUniqueID _020_ENGINE = 247479977U;
        static const AkUniqueID _025_TIRESSURFACE = 4193674518U;
        static const AkUniqueID _030_AMBIENCE = 1948932202U;
        static const AkUniqueID ACCEL = 1778882555U;
        static const AkUniqueID CAR = 983016381U;
        static const AkUniqueID ENGINE = 268529915U;
        static const AkUniqueID EXHAUST = 1377834261U;
        static const AkUniqueID GEARSHIFT = 2729209948U;
        static const AkUniqueID HDR = 931844945U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID OFFLOAD = 2987420976U;
        static const AkUniqueID OFFLOAD_ENGINE = 865541777U;
        static const AkUniqueID ONLOAD = 2466053606U;
        static const AkUniqueID ONLOAD_ENGINE = 3182575763U;
        static const AkUniqueID POPS = 1642235233U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID MALLREVERB = 3375730903U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
